using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            btStartGame.Focus();
        }

        private void btStartGame_Click(object sender, EventArgs e)
        {
            pbNava.Visible = true;
            lbTimp.Top = 2;
            label1.Top = 2;
            btStartGame.Visible = false;
            txtTasta.Focus();
            lbTimp.Text = "0";
            this.BackgroundImage = null;
            this.BackColor = Color.Black;
            pbNava.Visible = true;
            timer_meteor_nou.Start();
            timer_cadere_meteor.Start();
            timer_supravietuire.Start();
            
        }

        private void txtTasta_TextChanged(object sender, EventArgs e)
        {
            string taste = txtTasta.Text;
            char tasta = taste[taste.Length - 1];
            if (tasta == 'a')  if (pbNava.Left >= 25)pbNava.Left = pbNava.Left - 25; 
            if (tasta == 'd')  if (pbNava.Left <= this.Width - pbNava.Width-25) pbNava.Left = pbNava.Left + 25;
            if (tasta == 'w') if (pbNava.Top > 20) pbNava.Top = pbNava.Top - 20;
            if (tasta == 's') if (pbNava.Top < this.Height - pbNava.Height- 20) pbNava.Top = pbNava.Top + 20;
        }

        private void timer_meteor_nou_Tick(object sender, EventArgs e)
        {
            Random nr_rnd = new Random((int)DateTime.Now.Ticks);
            int nr_met = nr_rnd.Next(1, 5);
            for (int i = 1; i <= nr_met; i++)
            {
                Random rnd_size = new Random((int)DateTime.Now.Ticks);
                int size = rnd_size.Next(30, 110);
                Random rnd_locatie = new Random((int)DateTime.Now.Ticks);
                int locatie = rnd_locatie.Next(1, this.Width - size + 1);
                PictureBox pb_meteor_nou = new PictureBox();
                pb_meteor_nou.Location = new Point(locatie, 0);
                pb_meteor_nou.Height = size;
                pb_meteor_nou.Width = size;
                //rotunjire
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, pb_meteor_nou.Width - 3, pb_meteor_nou.Height -3);
                Region rg = new Region(gp);
                pb_meteor_nou.Region = rg;
                //
                pb_meteor_nou.BringToFront();
                pb_meteor_nou.BackgroundImage = Invaders.Properties.Resources.meteor_transparent;
                pb_meteor_nou.BackgroundImageLayout = ImageLayout.Stretch;
                Random speed_rnd = new Random((int)DateTime.Now.Ticks);
                int viteza = speed_rnd.Next(7, 9);
                pb_meteor_nou.Name = viteza.ToString();

                this.Controls.Add(pb_meteor_nou);
            }
            if (lbTimp.Text == "30")
            {
                timer_final.Start();
                timer_meteor_nou.Stop();
                timer_cadere_meteor.Stop();
                timer_supravietuire.Stop();
                foreach (var pb in this.Controls.OfType<PictureBox>())
                {
                    if (pb.Name != "pbNava")
                    {
                        pb.BackgroundImage = null;
                        pb.BackColor = Color.Black;
                        pb.Visible = false;
                        pbNava.Focus();
                    }
                }
            }
        }

        private void timer_cadere_meteor_Tick(object sender, EventArgs e)
        {
            foreach (var pb in this.Controls.OfType<PictureBox>())
            {
                if (pb.Name != "pbNava" && pb.Name != "pbMeteor")
                {
                    pb.Top = pb.Top + int.Parse(pb.Name);
                    if (pb.Top > this.Height) pb.Dispose();

                    if (pb.Top > this.Height - pbNava.Height - pb.Height)
                        if ((pb.Left > pbNava.Left && pb.Left < pbNava.Left + pbNava.Width)  || (pbNava.Left>pb.Left && pbNava.Left<pb.Left +pb.Width))     //daca sunt mai mari decat nava si trec prin mijloc                
                        {
                            timer_final.Start();
                            pbNava.Focus();
                            timer_cadere_meteor.Stop();
                            timer_meteor_nou.Stop();
                            timer_supravietuire.Stop();
                        }
                }
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Main f2 = new Main();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void timer_supravietuire_Tick(object sender, EventArgs e)
        {
            int nr_sec = int.Parse(lbTimp.Text);
            nr_sec++;
            lbTimp.Text = nr_sec.ToString();
        }

        private void timer_final_Tick(object sender, EventArgs e)
        {
            if (lbTimp.Text == "30")
            {
                pbNava.Top = pbNava.Top - 8;
                if (pbNava.Top < 0 - pbNava.Height)
                {
                    timer_final.Stop();
                    MessageBox.Show("Congratulations, you got out of the storm!");
                    Game f2 = new Game();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                pbNava.Top = pbNava.Top + 8;
                if (pbNava.Top > this.Height)
                {
                    timer_final.Stop();
                    MessageBox.Show("Too bad, you died!");
                    Game f2 = new Game();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
//de facut pe dificultati