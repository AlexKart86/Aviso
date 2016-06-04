using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviso
{
    abstract public class AvisoReporter
    {
        abstract public bool PrintCurrent(System.Windows.Forms.BindingSource bs, string result_file);
    }
}
