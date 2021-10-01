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
    public partial class Cookie : UserControl
    {

        private static Cookie cookie;

        public static Cookie Instance
        {
            get
            {
                if (cookie == null)
                {
                    cookie = new Cookie();
                }

                return cookie;
            }
        }
        public Cookie()
        {
            InitializeComponent();
        }
    }
}
