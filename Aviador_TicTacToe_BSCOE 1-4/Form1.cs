using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviador_TicTacToe_BSCOE_1_4
{
    public partial class Form1 : Form
    {
        bool turn = true; // if true = X turn; if false = Y turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            
            CheckForWinner();

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aviador, Daniel D. BSCPE 1-4", "T-T-T");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CheckForWinner()
        {
            bool Sino_ang_Nanalo = false;

            //horizontal checks
            if ((D1.Text == D2.Text) && (D2.Text == D3.Text) && (!D1.Enabled))
                Sino_ang_Nanalo = true;
            else if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                Sino_ang_Nanalo = true;
            else if ((N1.Text == N2.Text) && (N2.Text == N3.Text) && (!N1.Enabled))
                Sino_ang_Nanalo = true;

            //vertical checks
            else if ((D1.Text == A1.Text) && (A1.Text == N1.Text) && (!D1.Enabled))
                Sino_ang_Nanalo = true;
            else if ((D2.Text == A2.Text) && (A2.Text == N2.Text) && (!D2.Enabled))
                Sino_ang_Nanalo = true;
            else if ((D3.Text == A3.Text) && (A3.Text == N3.Text) && (!D3.Enabled))
                Sino_ang_Nanalo = true;

            //diagonal checks
            else if ((D1.Text == A2.Text) && (A2.Text == N3.Text) && (!D1.Enabled))
                Sino_ang_Nanalo = true;
            else if ((D3.Text == A2.Text) && (A2.Text == N1.Text) && (!N1.Enabled))
                Sino_ang_Nanalo = true;

            if (Sino_ang_Nanalo)
            {
                disableButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " Panalo lakas mo! ");
            }//end if
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw kayo kapatid", "T-T-T");
            }
        }//end Sino_ang_Nanalo

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//endforeach
            }//end try
            catch { }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//endforeach
            }//end try
            catch { }
        }
    }
}