using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using Novacode;
using System.IO;

namespace Aviso
{
    public partial class MainForm : Form
    {
              

        //Вычислить следующий номер авизо
        public int CalcPostAvisoNextNum(DataTable tbl)
        {            
            int max = 0;
            foreach (DataRow row in tbl.Rows)
            {
                if (max < Convert.ToInt32(row["NUM"]))
                    max = Convert.ToInt32(row["NUM"]);
            }
            return max + 1;
        }

        private void EditPostAviso()
        {
            AvisoPostEdit frm = new AvisoPostEdit(this.postavisoBindingSource);
            if (frm.ShowDialog() == DialogResult.OK)
                postavisoBindingSource.EndEdit();
            else
                postavisoBindingSource.CancelEdit();  
            this.post_avisoTableAdapter.Update(this.avisoDataSet);
                        
            dgvAvisoPost.Refresh();
        }

        public MainForm()
        {            
            InitializeComponent();
            //this.dgvLookup.DataSource = lookupDataSet;
            //this.dgvLookup.DataMember = lookupDataSet.Tables[0].TableName;
            //dgvLookup.DataSource = LookupList.lookupBs;
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisoDataSet.post_aviso' table. You can move, or remove it, as needed.
            this.post_avisoTableAdapter.Fill(this.avisoDataSet.post_aviso);            
        }

        private void btnEditAviso_Click(object sender, EventArgs e)
        {
            EditPostAviso();            
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //postavisoBindingSource.AddNew(); 
            //DocX doc = DocX.Load(@"D:\1.docx");
            CombineDocs r = new CombineDocs();
            List<byte[]> lst = new List<byte[]>();
            lst.Add(File.ReadAllBytes(@"k:\visual studio 2015\Projects\Aviso\Aviso\bin\Debug\test2.docx"));
            lst.Add(File.ReadAllBytes(@"k:\visual studio 2015\Projects\Aviso\Aviso\bin\Debug\test3.docx"));
            //lst.Add(File.ReadAllBytes(@"k:\Test\3.docx"));
            byte[] str =  r.OpenAndCombine(lst);
            File.WriteAllBytes(@"k:\visual studio 2015\Projects\Aviso\Aviso\bin\Debug\test4.docx", str);
            lst.Clear();
        }

        private void btnAddAviso_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)postavisoBindingSource.AddNew();
            row["NUM"] = CalcPostAvisoNextNum(avisoDataSet.Tables["post_aviso"]);
            row["CREATE_DATE"] = DateTime.Today;
            row["KPD_DATE"] = DateTime.Today;
            EditPostAviso();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* postavisoBindingSource.EndEdit();
            post_avisoTableAdapter.Update(avisoDataSet);*/
            
        }

        private void btnDeleteAviso_Click(object sender, EventArgs e)
        {
            postavisoBindingSource.RemoveCurrent();
            postavisoBindingSource.EndEdit();
            post_avisoTableAdapter.Update(avisoDataSet);            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dlgSelectReport.ShowDialog();
            if (dlgSelectReport.FileName != "")
               AvisoPostReporter.PrintCurrent(postavisoBindingSource, dlgSelectReport.FileName);
        }
    }
}
