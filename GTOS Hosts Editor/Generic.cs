using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTOS_Hosts_Editor
{
    public static class Generic
    {
        public static void showError(string text)
        {
            MessageBox.Show(text, "GTOS Hosts Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showInfo(string text)
        {
            MessageBox.Show(text, "GTOS Hosts Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
