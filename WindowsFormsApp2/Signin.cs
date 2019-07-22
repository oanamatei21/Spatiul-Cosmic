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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
                    
            
        }

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
             
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "OanaM" && textBox2.Text == "OanaM2000")
            {
                this.Hide();
                Utilizatori u = new Utilizatori();
                u.Show();
            }
            else MessageBox.Show("Nu puteți vedea restul utilizatorilor decât dacă sunteți administrator");
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Campurile nume si parola trebuie completate");
            else
                if (textBox1.Text == "OanaM" && textBox2.Text == "Oanam2000")
            {
                this.Hide();
                Utilizatori u = new Utilizatori();
                u.Show();
            }
            else
            {
                SqlConnection con = new SqlConnection(Class1.constring);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter(@"select * from utilizatori where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Class1.nume = textBox1.Text;  
                    this.Hide();
                    Cuprins c = new Cuprins();
                    c.Show();
                }
                else MessageBox.Show("parola sau numele de utilizator sunt incorecte");
            }
        }
    }
}
