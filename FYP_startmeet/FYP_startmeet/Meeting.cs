using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace FYP_startmeet
{
    public partial class Meeting : MetroForm
    {
        public Meeting()
        {
            InitializeComponent();
        }

        private void Meeting_Load(object sender, EventArgs e)
        {
            pbStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void pbplay_Click(object sender, EventArgs e)
        {

        }
    }
}
