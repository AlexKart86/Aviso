﻿using System;
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

namespace Aviso
{
    public partial class MainForm : Form
    {
        public OleDbDataAdapter lookupAdapter;
        public DataSet lookupDataSet;
        public BindingSource lookupBs;

        private void InitLookupDataSet()
        {
            string constr = ConfigurationManager.ConnectionStrings["Dictionary"].ConnectionString;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            constr =  constr.Replace("|DataDirectory|",path);
            OleDbConnection con = new OleDbConnection(constr);
            string sql = "select * from BNKSEEK.DBF";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            con.Open();
            lookupDataSet = new DataSet();
            lookupAdapter = new OleDbDataAdapter(cmd);
            lookupAdapter.Fill(lookupDataSet);
            con.Close();
            lookupBs = new BindingSource(lookupDataSet, lookupDataSet.Tables[0].TableName);      
        }

        public MainForm()
        {

            InitLookupDataSet();
            InitializeComponent();
            //this.dgvLookup.DataSource = lookupDataSet;
            //this.dgvLookup.DataMember = lookupDataSet.Tables[0].TableName;
            dgvLookup.DataSource = lookupBs;

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avisoDataSet.post_aviso' table. You can move, or remove it, as needed.
            this.post_avisoTableAdapter.Fill(this.avisoDataSet.post_aviso);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvisoPostEdit frm = new AvisoPostEdit(this.postavisoBindingSource, this.lookupBs);
            frm.ShowDialog();
            postavisoBindingSource.EndEdit();
            this.post_avisoTableAdapter.Update(this.avisoDataSet);
            dgvAvisoPost.Refresh();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            postavisoBindingSource.AddNew();
            AvisoPostEdit frm = new AvisoPostEdit(this.postavisoBindingSource, this.lookupBs);
            frm.ShowDialog();           
            postavisoBindingSource.EndEdit();            
            this.post_avisoTableAdapter.Update(this.avisoDataSet);
            dgvAvisoPost.Refresh();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            postavisoBindingSource.EndEdit();
            this.post_avisoTableAdapter.Update(this.avisoDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            postavisoBindingSource.AddNew();
        }        
    }
}
