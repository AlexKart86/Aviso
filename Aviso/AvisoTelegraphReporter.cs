using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviso
{
    class AvisoTelegraphReporter : AvisoReporter
    {
        public override bool PrintCurrent(BindingSource bs, string result_file)
        {
            return false;
        }
    }
}
