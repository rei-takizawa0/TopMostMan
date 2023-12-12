using TopMostMan.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopMostMan.Models.Interface
{
    public interface IMainForm
    {
        IEnumerable<BootingApplication> Applications { set; }
        bool ApplicationExists { get; }
        BootingApplication CurrentApplication { get; }

        event EventHandler LoadButtonClick;
        event EventHandler ReleaseButtonClick;
        event EventHandler TopMostButtonClick;
    }
}
