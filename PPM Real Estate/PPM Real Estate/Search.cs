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

namespace PPM_Real_Estate
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\chris\Source\Repos\Project-Management\PPM Real Estate\PPM Real Estate\.mdf;Integrated Security = True");
        SqlDataAdapter adpt;



        private void Search_Load(object sender, EventArgs e)
        {
            Showinfo();
        }

        private void Showinfo()
        {
            adpt = new SqlDataAdapter("SELECT * FROM Property", Con);
            DataTable dt = new DataTable("Property");
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void searchpTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\chris\Source\Repos\Project-Management\PPM Real Estate\PPM Real Estate\.mdf;Integrated Security = True");
           
            if (searchpTb.Text != "")
            {

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adpt;
                adpt = new SqlDataAdapter();
                DataTable dt = new DataTable();
                DataView dv = new DataView();

                string command1 = "Select * From Property Where postcode like '%" + searchpTb.Text + "%';";

                Con.Open();
                adpt = new SqlDataAdapter(command1, Con);
                adpt.Fill(dt);
                dv = new DataView(dt);
                dataGridView1.DataSource = dt;
                Con.Close();


                string command2 = "Select * From Property Where name like '%" + searchpTb.Text + "%';";

                Con.Open();
                adpt = new SqlDataAdapter(command2, Con);
                adpt.Fill(dt);
                dv = new DataView(dt);
                dataGridView1.DataSource = dt;
                Con.Close();

                string command3 = "Select * From Property Where location like '%" + searchpTb.Text + "%';";

                Con.Open();
                adpt = new SqlDataAdapter(command3, Con);
                adpt.Fill(dt);
                dv = new DataView(dt);
                dataGridView1.DataSource = dt;
                Con.Close();

                string command = "Select * From Property Where buildingType like '%" + searchpTb.Text + "%';";

                Con.Open();
                adpt = new SqlDataAdapter(command, Con);
                adpt.Fill(dt);
                dv = new DataView(dt);
                dataGridView1.DataSource = dt;
                Con.Close();

                string command4 = "Select * From Property Where propertyType like '%" + searchpTb.Text + "%';";

                Con.Open();
                adpt = new SqlDataAdapter(command4, Con);
                adpt.Fill(dt);
                dv = new DataView(dt);
                dataGridView1.DataSource = dt;
                Con.Close();

            }
            else if (searchpTb.Text == "")
            {
                dataGridView1.Refresh();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
    }

