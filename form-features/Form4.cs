using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_features
{
    public partial class passwordReset : Form
    {
        public passwordReset()
        {
            InitializeComponent();
        }

        private void passwordReset_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
