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
    public partial class Cancellations : Form
    {
        public Cancellations()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=TOSHIBA-PC;Initial Catalog=AirlineDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void populate()
        {
            Con.Open();
            string query = "select * from CancelsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancellationDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fillTicketId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Tid from TicketsTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tid", typeof(int));
            dt.Load(rdr);
            TIdCb.ValueMember = "Tid";
            TIdCb.DataSource = dt;
            Con.Close();
        }

        private void fetchFcode()
        {
            Con.Open();
            string query = "select * from TicketsTbl where Tid = " + TIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FCodeTb.Text = dr["Fcode"].ToString();

            }
            Con.Close();
        }

        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();
        }

        private void TIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchFcode();
        }
        /*
        private void deleteTicket()
        {
            try
            {
                Con.Open();
                string query = "delete from TicketsTbl where Tid = " + TIdCb.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket Delete Succesfully");
                Con.Close();
                //populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        */
        private void CCancelBtn_Click(object sender, EventArgs e)
        {
            if (CIdTb.Text == "" || FCodeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CancelsTbl values(" + CIdTb.Text + "," + TIdCb.SelectedValue.ToString() + ",'" + FCodeTb.Text + "','" + CDateDt.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancelled Succesfully");

                    Con.Close();
                    populate();
                    //deleteTicket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void CResetBtn_Click(object sender, EventArgs e)
        {
            CIdTb.Text = "";
            TIdCb.Text = "";
            FCodeTb.Text = "";
            CDateDt.Text = "";
        }

        private void CBackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void CExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancellationDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CancellationDGV.ReadOnly = true;
        }
    }
}
