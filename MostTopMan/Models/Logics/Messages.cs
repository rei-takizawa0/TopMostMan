using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopMostMan.Models.Logics
{
    internal static class Messages
    {
        public static void ShowErrorMessage(Exception exception)
        {
            MessageBox.Show(exception.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
