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

namespace Project_Gym
{
    public partial class deletemember : Form
    {
        public deletemember()
        {
            InitializeComponent();
        }

        private void deletemember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=XOXO;Initial Catalog=GymDB;Integrated Security=false;User ID=sa;Password=test123;Connect Timeout=30");

            String qry = "SELECT * FROM MEMBER";
            SqlCommand cmd = new SqlCommand(qry, con);

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "MEMBER");
            dataGridView1.DataSource = ds.Tables["MEMBER"];
        }

        private void cANCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_nic.Text != "" )
            {
                SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=XOXO;Initial Catalog=GymDB;Integrated Security=false;User ID=sa;Password=test123;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DELETE FROM MEMBER WHERE Nic ='" + txt_nic.Text + "'";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);
            dataGridView1.DataSource = ds.Tables["MEMBER"];
            }
            else
                MessageBox.Show("Please Enter Valid NIC Number !!");
        }

        private void bnt_refresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=XOXO;Initial Catalog=GymDB;Integrated Security=false;User ID=sa;Password=test123;Connect Timeout=30");

            String qry = "SELECT * FROM MEMBER";
            SqlCommand cmd = new SqlCommand(qry, con);

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "MEMBER");
            dataGridView1.DataSource = ds.Tables["MEMBER"];
        }
    }
}
