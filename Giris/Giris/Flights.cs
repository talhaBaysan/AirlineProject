using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Giris
{
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=TOSHIBA-PC;Initial Catalog=AirlineDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void FRecordBtn_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || FsrcCb.Text == "" || FdestCb.Text == "" ||
                FdateDt.Text == "" || FcapTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightsTbl values('" + FcodeTb.Text + "','" + FsrcCb.SelectedItem.ToString() + "','" + FdestCb.SelectedItem.ToString() + "','" + FdateDt.Value.ToString() + "'," + FcapTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Succesfully");

                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void FResetBtn_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            FsrcCb.Text = "";
            FdestCb.Text = "";
            FdateDt.Text = "";
            FcapTb.Text = "";
        }

        private void FBackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ViewFlightsBtn_Click(object sender, EventArgs e)
        {
            ViewFlights viewflight = new ViewFlights();
            viewflight.Show();
            this.Hide();
        }

        private void Flights_Load(object sender, EventArgs e)
        {

        }

        private void FExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
