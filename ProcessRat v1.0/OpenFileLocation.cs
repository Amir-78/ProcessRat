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
    class OpenFileLocation
    {

        public static void OpenFile(string path)
        {

            if (!File.Exists(path))
            {

                MessageBox.Show("Access Denied!", "ProcessRat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string select = "/select, \"" + path + "\"";


                Process.Start("explorer.exe", select);

        }

    }
}
