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
namespace WindowsFormsApplication29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=FURKAN-;Initial Catalog=Otomasyon;Integrated Security=True");

        private void getir()
        {
            string komut = "select * from Ogrenciler";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable tablo = new DataTable();
                da.Fill(tablo);
            dataGridView1.DataSource = tablo;


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getir();
        }
    }
}
