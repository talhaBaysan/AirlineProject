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
    public partial class Passengers : Form
    {
        public Passengers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=TOSHIBA-PC;Initial Catalog=AirlineDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void PRecordBtn_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PassAd.Text == "" || PassName.Text == "" ||
                PassportTb.Text == "" || NationalityCb.Text == "" || GenderCb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengersTbl values(" + PassId.Text + ",'" + PassName.Text + "','" + PassportTb.Text + "','" + PassAd.Text + "','" + NationalityCb.SelectedItem.ToString() + "','" + GenderCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Succesfully");

                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void PResetBtn_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassAd.Text = "";
            PassName.Text = "";
            PassportTb.Text = "";
            NationalityCb.Text = "";
            GenderCb.Text = "";
            PhoneTb.Text = "";
        }

        private void PBackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ViewPassengerBtn_Click(object sender, EventArgs e)
        {
            ViewPassengers viewpass = new ViewPassengers();
            viewpass.Show();
            this.Hide();
        }

        private void PExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
