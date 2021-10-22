using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Form1 : Form
    {
        int yerCekimi = 5; // kuşun hareket etmesi için 
        int hiz = 10; // borular içi 
        int score;
        bool pbPipe1Control, pbPipe3Control;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && tmrGame.Enabled)
            {
                if (pbBirds.Top > 0)
                {
                    pbBirds.Top -= yerCekimi * 10;
                }

            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            pbBirds.Top += yerCekimi;
            pbPipe1.Left -= hiz;
            pbPipe2.Left -= hiz;
            pbPipe3.Left -= hiz;
            pbPipe4.Left -= hiz;

            if (pbPipe1.Right < 0) //ekrandan çıktıysa
            {
                pbPipe1.Left = ClientSize.Width + rnd.Next(200);
                pbPipe1Control = false;
            }
            if (pbPipe2.Right < 0) //ekrandan çıktıysa
            {
                pbPipe2.Left = ClientSize.Width + rnd.Next(200);

            }
            if (pbPipe3.Right < 0) //ekrandan çıktıysa
            {
                pbPipe3.Left = ClientSize.Width + rnd.Next(200);
                pbPipe3Control = false;
            }

            if (pbPipe4.Right < 0) //ekrandan çıktıysa
            {
                pbPipe4.Left = ClientSize.Width + rnd.Next(200);

            }

            if (pbPipe1.Bounds.IntersectsWith(pbBirds.Bounds) || pbPipe2.Bounds.IntersectsWith(pbBirds.Bounds) || pbPipe4.Bounds.IntersectsWith(pbBirds.Bounds) || pbPipe4.Bounds.IntersectsWith(pbBirds.Bounds) || pbGround.Bounds.IntersectsWith(pbBirds.Bounds))
            {
                tmrGame.Stop();
                DialogResult dr = MessageBox.Show("Tekrar oynamak ister misiniz? ", "Flappy Bird", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    pbBirds.Left = 0;
                    pbBirds.Top = 170;
                    pbPipe1.Left += ClientSize.Width;
                    pbPipe2.Left += ClientSize.Width;
                    pbPipe3.Left += ClientSize.Width;
                    pbPipe4.Left += ClientSize.Width;

                    pbPipe1Control = false;
                    pbPipe3Control = false;
                    score = 0;
                    tmrGame.Start();


                }


            }
            if (pbBirds.Right > pbPipe1.Left && !pbPipe1Control)
            {
                score++;
                pbPipe1Control = true;
            }
            if (pbBirds.Right > pbPipe3.Left && !pbPipe3Control)
            {
                score++;
                pbPipe3Control = true;
            }
            lblScore.Text = "Score:" + score;



        }

    }
}
