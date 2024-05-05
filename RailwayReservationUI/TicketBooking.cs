using RailwayReservationLibrary.Logic;
using RailwayReservationLibrary.Entities;
using RailwayReservationLibrary.DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace RailwayReservationUI
{
    public partial class TicketBooking : Form
    {
        StationDataLogic _stationLogic = new StationDataLogic();
        int stationId = 0;
        RouteDataLogic _routeLogic = new RouteDataLogic();
        int routeId = 0;
        TrainDataLogic _trainLogic = new TrainDataLogic();
        int trainId = 0;

        public TicketBooking()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            pnlRouteForm.Hide();
            pnlTrainsForm.Hide();

            pnlStationForm.Location = new Point(21, 121);
            pnlStationForm.Show();
            pnlStationForm.Enabled = false;
            pnlSeach.Visible = true;
            dataGridView.Visible = true;
            FillGridViewWithStationData();
            lblResetForm.Show();
        }

        private void lblResetForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetForm();
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            pnlStationForm.Hide();
            pnlTrainsForm.Hide();

            pnlRouteForm.Location = new Point(21, 121);
            pnlRouteForm.Show();
            pnlRouteForm.Enabled = false;
            pnlSeach.Visible = true;
            dataGridView.Visible = true;
            FillGridViewWithRouteData();
            lblResetForm.Show();

            cmbDeparture.DataSource = _stationLogic.GetAllStations();
            cmbDeparture.ValueMember = "Id";
            cmbDeparture.DisplayMember = "StationName";

            cmbDestination.DataSource = _stationLogic.GetAllStations();
            cmbDestination.ValueMember = "Id";
            cmbDestination.DisplayMember = "StationName";
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            pnlStationForm.Hide();
            pnlRouteForm.Hide();

            pnlTrainsForm.Location = new Point(21, 12);
            pnlTrainsForm.Show();
            pnlTrainsForm.Enabled = false;
            pnlSeach.Visible = true;
            dataGridView.Visible = true;
            FillGridViewWithTrainData();
            lblResetForm.Visible = true;

            cmbRoute.DataSource = _routeLogic.GetAllRoutes();
            cmbRoute.ValueMember = "Id";
            cmbRoute.DisplayMember = "RouteName";
        }

        private void TicketBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (pnlStationForm.Visible)
            {
                pnlStationForm.Enabled = true;
            }

            if (pnlRouteForm.Visible)
            {
                pnlRouteForm.Enabled = true;
            }

            if (pnlTrainsForm.Visible)
            {
                pnlTrainsForm.Enabled = true;
            }
        }

        private void btnSaveStation_Click(object sender, EventArgs e)
        {
            try
            {
                Station station = new Station
                {
                    Id = stationId,
                    StationName = txtStation.Text,
                    City = txtCity.Text
                };

                //Save Station data
                if (btnSaveStation.Text == "Save Station Details")
                {
                    int result = _stationLogic.CreateStation(station);
                    if (result > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                        FillGridViewWithStationData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Station data could not be saved");
                    }
                }

                //update station data
                if (btnSaveStation.Text == "Edit Station Details")
                {
                    int result = _stationLogic.UpdateStation(station);
                    if (result > 0)
                    {
                        MessageBox.Show("Data updated successfully");
                        FillGridViewWithStationData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Station data could not be updated.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem in saving station data");
            }
        }

        private void btnSaveRoute_Click(object sender, EventArgs e)
        {
            try
            {
                Route route = new Route
                {
                    Id = routeId,
                    RouteName = txtRouteName.Text,
                    DepartureStationId = (int)cmbDeparture.SelectedValue,
                    DestinationStationId = (int)cmbDestination.SelectedValue,
                    Distance = Convert.ToDouble(txtTotalDistance.Text),
                    Fare = Convert.ToInt32(txtFare.Text)
                };

                if (btnSaveRoute.Text == "Save Route Details")
                {
                    int result = _routeLogic.CreateRoute(route);
                    if (result > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                        FillGridViewWithRouteData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Route data could not be saved.");
                    }
                }

                if (btnSaveRoute.Text == "Edit Route Details")
                {
                    int result = _routeLogic.UpdateRoute(route);
                    if (result > 0)
                    {
                        MessageBox.Show("Data updated successfully");
                        FillGridViewWithRouteData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Route data could not be updated.");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Problem in saving route data");
            }
        }

        private void btnSaveTrain_Click(object sender, EventArgs e)
        {
            try
            {
                Trains train = new Trains
                {
                    Id = trainId,
                    TrainName = txtTrainName.Text,
                    Description = txtDescription.Text,
                    NoOfCoaches = Convert.ToInt32(txtNoOfCoaches.Text),
                    RouteId = Convert.ToInt32(cmbRoute.SelectedValue)
                };

                if(btnSaveTrain.Text == "Save Train Details")
                {
                    int result = _trainLogic.CreateTrain(train);
                    if(result > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                        FillGridViewWithTrainData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Train data could not be saved.");
                    }
                }

                if(btnSaveTrain.Text == "Edit Train Details")
                {
                    int result = _trainLogic.UpdateTrain(train);
                    if(result > 0)
                    {
                        MessageBox.Show("Data updated successfully");
                        FillGridViewWithTrainData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Train data could not be updated.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem in saving train data");
            }
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (pnlStationForm.Visible)
            {
                btnSaveStation.Text = "Edit Station Details";

                Station station = _stationLogic.Find(dataGridView.SelectedRows[0].Cells[1].Value.ToString());
                if (station != null)
                {
                    stationId = station.Id;
                    txtStation.Text = station.StationName;
                    txtCity.Text = station.City;

                    pnlStationForm.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Could not load the data");
                }
            }

            if (pnlRouteForm.Visible)
            {
                btnSaveRoute.Text = "Edit Route Details";

                Route route = _routeLogic.Find(dataGridView.SelectedRows[0].Cells[1].Value.ToString());
                if (route != null)
                {
                    routeId = route.Id;
                    txtRouteName.Text = route.RouteName;
                    cmbDeparture.SelectedValue = route.DepartureStationId;
                    cmbDestination.SelectedValue = route.DestinationStationId;
                    txtTotalDistance.Text = route.Distance.ToString();
                    txtFare.Text = route.Fare.ToString();

                    pnlRouteForm.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Could not load the data");
                }
            }

            if (pnlTrainsForm.Visible)
            {
                btnSaveTrain.Text = "Edit Train Details";

                Trains train = _trainLogic.Find(dataGridView.SelectedRows[0].Cells[1].Value.ToString());
                if (train != null)
                {
                    trainId = train.Id;
                    txtTrainName.Text = train.TrainName;
                    txtDescription.Text = train.Description;
                    txtNoOfCoaches.Text = train.NoOfCoaches.ToString();
                    cmbRoute.SelectedValue = train.RouteId;

                    pnlTrainsForm.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Could not load the data");
                }
            }
        }

        //Private methods 
        public void ResetForm()
        {
            if (pnlStationForm.Visible)
            {
                txtStation.Text = "";
                txtCity.Text = "";
            }

            if (pnlRouteForm.Visible)
            {
                txtRouteName.Text = "";
                cmbDeparture.SelectedIndex = 0;
                cmbDestination.SelectedIndex = 0;
                txtTotalDistance.Text = "";
                txtFare.Text = "";
            }

            if (pnlTrainsForm.Visible)
            {
                txtTrainName.Text = "";
                txtDescription.Text = "";
                txtNoOfCoaches.Text = "";
                cmbRoute.SelectedIndex = 0;
            }
        }

        private void FillGridViewWithStationData()
        {
            try
            {
                string sqlQuery = "Select * from Stations;";

                using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
                {
                    using (DataTable dataTable = new DataTable("Stations"))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                        {
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            dataAdapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem while loading data in the GridView\n" + ex.Message);
            }
        }

        private void FillGridViewWithRouteData()
        {
            try
            {
                string sqlQuery = "Select * from Routes;";

                using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
                {
                    using (DataTable dataTable = new DataTable("Routes"))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                        {
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            dataAdapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem while loading data in the GridView\n" + ex.Message);
            }
        }

        private void FillGridViewWithTrainData()
        {
            try
            {
                string sqlQuery = "Select * from Trains;";

                using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
                {
                    using (DataTable dataTable = new DataTable("Trains"))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                        {
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            dataAdapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem while loading data in the GridView\n" + ex.Message);
            }
        }

    }
}