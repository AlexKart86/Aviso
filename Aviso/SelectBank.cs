using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviso
{
    public partial class SelectBank : Form
    {
        public SelectBank()
        {
            InitializeComponent();
            dgvMain.DataSource = LookupList.lookupBs;
        }


    }
}
