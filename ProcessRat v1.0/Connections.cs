using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessRat_v1._0
{
    public partial class Connections : Form
    {
        public Connections()
        {
            InitializeComponent();
        }

        private void Connections_Load(object sender, EventArgs e)
        {



        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }


        private void openIPLookUPToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            string ip = listView1.SelectedItems[0].SubItems[0].Text;
            Process.Start("https://ipgeolocation.io/ip-location/" + ip);

        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            string rIP = listView1.SelectedItems[0].SubItems[0].Text;
            string rPort = listView1.SelectedItems[0].SubItems[1].Text;
            string lIP = listView1.SelectedItems[0].SubItems[2].Text;
            string lPort = listView1.SelectedItems[0].SubItems[3].Text;

            Clipboard.SetText("Remote IP: " + rIP + " - Remote Port: " + rPort + " - Local IP: " + lIP + " - Local Port: " + lPort);
            MessageBox.Show("Done!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

    }
}
