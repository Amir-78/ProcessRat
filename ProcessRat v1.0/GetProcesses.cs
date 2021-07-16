using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessRat_v1._0
{
    class GetProcesses
    {




        public static void getProcesses(ListView PrList, Label Da, Label Wa, Label Sa)
        {

            PrList.Items.Clear();

            int Danger = 0;
            int Warning = 0;
            int Safe = 0;

            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {


                string[] processesList = { p.Id.ToString(), p.ProcessName, GetFullPath.getPath(p) };
                var ListedProcess = new ListViewItem(processesList);
                PrList.Items.Add(ListedProcess);
                int isRat = FilterRat.isRat(GetFullPath.getPath(p), p.ProcessName);
                if (isRat == 1)
                {

                    ListedProcess.ForeColor = Color.Red;
                    Danger += 1;

                }
                else if (isRat == 2)
                {

                    ListedProcess.ForeColor = Color.Orange;
                    Warning += 1;

                }
                else if (isRat == 0)
                {

                    ListedProcess.ForeColor = Color.LimeGreen;
                    Safe += 1;

                }

            }

            Da.Text = "Dangerous: " + Danger;
            Wa.Text = "Warnings: " + Warning;
            Sa.Text = "Safe: " + Safe;

        }
    }
}
