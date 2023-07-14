
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaverApp
{

    public partial class ScreenSaverWindow : Form
    {

        public ScreenSaverWindow()
        {
            InitializeComponent();

            this.KeyDown += ScreenSaverWindow_KeyDown;
            this.MouseDown += ScreenSaverWindow_MouseDown;
        }

        private void DoClose()
        {
            Close();
        }

        private void ScreenSaverWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoClose();
            }
        }

        private void ScreenSaverWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    DoClose();
                    break;
                default:
                    // ...
                    break;
            }
        }

    }

}
