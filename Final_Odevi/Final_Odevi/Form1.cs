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
namespace Final_Odevi
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-2853N3D\\SQLEXPRESS;Initial Catalog=loginpage;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void topPanel1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select *from login", connect);
            SqlDataReader read = command.ExecuteReader();

            try
            {
                while (read.Read())
                {
                    if (username.Text == read["username"].ToString() && password.Text == read["password"].ToString())
                    {
                        Filmler filmler = new Filmler();
                        filmler.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Parola Hatalı");
                        username.Clear();
                        password.Clear();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
