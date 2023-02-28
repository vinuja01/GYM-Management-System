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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Gym
{
    public partial class newstaff : Form
    {
        public newstaff()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newstaff_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_number.Clear();

            btn_male.Checked = false;
            btn_female.Checked = false;

            join_dateTimePicker.Value = DateTime.Now;
            dob_TimePicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (txt_fname.Text != "" && txt_lname.Text != "" 
                && txt_address.Text != "" 
                && txt_email.Text != "" 
                && dob_TimePicker.Text != "" 
                && join_dateTimePicker.Text != "" 
                && nic_no.Text != "" 
                && txt_number.Text != ""  
                && txt_number.Text!="")
            {
                String fname = txt_fname.Text;
                String lname = txt_lname.Text;
                String address = txt_address.Text;
                String email = txt_email.Text;
                String dob = dob_TimePicker.Text;
                String jdate = join_dateTimePicker.Text;
                String nic = nic_no.Text;
                int num = int.Parse(txt_number.Text);

                String gender = "";
                bool isChecked = btn_male.Checked;

                if (isChecked)
                {
                    gender = btn_male.Text;
                }
                else
                {
                    gender = btn_female.Text;
                }


                SqlConnection con = new SqlConnection(@"Data Source=XOXO;Initial Catalog=GymDB;Integrated Security=false;User ID=sa;Password=test123;Connect Timeout=30");

                String qry = "INSERT INTO STAFF (NIC,Fname,Lname,JDate,Dob,Mnumber,Gender,Address,email)  VALUES ('" + nic + "','" + fname + "','" + lname + "','" + jdate + "','" + dob + "','" + num + "','" + gender + "','" + address + "','" + email + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful..");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();

                    this.Hide();

                }
            }
            else
                MessageBox.Show("Your are Missing Some Data .. ");
        }
    }
}
