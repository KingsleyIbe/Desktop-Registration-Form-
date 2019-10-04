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
    public partial class Inventory : Form
    {
        OleDbConnection myConnString = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=\"C:\\Users\\DELL\\Documents\\Gricd_project.accdb\"");

        public Inventory()
        {
            InitializeComponent();

            RefreshGridView();


        }
        void RefreshGridView()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

       

        private void ItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gricd_projectinventory.Table1' table. You can move, or remove it, as needed.
         
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void icancel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void dTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void View_Click(object sender, EventArgs e)
        {
           
        }

        private void ViewList_Click(object sender, EventArgs e)
        {
           // if (TabControl1.SelectedTab.Equals(ViewList))
          //  {

                OleDbCommand cmd = myConnString.CreateCommand();

                cmd.Connection = myConnString;
                myConnString.Open();


                try
                {
                    cmd.CommandText = "SELECT * FROM Gricd_project.inventory";
                    OleDbDataAdapter cmdd = new OleDbDataAdapter();
                    MessageBox.Show("Request Successfully");
                    cmd.ExecuteNonQuery();



                    DataSet dtSet = new DataSet();
                    //this.table1TableAdapter.Fill(this.gricd_projectinventory.Table1);
                    //dTable.DataSource = dtSet.Tables["Gricd_Project.inventory"].DefaultView;


                }
                catch (Exception e1)
                {

                }

                myConnString.Close();
            }

        private void SMD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SMD1_Enter(object sender, EventArgs e)
        {
            if(SMD1.Text == "Select one")
            {
                SMD1.Text = " ";
                SMD1.ForeColor = Color.Black;
            }
        }

        private void SMD1_Leave(object sender, EventArgs e)
        {
            if (SMD1.Text == " ")
            {
                SMD1.Text = "Select one";
                SMD1.ForeColor = Color.Gray;

            }
        }

        private void ItemCat1_Enter(object sender, EventArgs e)
        {
            if(ItemCat1.Text == "Select one")
            {
                ItemCat1.Text = " ";
                ItemCat1.ForeColor = Color.Black;
            }
        }

        private void ItemCat1_Leave(object sender, EventArgs e)
        {
            if(ItemCat1.Text == " ")
            {
                ItemCat1.Text = "Select one";
                ItemCat1.ForeColor = Color.Gray;
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            table1BindingSource.MovePrevious();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ItemNam = this.ItemName1.Text;
            string ItemTyp = this.ItemType1.Text;
            string ItemCa = this.ItemCat1.Text;
            string ItemValu = this.ItemValue1.Text;
            string ItemQt = this.ItemQty1.Text;
            string StaffNam = this.StaffName1.Text;
            string SM = this.SMD1.Text;
            string DateTim = this.DateTime1.Text;

            if (ItemNam.Length == 0)
            {
                MessageBox.Show("Item Name cannot be Empty");
            }
            else if (ItemTyp.Length == 0)
            {
                MessageBox.Show("Item Type cannot be Empty");
            }
            else if (ItemCa == "Select one")
            {
                MessageBox.Show("Please Select Category of Item");
            }
            else if (DateTim.Length == 0)
            {
                MessageBox.Show("Date cannot be Empty");
            }
            else if (ItemValu.Length == 0)
            {
                MessageBox.Show("Item Value cannot be Empty");
            }
            else if (ItemQt.Length == 0)
            {
                MessageBox.Show("Item Quantity cannot be Empty");
            }
            else if (SM == "Select one")
            {
                MessageBox.Show("Is Item 'Surface Mounted Device'?");
            }
            else if (StaffNam.Length == 0)
            {
                MessageBox.Show("Please Staff Name");
            }
            else
            {
                OleDbCommand cmd = myConnString.CreateCommand();
                myConnString.Open();

                cmd.CommandText = "INSERT INTO inventory(Item_Name,Item_type,Item_Category,Date_and_Time,Item_Value,Item_Quantity,Component_Type,Staff_Name) VALUES('" + ItemNam + "', '" + ItemTyp + "', '" + ItemCa + "', '" + DateTim + "', '" + ItemValu + "', '" + ItemQt + "', '" + SM + "', '" + StaffNam + "')";
                cmd.Connection = myConnString;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Added Successfully");
                    table1BindingSource.AddNew();


                }
                catch (Exception e1)
                {
                }
                myConnString.Close();

            }
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            ItemName1.Clear();
            ItemType1.Clear();
            ItemCat1.ResetText();
            DateTime1.ResetText();
            ItemValue1.Clear();
            ItemQty1.Clear();
            SMD1.ResetText();
            StaffName1.Clear();

            ItemCat1.Text = "Select one";
            ItemCat1.ForeColor = Color.Gray;

            SMD1.Text = "Select one";
            SMD1.ForeColor = Color.Gray;
        }

        private void icancel1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveNext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                table1BindingSource.EndEdit();
                table1TableAdapter.Update(gricd_projectinventory);
                MessageBox.Show("Update saved");
            }
            catch(Exception e1)
            {

            }

        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            table1BindingSource.RemoveCurrent();
        }

        private void table1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

    }
    

   // }

