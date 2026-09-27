using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CoffeShop
{
    public partial class Form1 : Form
        
    {
        private MySqlConnection conn = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "server=localhost;user id=root;password=;database=shop";
           // string query = "INSERT INTO(`Items Name`,`Prices`,`Quantity`,`Total`,`Registerdate`)VALUES(@itemsname,@prices,@quantity,@total,@REgisterdate)";
        }

        private void radiobtncoffee_CheckedChanged(object sender, EventArgs e)
        {
            radiobtncoffee.ForeColor=System.Drawing.Color.BlueViolet;
            radiobtndessert.ForeColor = System.Drawing.Color.RosyBrown;
            Combobox.Items.Clear();
            Combobox.Items.Add("Caramel Macchiato");
            Combobox.Items.Add("Cappuccino");
            Combobox.Items.Add("Mocha");
        }

        private void radiobtndessert_CheckedChanged(object sender, EventArgs e)
        {

            radiobtncoffee.ForeColor = System.Drawing.Color.RosyBrown;
            radiobtndessert.ForeColor = System.Drawing.Color.BlueViolet;
            Combobox.Items.Clear();
            Combobox.Items.Add("Tiramisu");
            Combobox.Items.Add("Cheesecake");
            Combobox.Items.Add("Chocolate Lava Cake");
        }

        private void Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox.SelectedItem.ToString() == "Caramel Macchiato")
            {
                pricetxt.Text = "180";
            }
            else if (Combobox.SelectedItem.ToString() == "Cappuccino")
            {
                pricetxt.Text = "150";
            }
            else if (Combobox.SelectedItem.ToString() == "Mocha")
            {
                pricetxt.Text = "200";
            }
            else if (Combobox.SelectedItem.ToString() == "Tiramisu")
            {
                pricetxt.Text = "250";
            }
            else if (Combobox.SelectedItem.ToString() == "Cheesecake")
            {
                pricetxt.Text = "220";
            }
            else if (Combobox.SelectedItem.ToString() == "Chocolate Lava Cake")
            {
                pricetxt.Text = "270";
            }
            else
            {
                pricetxt.Text = "0";
            }

            quantitytxt.Text = "";
            totaltxt.Text = "";
        }
        ////in switch case        
        //private void Combobox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selected = Combobox.SelectedItem.ToString();

        //    switch (selected)
        //    {
        //        case "Caramel Macchiato":
        //            pricetxt.Text = "180";
        //            break;
        //        case "Cappuccino":
        //            pricetxt.Text = "150";
        //            break;
        //        case "Mocha":
        //            pricetxt.Text = "200";
        //            break;
        //        case "Tiramisu":
        //            pricetxt.Text = "250";
        //            break;
        //        case "Cheesecake":
        //            pricetxt.Text = "220";
        //            break;
        //        case "Chocolate Lava Cake":
        //            pricetxt.Text = "270";
        //            break;
        //        default:
        //            pricetxt.Text = "0";
        //            break;
        //    }
        //    quantitytxt.Text = "";
        //    totaltxt.Text = "";
        //}
        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
            if(quantitytxt.Text.Length >0)
            {
                totaltxt.Text=(Convert.ToInt64(pricetxt.Text)*Convert.ToInt64(quantitytxt.Text)).ToString();   
            }
        }
        private void additemsbtn_Click(object sender, EventArgs e)
        {
            //add data to gridview
            dataGridView1.Rows.Add(Combobox.Text, pricetxt.Text, quantitytxt.Text, totaltxt.Text, dateTimePicker1.Value.ToShortDateString());         
            totalamounttxt.Text = (Convert.ToInt16(totalamounttxt.Text) + Convert.ToInt16(totaltxt.Text)).ToString();   
            pricetxt.Text = "";
            quantitytxt.Text = "";
            totaltxt.Text = "";
        }
        private void deleteitemsbtn_Click(object sender, EventArgs e)
        {
            //deleting from gridview`
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        totalamounttxt.Text = (Convert.ToInt16(totalamounttxt.Text) - Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value)).ToString();
                        dataGridView1.Rows.RemoveAt(i);

                    }
                }
            }
        }
        private void payamounttxt_TextChanged(object sender, EventArgs e)
        {
            if (payamounttxt.Text.Length > 0)
            {
                repayamounttxt.Text=(Convert.ToInt16(totalamounttxt.Text)-Convert.ToInt16(payamounttxt.Text)).ToString();
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0;i < dataGridView1.Rows.Count;i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null || string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                {
                    continue;
                }
                // MySqlCommand cmd = new MySqlCommand("INSERT INTO coffeeshop VALUES(`" + dataGridView1.Rows[i].Cells[0].Value + "," + dataGridView1.Rows[i].Cells[1].Value + "," + dataGridView1.Rows[i].Cells[2].Value + "," + dataGridView1.Rows[i].Cells[3].Value + "," + dataGridView1.Rows[i].Cells[4].Value+"`)",conn);
                string query = "INSERT INTO `coffee` (`ItemsName`, `Prices`, `Quantity`, `Total`, `Registerdate`) VALUES (@item, @price, @qty, @total, @date)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@price", dataGridView1.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@qty", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@total", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@date", dataGridView1.Rows[i].Cells[4].Value);
                cmd.ExecuteNonQuery();        
            }
            MessageBox.Show("Data added successfully");
            conn.Close();
            dataGridView1.Rows.Clear();
            totalamounttxt.Text = "0";
            payamounttxt.Text="";
            repayamounttxt.Text="";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            pricetxt.Text = "0";
            quantitytxt.Text = "";
            totaltxt.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    conn.Open();
        //    if (conn.State == ConnectionState.Open)
        //    {
        //        MessageBox.Show("");
        //        conn.Close();
        //    }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loaddata ld= new Loaddata();
            ld.ShowDialog();
            ld = null;
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalamounttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
