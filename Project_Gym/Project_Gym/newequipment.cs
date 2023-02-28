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
    public partial class newequipment : Form
    {
        public newequipment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void m_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cANCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_dis.Clear();
            txt_name.Clear();
            type_comboBox.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text;
            String description = txt_dis.Text;
            String type = type_comboBox.Text;
            


            SqlConnection con = new SqlConnection(@"Data Source=XOXO;Initial Catalog=GymDB;Integrated Security=false;User ID=sa;Password=test123;Connect Timeout=30");

            String qry = "INSERT INTO EQUIPTMENT (Name,Description,Type)  VALUES ('" + name + "','" + description + "','" + type + "')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved..");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

                txt_dis.Clear();
                txt_name.Clear();
                type_comboBox.ResetText();
            }
        }
    }
}
