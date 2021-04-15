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
            
        }

        private void ClickSearch(object sender, EventArgs e)
        {

            string startstation = tbxStart.Text;
            string endstation = tbxEnd.Text;

            try
            {

                Connections connections = transport.GetConnections(startstation, endstation, dtpDate.Value.ToString("yyyy-MM-dd"), dtpTime.Value.ToString("hh:mm"));


                for (int i = 0; i <= connections.ConnectionList.Count - 1; i++)
                {

                    string time = connections.ConnectionList[i].From.Departure.Value.ToString("yyyy:MM:dd     HH:mm");
                    string start = connections.ConnectionList[i].From.Station.Name;
                    string end = connections.ConnectionList[i].To.Station.Name;
                    string platform = connections.ConnectionList[i].From.Platform;
                    string endtime = connections.ConnectionList[i].To.Arrival?.ToString("HH:mm") ?? "unknown";

                    dgvConnections.Rows.Add(time, start, end, platform, endtime);


                }
            }
            catch
            {

            }




        }

        private void predictionstart(object sender, EventArgs e)
        {

            try
            {
                //Ohne könnte man neue Vorschläge nicht mehr sehen, falls man ein Buchstabe falsch eingeben hat und es löscht
                lbxPredictionStart.Items.Clear();

                List<Station> stations = transport.GetStations("*" + tbxStart.Text + "*").StationList;
                foreach (Station station in stations)
                {
                    lbxPredictionStart.Items.Add(station.Name);
                }
            }
            catch
            {

            }

        }

        private void ShowSearch(object sender, EventArgs e)
        {
            
            

        }

        private void ShowAbfahrtstafel(object sender, EventArgs e)
        {
;

            



        }



        private void ClickTafel(object sender, EventArgs e)
        {
            try
            {


                StationBoardRoot stationBoards = transport.GetStationBoard(tbxStation.Text, transport.GetStations(tbxStation.Text).StationList[0].Id.ToString() );
                dgvAbfahrtstafel.Rows.Clear();
                for (int i = 0; i <= stationBoards.Entries.Count - 1; i++)
                {
                    dgvAbfahrtstafel.Rows.Add(stationBoards.Entries[i].Stop.Departure.ToShortTimeString());



                }
            }
            catch
            {

            }

        }

        private void predictionend(object sender, EventArgs e)
        {

            
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



        }

        private void selectPredictionEnd(object sender, EventArgs e)
        {
            tbxEnd.Text = lbxPredictionEnd.Text;
            lbxPredictionEnd.Items.Clear();
        }

        private void selectPredictionStart(object sender, EventArgs e)
        {
            tbxStart.Text = lbxPredictionStart.Text;
            lbxPredictionStart.Items.Clear();
        }

        private void changetafel(object sender, EventArgs e)
        {




            if (tbxStation.Text != lbxPredictionTafel.Text)
            {
                lbxPredictionTafel.Items.Clear();

                try
                {
                    string selection = tbxStation.Text;
                    List<Station> stations = transport.GetStations(selection + "*").StationList;
                    foreach (Station station in stations)

                    {
                        lbxPredictionTafel.Items.Add(station.Name);
                    }
                }
                catch
                {

                }

            }


        }




    }
    
}








