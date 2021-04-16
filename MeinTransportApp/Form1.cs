using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MeinTransportApp
{
    public partial class Form1 : Form
    {
        ITransport transport = new Transport();
                                                                 
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void ClickSearch(object sender, EventArgs e)
        {

            string startstation = tbxStart.Text;
            string endstation = tbxEnd.Text;
            dgvConnections.Rows.Clear();
            //Suche nach Verbindungne der eingegebenen Stationen
            try
            {

                Connections connections = transport.GetConnections(startstation, endstation, dtpDate.Value.ToString("yyyy-MM-dd"), dtpTime.Value.ToString("HH:mm"));

                if (4 == connections.ConnectionList.Count)
                {


                    for (int i = 0; i <= connections.ConnectionList.Count - 1; i++)
                    {

                        string time = connections.ConnectionList[i].From.Departure.Value.ToString("yyyy:MM:dd \r\n HH:mm");
                        string start = connections.ConnectionList[i].From.Station.Name;
                        string end = connections.ConnectionList[i].To.Station.Name;
                        string platform = connections.ConnectionList[i].From.Platform;
                        string endtime = connections.ConnectionList[i].To.Arrival?.ToString("HH:mm") ?? "unknown";

                        dgvConnections.Rows.Add(time, start, end, platform, endtime);


                    }
                }
                else
                    {
                    MessageBox.Show("Bitte geben sie gültige Werte ein");
                }
            }
            catch
            {
                MessageBox.Show("Bitte geben sie gültige Werte ein");
            }




        }

        private void predictionstart(object sender, EventArgs e)
        {
            //Suche für vrschläge der eingegenen Startstation
            if (tbxStart.Text != lbxPredictionStart.Text)
            {
                lbxPredictionStart.Items.Clear();

                try
                {
                    string selection = tbxStart.Text;
                    List<Station> stations = transport.GetStations(selection + "*").StationList;
                    foreach (Station station in stations)

                    {
                        lbxPredictionStart.Items.Add(station.Name);
                    }
                }
                catch
                {
    
                }
                if(tbxEnd.Text != "" && tbxStart.Text != "")
                {
                    btnSearch.BackColor = Color.LightGreen;
                }

            }

        }


        private void ClickTafel(object sender, EventArgs e)
        {
            //Ausgabe der Abfahrtstafel
            try
            {


                StationBoardRoot stationBoards = transport.GetStationBoard(tbxStation.Text, transport.GetStations(tbxStation.Text).StationList[0].Id.ToString() );
                dgvAbfahrtstafel.Rows.Clear();
                for (int i = 0; i <= 14; i++)
                {
                    dgvAbfahrtstafel.Rows.Add(stationBoards.Entries[i].Stop.Departure.ToShortTimeString(), stationBoards.Entries[i].To.ToString(), stationBoards.Entries[i].Number.ToString());



                }
            }
            catch
            {
                MessageBox.Show("Bitte geben sie gültige Werte ein");
            }

        }

        private void predictionend(object sender, EventArgs e)
        {

            //Vorschläge zur eingegebenen Endstation
            if (tbxEnd.Text != lbxPredictionEnd.Text)
            {
                lbxPredictionEnd.Items.Clear();

                try
                {
                    string selection = tbxEnd.Text;
                    List<Station> stations = transport.GetStations(selection + "*").StationList;
                    foreach (Station station in stations)

                    {
                        lbxPredictionEnd.Items.Add(station.Name);
                    }
                }
                catch
                {
                
                }
               
            }
            if (tbxEnd.Text != "" && tbxStart.Text != "")
            {
                btnSearch.BackColor = Color.LightGreen;
            }


        }

        private void selectPredictionEnd(object sender, EventArgs e)
        {
            //Einsetzen der Vorgeschlagenen Station
            tbxEnd.Text = lbxPredictionEnd.Text;
            lbxPredictionEnd.Items.Clear();
        }

        private void selectPredictionStart(object sender, EventArgs e)
        {
            //Einsetzen der Vorgeschlagenen Station
            tbxStart.Text = lbxPredictionStart.Text;
            lbxPredictionStart.Items.Clear();
        }

        private void changetafel(object sender, EventArgs e)
        {



            //vorschläge zur eingegebenen station zur Abfahrtstafel
            if (tbxStation.Text != lbxPredictionTafel.Text)
            {
                lbxPredictionTafel.Items.Clear();

                try
                {
                    string selection = tbxStation.Text;
                    List<Station> stations = transport.GetStations(selection).StationList;
                    foreach (Station station in stations)

                    {
                        lbxPredictionTafel.Items.Add(station.Name);
                    }
                }
                catch
                {
                
                }
                if (tbxStation.Text != "")
                {
                    btnTafel.BackColor = Color.LightGreen;
                }

            }


        }

        private void GetTafelPrediction(object sender, EventArgs e)
        {
            //Einsetzen der vorgeschlagenen Station
            tbxStation.Text = lbxPredictionTafel.Text;
            lbxPredictionTafel.Items.Clear();
        }


    }
    
}








