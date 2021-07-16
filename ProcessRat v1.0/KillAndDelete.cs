using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessRat_v1._0
{
    class KillAndDelete
    {

        public static void Delete(int pid, ListView PrList, Label Da, Label Wa, Label Sa)
        {

            var p = Process.GetProcessById(pid);

            try
            {

                DialogResult areYouSure = MessageBox.Show("Are you sure, you want to kill and Delete: " + p.ProcessName + " ?", "ProcessRat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (areYouSure == DialogResult.Yes)
                {
                    string filePath = GetFullPath.getPath(p);
                    p.Kill();
                    File.SetAttributes(filePath, FileAttributes.Normal);
                    File.Delete(filePath);
                    MessageBox.Show(p.ProcessName + " has been Killed and Deleted!", "ProcessRat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    GetProcesses.getProcesses(PrList, Da, Wa, Sa);

                }
                else
                {

                    return;
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

                MessageBox.Show(p.ProcessName + " can't be killed or deleted, Try to open ProcessRat as an ADMINISTRATOR", "ProcessRat", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
    }
}
