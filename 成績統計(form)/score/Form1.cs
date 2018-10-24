using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace score
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int score;

            try
            {
                score = int.Parse(scoreIn.Text);

                scoreListBox.Items.Add(score);
                scoreIn.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            scoreIn.Focus();
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            double average;
            int total = 0;
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int E = 0;
            int F = 0;
            int G = 0;
            int H = 0;
            int I = 0;
            int J = 0;

            for (int i=0;i< scoreListBox.Items.Count;i++)
            {
                total += int.Parse(scoreListBox.Items[i].ToString());
                if (int.Parse(scoreListBox.Items[i].ToString()) >= 90 && int.Parse(scoreListBox.Items[i].ToString()) <= 100)
                {
                    A += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 80 && int.Parse(scoreListBox.Items[i].ToString()) < 90)
                {
                    B += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 70 && int.Parse(scoreListBox.Items[i].ToString()) < 80)
                {
                    C += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 60 && int.Parse(scoreListBox.Items[i].ToString()) < 70)
                {
                    D += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 50 && int.Parse(scoreListBox.Items[i].ToString()) < 60)
                {
                    E += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 40 && int.Parse(scoreListBox.Items[i].ToString()) < 50)
                {
                    F += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 30 && int.Parse(scoreListBox.Items[i].ToString()) < 40)
                {
                    G += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 20 && int.Parse(scoreListBox.Items[i].ToString()) < 30)
                {
                    H += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 10 && int.Parse(scoreListBox.Items[i].ToString()) < 20)
                {
                    I += 1;
                }
                else if (int.Parse(scoreListBox.Items[i].ToString()) >= 0 && int.Parse(scoreListBox.Items[i].ToString()) < 10)
                {
                    J += 1;
                }
                else
                {
                    MessageBox.Show("請輸入0~100的正整數!");
                }
            }
            average = total / scoreListBox.Items.Count;
            MessageBox.Show("平均為: "+average+"\n\n90~100有: "+A+"\n80~89有: "+B+ "\n70~79有: " + C + "\n60~69有: " + D + "\n50~59有: " + E + "\n40~49有: " + F + "\n30~39有: " + G + "\n20~29有: " + H + "\n10~19有: " + I + "\n0~9有: " + J);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            scoreIn.Text = "";
            scoreListBox.Items.Clear();
        }

        private void scoreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
