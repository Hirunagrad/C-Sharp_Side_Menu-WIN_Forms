using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideBar_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool MouseDown;
        private Point offSet;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!mainpanel.Controls.Contains(Home.Instance))
            {
                mainpanel.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
                Home.Instance.BringToFront();
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            offSet.X = e.X;
            offSet.Y = e.Y;
            MouseDown = true;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offSet.X, currentScreenPos.Y - offSet.Y);
            }
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        //Home Click
        private void home_Click(object sender, EventArgs e)
        {
            
        }

        //Food Click
        private void food_Click(object sender, EventArgs e)
        {
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
            MouseDown = false;
        }
    }
}
