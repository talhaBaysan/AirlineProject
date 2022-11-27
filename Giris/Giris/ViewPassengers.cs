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
    public partial class ViewPassengers : Form
    {
        public ViewPassengers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=TOSHIBA-PC;Initial Catalog=AirlineDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
        private void populate()
        {
            Con.Open();
            string query = "select * from PassengersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassangerDGV.DataSource = ds.Tables[0]; 
            Con.Close();
        }

        private void fillPassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengersTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PidCb.ValueMember = "PassId";
            PidCb.DataSource = dt;
            Con.Close();
        }

        private void fetchPassenger()
        {
            Con.Open();
            string query = "select * from PassengersTbl where PassId = " + PidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PnameTb.Text = dr["PassName"].ToString();
                PpassTb.Text = dr["Passport"].ToString();
                PaddTb.Text = dr["PassAd"].ToString();
                NatCb.Text = dr["PassNat"].ToString();
                GendCb.Text = dr["PassGend"].ToString();
                PphoneTb.Text = dr["PassPhone"].ToString();
            }
            Con.Close();
        }

        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            fillPassenger();
            populate();
        }

        private void PassangerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PassangerDGV.ReadOnly = true;
        }
        
        private void VPUpdateBtn_Click(object sender, EventArgs e)
        {
            if (PidCb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" ||
                PaddTb.Text == "" || NatCb.Text == "" || GendCb.Text == "" || PphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengersTbl set PassName = '" + PnameTb.Text + "', Passport = '" + PpassTb.Text + "', PassAd = '" + PaddTb.Text + "', PassNat = '" + NatCb.SelectedItem.ToString() + "', PassGend = '" + GendCb.SelectedItem.ToString() + "', PassPhone = '" + PphoneTb.Text + "' where PassId = " + PidCb.SelectedValue.ToString() + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Succesfully");

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void VPDeleteBtn_Click(object sender, EventArgs e)
        {
            if (PidCb.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengersTbl where PassId = " + PidCb.SelectedValue.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passanger Delete Succesfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void VPResetBtn_Click(object sender, EventArgs e)
        {
            PidCb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text = "";
            NatCb.Text = "";
            GendCb.Text = "";
            PphoneTb.Text = "";
        }

        private void VPBackBtn_Click(object sender, EventArgs e)
        {
            Passengers addpas = new Passengers();
            addpas.Show();
            this.Hide();
        }

        private void VPExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchPassenger();
        }
    }
}
