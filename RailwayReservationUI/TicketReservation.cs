using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using RailwayReservationLibrary.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservationUI
{
    public partial class TicketReservation : Form
    {
        StationDataLogic _stations = new StationDataLogic();
        TrainDataLogic _trains = new TrainDataLogic();
        RouteDataLogic _routes = new RouteDataLogic();
        int _trainId;
        int _routeId;
        
        public TicketReservation()
        {
            InitializeComponent();
        }

        private void TicketReservation_Load(object sender, EventArgs e)
        {
            FillFromToDropdownListWithData();
            txtStepCounter.Text = "Step1";
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtDateOfDeparture.Text = dateTimePicker.Value.ToShortDateString();
        }

        private void btnSearchTrain_Click(object sender, EventArgs e)
        {
            List<Station> stations = _stations.GetAllStations();
            List<Route> routes = _routes.GetAllRoutes();
            List<Trains> trains = _trains.GetAllTrains();
            txtStepCounter.Text = "Step1";

            var results = from train in trains
                          join route in routes
                          on train.RouteId equals route.Id
                          where (int)cmbFrom.SelectedValue == route.DepartureStationId && (int)cmbTo.SelectedValue == route.DestinationStationId
                          select new
                          {                              
                              TrainName = train.TrainName,
                              Description = train.Description,
                              Fare = route.Fare,
                              Distance = route.Distance,
                              NoOfCoaches = train.NoOfCoaches,
                              RouteName = route.RouteName,                           
                          };

            

            pnlGridViewSearchedTrains.Visible = true;

            // Create a DataTable to hold the results
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainName");
            dt.Columns.Add("Description");
            dt.Columns.Add("Fare", typeof(int));
            dt.Columns.Add("Distance", typeof(int));
            dt.Columns.Add("NoOfCoaches", typeof(int));
            dt.Columns.Add("RouteName");

            // Populate the DataTable with the results
            foreach (var result in results)
            {
                dt.Rows.Add(result.TrainName, result.Description, result.Fare, result.Distance, result.NoOfCoaches, result.RouteName);
            }

            // Set the DataTable as the DataSource for the DataGridView
            dataGridViewSearchedTrains.DataSource = dt;

            pnlButtons.Visible = true;
            pnlPassengerInformation.Visible = false;
            pnlGridViewSearchedTrains.Visible = true;
            pnlSearchTrain.Enabled = false;
        }

        private void dataGridViewSearchedTrains_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                dataGridViewSearchedTrains.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Station> stations = _stations.GetAllStations();
            List<Route> routes = _routes.GetAllRoutes();
            List<Trains> trains = _trains.GetAllTrains();

            if (txtStepCounter.Text == "Step1")
            {
                pnlBookingInfoTrainInfo.Visible = true;
                lblBookingHeading.Visible = true;

                lblTrainName.Text = dataGridViewSearchedTrains.SelectedRows[0].Cells[0].Value.ToString();
                lblDescriptionValue.Text = dataGridViewSearchedTrains.SelectedRows[0].Cells[1].Value.ToString();

                var stationNameFrom = stations
                                    .Where(station => station.Id == Convert.ToInt32(cmbFrom.SelectedValue))
                                    .Select(station => station.StationName)
                                    .FirstOrDefault();
                lblFromStationName.Text = stationNameFrom != null ? stationNameFrom : "Station not found";

                var stationNameTo = stations.
                                    Where(station => station.Id == Convert.ToInt32(cmbTo.SelectedValue))
                                    .Select(station => station.StationName)
                                    .FirstOrDefault();
                lblToStationName.Text = stationNameTo != null ? stationNameTo : "Station not found";

                lblBookingDate.Text = txtDateOfDeparture.Text;
                lblFareAmount.Text = dataGridViewSearchedTrains.SelectedRows[0].Cells[2].Value.ToString();
                lblDistanceValue.Text = dataGridViewSearchedTrains.SelectedRows[0].Cells[3].Value.ToString();

                //Getting the key of route based on the FromStation and ToStation
                _routeId = routes
                       .Where(station => station.DepartureStationId == Convert.ToInt32(cmbFrom.SelectedValue) && station.DestinationStationId == Convert.ToInt32(cmbTo.SelectedValue))
                       .Select(route => route.Id) .FirstOrDefault();

                _trainId = trains
                            .Where(train => train.RouteId == _routeId)
                            .Select(train => train.Id).FirstOrDefault();

                btnPrevious.Enabled = true;
                pnlGridViewSearchedTrains.Visible = false;
                pnlPassengerInformation.Visible = true;
                pnlPassengerInformation.Location = new Point(5, 273);
            }

            if (txtStepCounter.Text == "Step2")
            {
                pnlBookingInfoPassengerInfo.Visible = true;
                lblPassengerNameValue.Text = txtPassengerName.Text;
                lblPassengerCNICValue.Text = txtPassengerCNIC.Text;
                lblClassValue.Text = cmbTravelClass.SelectedItem.ToString();
                lblAdultsValue.Text = txtNoOfAdults.Text;
                lblChildrensValue.Text = txtNoOfChildrens.Text;
                lblInfantsValue.Text = txtNoOfInfants.Text;

                lblAdultsFare.Text = lblAdultsFareInfo.Text;
                lblChildrensFare.Text = lblChildrensFareInfo.Text;
                lblInfantsFare.Text = lblInfantsFareInfo.Text;

                int adultsTotal = (Convert.ToInt32(lblChildrensValue.Text) * Convert.ToInt32(lblAdultsFare.Text));
                int childrensTotal = (Convert.ToInt32(lblAdultsValue.Text) * Convert.ToInt32(lblChildrensFare.Text));
                int infantsTotal = (Convert.ToInt32(lblInfantsValue.Text) * Convert.ToInt32(lblInfantsFare.Text));
                int grandTotal = adultsTotal + childrensTotal + infantsTotal;

                if (txtNoOfAdults.Text != null)
                {
                    lblAdultsTotalAmount.Text = adultsTotal.ToString();
                }
                if (txtNoOfChildrens.Text != null)
                {
                    lblChildrensTotalAmount.Text = childrensTotal.ToString();
                }
                if (txtNoOfInfants.Text != null)
                {
                    lblInfantsTotalAmount.Text = infantsTotal.ToString();
                }
                if (grandTotal > 0)
                {
                    lblGrandTotalAmount.Text = grandTotal.ToString();
                }


                pnlTermsAndBookButton.Visible = true;
            }

            if (pnlSearchTrain.Enabled)
            {
                txtStepCounter.Text = "Step1";
            }
            else
            {
                txtStepCounter.Text = "Step2";
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pnlPassengerInformation.Visible = false;
            pnlGridViewSearchedTrains.Visible = true;
            btnPrevious.Enabled = false;
            lblBookingHeading.Visible = false;
            pnlBookingInfoTrainInfo.Visible = false;
            pnlSearchTrain.Enabled = true;
            pnlBookingInfoPassengerInfo.Visible = false;
            pnlTermsAndBookButton.Visible = false;
            txtStepCounter.Text = "Step1";
        }

        private void cmbTravelClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateFare(cmbTravelClass.SelectedItem.ToString());
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            string sqlQuery = "Insert into Reservations (TrainId, RouteId, Class, PassengerName, CNIC, TotalAdultPassengers, TotalChildPassengers, TotalInfantPassengers) values(@TrainId, @RouteId, @Class, @PassengerName, @CNIC, @TotalAdultPassengers, @TotalChildPassengers, @TotalInfantPassengers)";

            try
            {
                using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    cmd.Parameters.AddWithValue("@TrainId", _trainId);
                    cmd.Parameters.AddWithValue("@RouteId", _routeId);
                    cmd.Parameters.AddWithValue("@Class", cmbTravelClass.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PassengerName", txtPassengerName.Text);
                    cmd.Parameters.AddWithValue("@CNIC", txtPassengerCNIC.Text);
                    cmd.Parameters.AddWithValue("@TotalAdultPassengers", txtNoOfAdults.Text);
                    cmd.Parameters.AddWithValue("@TotalChildPassengers", txtNoOfChildrens.Text);
                    cmd.Parameters.AddWithValue("@TotalInfantPassengers", txtNoOfChildrens.Text);

                    int result = cmd.ExecuteNonQuery();

                    if(result > 0)
                    {
                        MessageBox.Show("Ticket booked Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Problem in booking the tiecket");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problem in sql query or database connectivity! \n" + ex.Message);
            }            
        }

        //Private methods
        private void CalculateFare(string travelClass)
        {
            int AdultsFare = 0;
            int ChildrensFare = 0;
            int InfantsFare = 0;

            if (travelClass == "Economy")
            {
                AdultsFare = Convert.ToInt32(lblFareAmount.Text);
                lblAdultsFareInfo.Text = AdultsFare.ToString();

                ChildrensFare = AdultsFare / 2;
                lblChildrensFareInfo.Text = ChildrensFare.ToString();

                InfantsFare = AdultsFare / 4;
                lblInfantsFareInfo.Text = InfantsFare.ToString();
            }

            if (travelClass == "AC")
            {
                int fare = (Convert.ToInt32(lblFareAmount.Text)) * 30 / 100;
                AdultsFare = Convert.ToInt32(lblFareAmount.Text) + fare;
                lblAdultsFareInfo.Text = AdultsFare.ToString();

                ChildrensFare = AdultsFare / 2;
                lblChildrensFareInfo.Text = ChildrensFare.ToString();

                InfantsFare = AdultsFare / 4;
                lblInfantsFareInfo.Text = InfantsFare.ToString();
            }

            if (travelClass == "AC Parlour")
            {
                int fare = (Convert.ToInt32(lblFareAmount.Text)) * 60 / 100;
                AdultsFare = Convert.ToInt32(lblFareAmount.Text) + fare;
                lblAdultsFareInfo.Text = AdultsFare.ToString();

                ChildrensFare = AdultsFare / 2;
                lblChildrensFareInfo.Text = ChildrensFare.ToString();

                InfantsFare = AdultsFare / 4;
                lblInfantsFareInfo.Text = InfantsFare.ToString();
            }

            if (travelClass == "Business")
            {
                AdultsFare = Convert.ToInt32(lblFareAmount.Text) * 2;
                lblAdultsFareInfo.Text = AdultsFare.ToString();

                ChildrensFare = AdultsFare / 2;
                lblChildrensFareInfo.Text = ChildrensFare.ToString();

                InfantsFare = AdultsFare / 4;
                lblInfantsFareInfo.Text = InfantsFare.ToString();
            }

        }

        private void FillFromToDropdownListWithData()
        {
            cmbFrom.DataSource = _stations.GetAllStations();
            cmbFrom.ValueMember = "Id";
            cmbFrom.DisplayMember = "StationName";

            cmbTo.DataSource = _stations.GetAllStations();
            cmbTo.ValueMember = "Id";
            cmbTo.DisplayMember = "StationName";
        }

        
    }
}
