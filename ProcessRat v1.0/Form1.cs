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

    public partial class Form1 : Form
    {

        private ListViewColumnSorter lvwColumnSorter;

        public Form1()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.PrList.ListViewItemSorter = lvwColumnSorter;

        }


        private void PrList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.PrList.Sort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

 

            PrList.View = View.Details;
            PrList.GridLines = true;
            PrList.FullRowSelect = true;

            GetProcesses.getProcesses(PrList, Da, Wa, Sa);

           
        }

        private void PrList_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = PrList.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void tesetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int pID = Convert.ToInt32(PrList.SelectedItems[0].SubItems[0].Text);

            KillProcess.Kill(pID, PrList, Da, Wa, Sa);

        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string path = PrList.SelectedItems[0].SubItems[2].Text;

            OpenFileLocation.OpenFile(path);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form2 = new Connections();
            int pID = Convert.ToInt32(PrList.SelectedItems[0].SubItems[0].Text);
            form2.Enabled = true;
            form2.listView1.FullRowSelect = true;
            form2.Show();
            form2.Text = "Connections - " + PrList.SelectedItems[0].SubItems[1].Text;
            ShowConnections.Show(form2.listView1, pID);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {

                timer1.Stop();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            GetProcesses.getProcesses(PrList, Da, Wa, Sa);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            GetProcesses.getProcesses(PrList, Da, Wa, Sa);

        }

        private void killDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        int pID = Convert.ToInt32(PrList.SelectedItems[0].SubItems[0].Text);


                        KillAndDelete.Delete(pID, PrList, Da, Wa, Sa);


        }


   
    }
}
