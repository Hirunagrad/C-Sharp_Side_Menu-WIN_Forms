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
    public partial class Home : UserControl
    {
        private static Home home;

        public static Home Instance
        {
            get
            {
                if (home == null)
                {
                    home = new Home();
                }

                return home;
            }
        }

        public Home()
        {
            InitializeComponent();
        }
    }
}
