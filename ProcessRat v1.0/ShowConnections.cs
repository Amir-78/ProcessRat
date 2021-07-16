using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessRat_v1._0
{
    class ShowConnections
    {
        public static void Show(ListView connectionsList, int pID)
        {
                   var connection = GetConnections.GetAllTcpConnections();


           for (int i = 0; i < connection.Length; i++) 
{

    if (connection[i].owningPid == pID)
    {

        string[] processesList = { IPcalculation.getIP(connection[i].remoteAddr), connection[i].RemotePort.ToString(), IPcalculation.getIP(connection[i].LocalPort), connection[i].LocalPort.ToString() };

        var ListedProcess = new ListViewItem(processesList);
        connectionsList.Items.Add(ListedProcess);
    }


}
        }
    }
}
