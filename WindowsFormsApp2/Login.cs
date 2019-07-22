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

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.constring);
            con.Open();
            SqlCommand  com = new SqlCommand(@"select * from utilizatori where username='" + textBox1.Text+"'", con);
            SqlDataReader dt = com.ExecuteReader();
            dt.Read(); 
            if (dt.HasRows==true)
            {
                MessageBox.Show("exista un utilizator cu acelasi nume");
            }
            else
            {
                dt.Close();
                SqlCommand comm = new SqlCommand(@"insert into utilizatori values('"+textBox1.Text+ "','"+textBox2.Text +"')",con );
                comm.ExecuteNonQuery();
                MessageBox.Show("inregistrarea a fost realizata cu succes");
                this.Hide();
                Signin s = new Signin();
                s.Show(); 
            }
            con.Close();

        }
    }
}
