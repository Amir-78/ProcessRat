using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessRat_v1._0
{
    class KillProcess
    {

        public static void Kill(int pid, ListView PrList, Label Da, Label Wa, Label Sa)
        {

            var p = Process.GetProcessById(pid);

            try {

                DialogResult areYouSure = MessageBox.Show("Are you sure, you want to kill: " + p.ProcessName + " ?", "ProcessRat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (areYouSure == DialogResult.Yes)
                {
                    p.Kill();
                    MessageBox.Show(p.ProcessName + " has been Killed!", "ProcessRat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    GetProcesses.getProcesses(PrList, Da, Wa, Sa);

                }
                else
                {

                    return;
                }
            }
            catch (Exception error)
            {


                    MessageBox.Show(p.ProcessName + " can't be killed, Try to open ProcessRat as an ADMINISTRATOR", "ProcessRat", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

    }
}
