using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonsterLibrary;

namespace myForm
{
    public partial class Form1 : Form
    {
        monster bigMonster;
       
        public Random random = new Random();
        public int myblood;
        
        public Form1()
        {
            InitializeComponent();
            bigMonster = new monster("大怪物",50);
            myblood = 25;
         }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

                
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mouseX.Text = "X : " + e.X;
            mouseY.Text = "Y : " + e.Y;
            textBox1.Text = "沒打中,怪獸反擊!";
            myblood -= 5;
            if(myblood == 0)
                textBox1.Text = "我死了";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int resultx = random.Next(1, 499);
            int resulty = random.Next(1, 499);
            monsterPositionX.Text = "X : " + resultx;
            monsterPositionY.Text = "Y : " + resulty;

            if (checkAlive())
            {
                pictureBox1.Left = resultx;
                pictureBox1.Top = resulty;
            }
            textBox1.Text = " ";
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            startButton.Text = timer1.Enabled ? "結束" : "開始";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "打中";
            bigMonster.blood -= 5;
            if (!checkAlive())
            {
                textBox1.Text = bigMonster.name + "死了!";
                //Close();
            }
       }

        public  bool checkAlive()
        {
            if (bigMonster.blood == 0)
                return false;
            else
                return true;
        }
    }
}
