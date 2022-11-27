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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=TOSHIBA-PC;Initial Catalog=AirlineDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightsTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "Fcode";
            FCodeCb.DataSource = dt;
            Con.Close();
        }

        private void fetchFlight()
        {
            Con.Open();
            string query = "select * from FlightsTbl where Fcode = '" + FCodeCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FSrcCb.Text = dr["Fsrc"].ToString();
                FDestCb.Text = dr["Fdest"].ToString();
                FDateDt.Text = dr["Fdate"].ToString();
                FCapTb.Text = dr["Fcap"].ToString();

            }
            Con.Close();
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            fillFlightCode();
            populate();
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FlightDGV.ReadOnly = true;
        }
                
        private void VFUptadeBtn_Click(object sender, EventArgs e)
        {
            if (FCodeCb.Text == "" || FSrcCb.Text == "" || FDestCb.Text == "" ||
                FDateDt.Text == "" || FCapTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightsTbl set Fsrc = '" + FSrcCb.SelectedItem.ToString() + "', Fdest = '" + FDestCb.SelectedItem.ToString() + "', Fdate = '" + FDateDt.Value.Date.ToString() + "', Fcap = " + FCapTb.Text + " where Fcode = '" + FCodeCb.SelectedValue.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Succesfully");

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void VFDeleteBtn_Click(object sender, EventArgs e)
        {
            if (FCodeCb.Text == "")
            {
                MessageBox.Show("Enter The Flight to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightsTbl where Fcode = '" + FCodeCb.SelectedValue.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Delete Succesfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void VFBackBtn_Click(object sender, EventArgs e)
        {
            Flights flight = new Flights();
            flight.Show();
            this.Hide();
        }

        private void VFResetBtn_Click(object sender, EventArgs e)
        {
            FCodeCb.Text = "";
            FSrcCb.Text = "";
            FDestCb.Text = "";
            FDateDt.Text = "";
            FCapTb.Text = "";
        }

        private void VFExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FCodeCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchFlight();
        }
    }
}
