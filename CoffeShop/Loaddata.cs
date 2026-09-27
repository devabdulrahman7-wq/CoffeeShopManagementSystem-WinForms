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
    public partial class Loaddata : Form
    {
        private MySqlConnection conn = new MySqlConnection();
        public Loaddata()
        {
            InitializeComponent();
            conn.ConnectionString = "server=localhost;user id=root;password=;database=shop";
        }

        private void Loaddata_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `coffeeshop`";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=shop"))
            {
                conn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }
    }
}

