using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessRat_v1._0
{
    class FilterRat
    {

        public static int isRat(string path, string fileName)
        {

            if (path.ToLower().EndsWith(".exe") && (path.ToLower().Contains("\\temp\\" + fileName.ToLower()) || path.ToLower().Contains("\\appdata\\" + fileName.ToLower()) || path.ToLower().Contains("\\appdata\\roaming\\" + fileName.ToLower() + ".exe") || path.ToLower().Contains("\\programdata\\" + fileName.ToLower()) || path.ToLower().Contains("c:\\users\\" + Environment.UserName.ToLower() + "\\" + fileName.ToLower())))
            {

                return 1;

            }
            else if (path.ToLower().Contains("\\windows\\" + fileName.ToLower()))
            {

                return 2;

            }else{

                return 0;

            }
    }
    }
}