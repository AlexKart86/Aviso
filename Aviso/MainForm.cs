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
using System.Data.Common;

namespace Aviso
{
    public partial class MainForm : Form
    {
              

        //Вычислить следующий номер авизо
        public string CalcPostAvisoNextNum(DataTable tbl)
        {            
            int max = 0;
            foreach (DataRow row in tbl.Rows)
            {
                if (max < Convert.ToInt32(row["NUM"]))
                    max = Convert.ToInt32(row["NUM"]);
            }
            max++;
            return max.ToString("000");
        }

        //Редактирование почтового авизо
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

        //Редактирование телеграфного авизо
        private void EditTeleAviso()
        {
            AvisoTeleEdit frm = new AvisoTeleEdit(this.telegraphavisoBindingSource);
            if (frm.ShowDialog() == DialogResult.OK)
                telegraphavisoBindingSource.EndEdit();
            else
                telegraphavisoBindingSource.CancelEdit();            
            this.telegraph_avisoTableAdapter.Update(this.avisoDataSet);
            dgvAvisoTele.Refresh();
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
            // TODO: This line of code loads data into the 'avisoDataSet.telegraph_aviso' table. You can move, or remove it, as needed.
            this.telegraph_avisoTableAdapter.Fill(this.avisoDataSet.telegraph_aviso);
            // TODO: This line of code loads data into the 'avisoDataSet.post_aviso' table. You can move, or remove it, as needed.
            this.post_avisoTableAdapter.Fill(this.avisoDataSet.post_aviso);            
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




        private void mAdd_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == tpPostAviso)
            {
                DataRowView row = (DataRowView)postavisoBindingSource.AddNew();
                row["NUM"] = CalcPostAvisoNextNum(avisoDataSet.Tables["post_aviso"]);
                row["CREATE_DATE"] = DateTime.Today;
                row["KPD_DATE"] = DateTime.Today;
                EditPostAviso();
            }
            else if (tcMain.SelectedTab == tpTeleAviso)
            {
                DataRowView row = (DataRowView)telegraphavisoBindingSource.AddNew();
                row["NUM"] = CalcPostAvisoNextNum(avisoDataSet.Tables["telegraph_aviso"]);
                row["CREATE_DATE"] = DateTime.Today;
                row["KPD_DATE"] = DateTime.Today;
                EditTeleAviso();
            }
        }

        private void mEdit_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == tpPostAviso)
            {                
                EditPostAviso();
            }
            else if (tcMain.SelectedTab == tpTeleAviso)
            {                
                EditTeleAviso();
            }
            
        }

        private void mDel_Click(object sender, EventArgs e)
        {

            BindingSource bs;            

            if (tcMain.SelectedTab == tpPostAviso)            
                bs = postavisoBindingSource;                
            else if (tcMain.SelectedTab == tpTeleAviso)            
                bs = telegraphavisoBindingSource;            
            else
                return;

            if (bs.Count > 0)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить выделенное авизо?",
                    "Подтверждение удаления авизо",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bs.RemoveCurrent();
                    bs.EndEdit();
                    if (tcMain.SelectedTab == tpPostAviso)
                        post_avisoTableAdapter.Update(avisoDataSet);
                    else if (tcMain.SelectedTab == tpTeleAviso)
                        telegraph_avisoTableAdapter.Update(avisoDataSet);                    
                }
            }

        }

        private void mPrint_Click(object sender, EventArgs e)
        {
            
            AvisoReporter rep;
            BindingSource bs;
            if (dlgSelectReport.ShowDialog()== DialogResult.OK && dlgSelectReport.FileName != "")
            {
                if (tcMain.SelectedTab == tpPostAviso)
                {
                    rep = new AvisoPostReporter();
                    bs = postavisoBindingSource;
                }
                else if (tcMain.SelectedTab == tpTeleAviso)
                {
                    rep = new AvisoTelegraphReporter();
                    bs = telegraphavisoBindingSource;
                }
                else
                    return;

                if (rep.PrintCurrent(bs, dlgSelectReport.FileName))
                    MessageBox.Show("Отчет успешно сформирован", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Не удалось сформировать отчет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
