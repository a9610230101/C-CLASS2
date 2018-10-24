using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //專案名稱 : 時區對應程式
    //姓名 : 
    //日期 : 2018.10.24


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void city_SelectedIndexChanged(object sender, EventArgs e)
        {
            




        }

        private void display_Click(object sender, EventArgs e)
        {
            if (city.SelectedIndex != -1)
            {
                string x;
                x = city.SelectedItem.ToString();
                if (x == "檀香山(夏威夷州)")
                {
                    output.Text = " 夏威夷時區 UTC(-10:00) ";
                }
                else if (x == "丹佛(科羅拉多州)")
                {
                    output.Text = " 山地時區 UTC(-07:00) ";
                }
                else if (x == "明尼亞波利斯(明尼蘇達州)")
                {
                    output.Text = " 中央時區 UTC(-06:00) ";
                }
                else if (x == "紐約(紐約州)")
                {
                    output.Text = " 東部時區 UTC(-05:00) ";
                }
                else if (x == "舊金山(加利福尼亞州)")
                {
                    output.Text = " 太平洋標準時區 UTC(-08:00) ";
                }
            }
            else
            {
                MessageBox.Show("請先選擇一個城市");
            }

            }
        }
    }

