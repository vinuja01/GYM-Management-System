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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Gym
{
    public partial class searchequipment : Form
    {
        public searchequipment()
        {
            InitializeComponent();
        }

        private void cANCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
             SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=XOXO;Initial Catalog=GymDB;Integrated Security=false;User ID=sa;Password=test123;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM EQUIPTMENT WHERE Name ='" + txt_name.Text + "'";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);
                MessageBox.Show("Done");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
                MessageBox.Show("Please Enter Name !!");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchequipment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=XOXO;Initial Catalog=GymDB;Integrated Security=false;User ID=sa;Password=test123;Connect Timeout=30");

            String qry = "SELECT * FROM EQUIPTMENT ";
            SqlCommand cmd = new SqlCommand(qry, con);

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "EQUIPTMENT");
            dataGridView1.DataSource = ds.Tables["EQUIPTMENT"];
        }
    }
}
