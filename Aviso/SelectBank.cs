using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Форма для выбора банка по кнопкам "Найти"
namespace Aviso
{
    public partial class SelectBank : Form
    {
        public SelectBank()
        {
            InitializeComponent();
            dgvMain.DataSource = LookupList.lookupBs;
            dgvMain.Columns["NEWNUM"].DefaultCellStyle.BackColor = Color.Yellow;            
            dgvMain.Columns["KSNP"].DefaultCellStyle.BackColor = Color.Yellow;
            
        }

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            btnOK.PerformClick();
        }
    }
}
