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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Parent = pictureBox1;
            for (int i = 0; i < 2; i++)
            {
                ListViewItem l = new ListViewItem(i.ToString());
                l.SubItems.Add((i + 1).ToString());
                l.SubItems.Add((i + 2).ToString());
                metroListView1.Items.Add(l);
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem l = new ListViewItem(metroListView1.SelectedItems[0].Text);
                l.SubItems.Add(metroListView1.SelectedItems[0].SubItems[1].Text);
                l.SubItems.Add(metroListView1.SelectedItems[0].SubItems[2].Text);
                metroListView2.Items.Add(l);
                metroListView1.Items.Remove(l);
            }
            catch(Exception ex)
            {
                MessageBox.Show("select a row first to add","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
