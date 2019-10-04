using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Gricd_project
{
    public partial class Login : Form
    {

        OleDbConnection myConnString = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=\"C:\\Users\\DELL\\Documents\\Gricd_project.accdb\"");
        public Login()
        {
            InitializeComponent();
            //this.panel1.Size = new System.Drawing.Size(2000, 1000);Persist Security Info=True;Jet OLEDB:Database Password = user");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

            String bbn;
        private void login_Click(object sender, EventArgs e)
        {

      
            OleDbCommand cmd = myConnString.CreateCommand();


            cmd.Connection = myConnString;
            try
            {
                //cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT lpassword FROM registration WHERE lluser = '" + luser.Text + "'";


                myConnString.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bbn = reader["lpassword"].ToString();
                }
                if (lpass.Text == bbn)
                {
                    MessageBox.Show("login successful");
                    this.Hide();
                    Inventory oForm =new Inventory();
                    //oForm = new Form2();
                    oForm.Show();
                  
                }


                else
                {
                    luser.Clear();
                    lpass.Clear();
                    MessageBox.Show("Invalid username or Password");

                    if (luser.Text == " ")
                    {
                        luser.Text = "Email or Username ";
                        luser.ForeColor = Color.Silver;
                    }
                    else
                    {
                        luser.Text = " ";
                        luser.ForeColor = Color.Black;
                    }


                }
            }
            catch (Exception e1)
            {

            }
            myConnString.Close();



        }
        

            private void cancel1_Click(object sender, EventArgs e)
        {
             Application.Exit();
            //rfirst.Text = "";
            
        }


        private void register_Click(object sender, EventArgs e)
        {
            string first_name = this.rfirst.Text;
            string surname = this.rsurname.Text;
            string username = this.ruser.Text;
            string email = this.remail.Text;
            string contents = this.rmobile.Text;
            String pass1 = this.rpass.Text;
            string pass2 = this.rcpass.Text;

            if (first_name.Length == 0)
            {
                MessageBox.Show("first name cannot be Empty\nPlease Enter First Name");

            }
            else if (surname.Length == 0)
            {
                MessageBox.Show("Surname cannot be Empty\nPlease Enter Surname");

            }
            else if (username.Length == 0)
            {
                MessageBox.Show("Username cannot be Empty\nPlease Enter Username");

            }
            else if (email.Length == 0)
            {
                MessageBox.Show("Email is needed\nPlease Enter a valid Email");
            }


            else if (contents.Length == 0)
            {
                MessageBox.Show("moblle number cannot be empty");
            }
            else if (contents.Length < 8)
            {
                MessageBox.Show("mobile number must be more than Eight Digits");

            }
             
            else if (pass1 != pass2)
            {
                MessageBox.Show("password do not match\n make sure the two passwords are the same");

            }
            else if (pass1.Length == 0)
            {
                MessageBox.Show("password cannot be Empty\nPlease Create Password");
            }
            else if (pass1.Length < 8)
            {
                MessageBox.Show("Password must be equal to 8");
            }

            else
            {



                OleDbCommand cmd = myConnString.CreateCommand();
                myConnString.Open();

                //object f1 = null;
                // cmd.CommandText = "INSERT INTO Table1(p1,p2,p3) VALUES('"+luser.Text+"','"+lemail.Text+"', '"+ComboBox.Text+"', '"+lpass.Text+"',)";
                cmd.CommandText = "INSERT INTO registration(lluser,lpassword,lemail,rfirst,rsurname,rcpass,mobile) VALUES('" + ruser.Text + "', '" + rpass.Text + "', '" + remail.Text + "', '" + rfirst.Text + "', '" + rsurname.Text + "', '" + rcpass.Text + "', '" + rmobile.Text + "')";
                cmd.Connection = myConnString;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful");
                }
                catch (Exception e1)
                {
                }
                myConnString.Close();
             
            }
            }

        private void cancel2_Click(object sender, EventArgs e)
        {
            rfirst.Clear();
            rcpass.Clear();
            ruser.Clear();
            rsurname.Clear();
            rpass.Clear();
            rmobile.Clear();
            remail.Clear();
        }

        private void luser_Enter(object sender, EventArgs e)
        {
            if (luser.Text == "Email or Username")
            {
                luser.Text = " ";

                luser.ForeColor = Color.Black;
            }
        }

        private void luser_Leave(object sender, EventArgs e)
        {
            if (luser.Text == " ")
            {
                luser.Text = "Email or Username";
                luser.ForeColor = Color.Silver;
            }
        }

        private void remail_Enter(object sender, EventArgs e)
        {
            if (remail.Text == "someone@example.com")
            {
                remail.Text = "";
                remail.ForeColor = Color.Black;
            }
        }

        private void remail_Leave(object sender, EventArgs e)
        {
            if(remail.Text == "")
            {
                remail.Text = "someone@example.com";
                remail.ForeColor = Color.Gray;
            }
        }

        private void luser_TextChanged(object sender, EventArgs e)
        {

        }

        private void rmobile_Enter(object sender, EventArgs e)
        {
            if(rmobile.Text == "+234")
            {
                rmobile.Text = "";
                rmobile.ForeColor = Color.Gray;
            }
        }

        private void rmobile_Leave(object sender, EventArgs e)
        {
            if(rmobile.Text == "")
            {
                rmobile.Text = "+234";
                rmobile.ForeColor = Color.Gray;
            }
        }
    }

           // private void luser_TextChanged(object sender, EventArgs e)
           // {

           // }
        }