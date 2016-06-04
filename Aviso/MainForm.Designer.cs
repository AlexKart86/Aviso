using System.Windows.Forms;

namespace Aviso
{
    partial class MainForm
    {

       

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAvisoPost = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYMENT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATION_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RD_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RD_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RD_SUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENDER_BIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENDER_KO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENDER_BILL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIVER_BIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIVER_KO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIVER_BILL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPD_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTTYPEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATIONTYPEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDNUMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDSUMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERBIKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERKODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERBILLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERBIKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERKODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERBILLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPDDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavisoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avisoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avisoDataSet = new Aviso.AvisoDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpPostAviso = new System.Windows.Forms.TabPage();
            this.tpTeleAviso = new System.Windows.Forms.TabPage();
            this.dgvAvisoTele = new System.Windows.Forms.DataGridView();
            this.telegraphavisoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dlgSelectReport = new System.Windows.Forms.SaveFileDialog();
            this.post_avisoTableAdapter = new Aviso.AvisoDataSetTableAdapters.post_avisoTableAdapter();
            this.telegraph_avisoTableAdapter = new Aviso.AvisoDataSetTableAdapters.telegraph_avisoTableAdapter();
            this.mmAdd = new System.Windows.Forms.MenuStrip();
            this.mAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATIONTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDSUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERINNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERKPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERBIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERKONAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERBILLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERINNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERKPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERBIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERBILLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTGOALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n101DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n104DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n105DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n106DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n107DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n108DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n109DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n110DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisoPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavisoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisoDataSet)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpPostAviso.SuspendLayout();
            this.tpTeleAviso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisoTele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telegraphavisoBindingSource)).BeginInit();
            this.mmAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAvisoPost
            // 
            this.dgvAvisoPost.AllowUserToAddRows = false;
            this.dgvAvisoPost.AllowUserToDeleteRows = false;
            this.dgvAvisoPost.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAvisoPost.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvisoPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvisoPost.AutoGenerateColumns = false;
            this.dgvAvisoPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvisoPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NUM,
            this.CREATE_DATE,
            this.PAYMENT_TYPE,
            this.OPERATION_TYPE,
            this.RD_NUM,
            this.RD_DATE,
            this.RD_SUM,
            this.SENDER_BIK,
            this.SENDER_KO,
            this.SENDER_BILL,
            this.RECEIVER_BIK,
            this.RECEIVER_KO,
            this.RECEIVER_BILL,
            this.KPD,
            this.KPD_DATE,
            this.iDDataGridViewTextBoxColumn1,
            this.nUMDataGridViewTextBoxColumn1,
            this.cREATEDATEDataGridViewTextBoxColumn1,
            this.pAYMENTTYPEDataGridViewTextBoxColumn1,
            this.oPERATIONTYPEDataGridViewTextBoxColumn1,
            this.rDNUMDataGridViewTextBoxColumn1,
            this.rDDATEDataGridViewTextBoxColumn1,
            this.rDSUMDataGridViewTextBoxColumn1,
            this.sENDERBIKDataGridViewTextBoxColumn1,
            this.sENDERKODataGridViewTextBoxColumn1,
            this.sENDERBILLDataGridViewTextBoxColumn1,
            this.rECEIVERBIKDataGridViewTextBoxColumn1,
            this.rECEIVERKODataGridViewTextBoxColumn1,
            this.rECEIVERBILLDataGridViewTextBoxColumn1,
            this.kPDDataGridViewTextBoxColumn1,
            this.kPDDATEDataGridViewTextBoxColumn1});
            this.dgvAvisoPost.DataSource = this.postavisoBindingSource;
            this.dgvAvisoPost.Location = new System.Drawing.Point(7, 4);
            this.dgvAvisoPost.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAvisoPost.MultiSelect = false;
            this.dgvAvisoPost.Name = "dgvAvisoPost";
            this.dgvAvisoPost.ReadOnly = true;
            this.dgvAvisoPost.RowHeadersVisible = false;
            this.dgvAvisoPost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvisoPost.Size = new System.Drawing.Size(1147, 488);
            this.dgvAvisoPost.TabIndex = 0;
            this.dgvAvisoPost.DoubleClick += new System.EventHandler(this.mEdit_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NUM
            // 
            this.NUM.DataPropertyName = "NUM";
            this.NUM.HeaderText = "Номер авизо";
            this.NUM.Name = "NUM";
            this.NUM.ReadOnly = true;
            // 
            // CREATE_DATE
            // 
            this.CREATE_DATE.DataPropertyName = "CREATE_DATE";
            this.CREATE_DATE.HeaderText = "Дата авизо";
            this.CREATE_DATE.Name = "CREATE_DATE";
            this.CREATE_DATE.ReadOnly = true;
            // 
            // PAYMENT_TYPE
            // 
            this.PAYMENT_TYPE.DataPropertyName = "PAYMENT_TYPE";
            this.PAYMENT_TYPE.HeaderText = "Вид платежа";
            this.PAYMENT_TYPE.Name = "PAYMENT_TYPE";
            this.PAYMENT_TYPE.ReadOnly = true;
            // 
            // OPERATION_TYPE
            // 
            this.OPERATION_TYPE.DataPropertyName = "OPERATION_TYPE";
            this.OPERATION_TYPE.HeaderText = "Вид операции";
            this.OPERATION_TYPE.Name = "OPERATION_TYPE";
            this.OPERATION_TYPE.ReadOnly = true;
            // 
            // RD_NUM
            // 
            this.RD_NUM.DataPropertyName = "RD_NUM";
            this.RD_NUM.HeaderText = "Номер РД";
            this.RD_NUM.Name = "RD_NUM";
            this.RD_NUM.ReadOnly = true;
            // 
            // RD_DATE
            // 
            this.RD_DATE.DataPropertyName = "RD_DATE";
            this.RD_DATE.HeaderText = "Дата РД";
            this.RD_DATE.Name = "RD_DATE";
            this.RD_DATE.ReadOnly = true;
            // 
            // RD_SUM
            // 
            this.RD_SUM.DataPropertyName = "RD_SUM";
            this.RD_SUM.HeaderText = "Сумма РД";
            this.RD_SUM.Name = "RD_SUM";
            this.RD_SUM.ReadOnly = true;
            // 
            // SENDER_BIK
            // 
            this.SENDER_BIK.DataPropertyName = "SENDER_BIK";
            this.SENDER_BIK.HeaderText = "БИК банка плательщика";
            this.SENDER_BIK.Name = "SENDER_BIK";
            this.SENDER_BIK.ReadOnly = true;
            // 
            // SENDER_KO
            // 
            this.SENDER_KO.DataPropertyName = "SENDER_KO";
            this.SENDER_KO.HeaderText = "Корсчет КО плательщика";
            this.SENDER_KO.Name = "SENDER_KO";
            this.SENDER_KO.ReadOnly = true;
            // 
            // SENDER_BILL
            // 
            this.SENDER_BILL.DataPropertyName = "SENDER_BILL";
            this.SENDER_BILL.HeaderText = "Номер л/счета плательщика";
            this.SENDER_BILL.Name = "SENDER_BILL";
            this.SENDER_BILL.ReadOnly = true;
            // 
            // RECEIVER_BIK
            // 
            this.RECEIVER_BIK.DataPropertyName = "RECEIVER_BIK";
            this.RECEIVER_BIK.HeaderText = "БИК банка получателя";
            this.RECEIVER_BIK.Name = "RECEIVER_BIK";
            this.RECEIVER_BIK.ReadOnly = true;
            // 
            // RECEIVER_KO
            // 
            this.RECEIVER_KO.DataPropertyName = "RECEIVER_KO";
            this.RECEIVER_KO.HeaderText = "Корсчет КО получателя";
            this.RECEIVER_KO.Name = "RECEIVER_KO";
            this.RECEIVER_KO.ReadOnly = true;
            // 
            // RECEIVER_BILL
            // 
            this.RECEIVER_BILL.DataPropertyName = "RECEIVER_BILL";
            this.RECEIVER_BILL.HeaderText = "Номер л/счета получателя";
            this.RECEIVER_BILL.Name = "RECEIVER_BILL";
            this.RECEIVER_BILL.ReadOnly = true;
            // 
            // KPD
            // 
            this.KPD.DataPropertyName = "KPD";
            this.KPD.HeaderText = "КПД";
            this.KPD.Name = "KPD";
            this.KPD.ReadOnly = true;
            // 
            // KPD_DATE
            // 
            this.KPD_DATE.DataPropertyName = "KPD_DATE";
            this.KPD_DATE.HeaderText = "Дата КПД";
            this.KPD_DATE.Name = "KPD_DATE";
            this.KPD_DATE.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nUMDataGridViewTextBoxColumn1
            // 
            this.nUMDataGridViewTextBoxColumn1.DataPropertyName = "NUM";
            this.nUMDataGridViewTextBoxColumn1.HeaderText = "NUM";
            this.nUMDataGridViewTextBoxColumn1.Name = "nUMDataGridViewTextBoxColumn1";
            this.nUMDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cREATEDATEDataGridViewTextBoxColumn1
            // 
            this.cREATEDATEDataGridViewTextBoxColumn1.DataPropertyName = "CREATE_DATE";
            this.cREATEDATEDataGridViewTextBoxColumn1.HeaderText = "CREATE_DATE";
            this.cREATEDATEDataGridViewTextBoxColumn1.Name = "cREATEDATEDataGridViewTextBoxColumn1";
            this.cREATEDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pAYMENTTYPEDataGridViewTextBoxColumn1
            // 
            this.pAYMENTTYPEDataGridViewTextBoxColumn1.DataPropertyName = "PAYMENT_TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn1.HeaderText = "PAYMENT_TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn1.Name = "pAYMENTTYPEDataGridViewTextBoxColumn1";
            this.pAYMENTTYPEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // oPERATIONTYPEDataGridViewTextBoxColumn1
            // 
            this.oPERATIONTYPEDataGridViewTextBoxColumn1.DataPropertyName = "OPERATION_TYPE";
            this.oPERATIONTYPEDataGridViewTextBoxColumn1.HeaderText = "OPERATION_TYPE";
            this.oPERATIONTYPEDataGridViewTextBoxColumn1.Name = "oPERATIONTYPEDataGridViewTextBoxColumn1";
            this.oPERATIONTYPEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rDNUMDataGridViewTextBoxColumn1
            // 
            this.rDNUMDataGridViewTextBoxColumn1.DataPropertyName = "RD_NUM";
            this.rDNUMDataGridViewTextBoxColumn1.HeaderText = "RD_NUM";
            this.rDNUMDataGridViewTextBoxColumn1.Name = "rDNUMDataGridViewTextBoxColumn1";
            this.rDNUMDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rDDATEDataGridViewTextBoxColumn1
            // 
            this.rDDATEDataGridViewTextBoxColumn1.DataPropertyName = "RD_DATE";
            this.rDDATEDataGridViewTextBoxColumn1.HeaderText = "RD_DATE";
            this.rDDATEDataGridViewTextBoxColumn1.Name = "rDDATEDataGridViewTextBoxColumn1";
            this.rDDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rDSUMDataGridViewTextBoxColumn1
            // 
            this.rDSUMDataGridViewTextBoxColumn1.DataPropertyName = "RD_SUM";
            this.rDSUMDataGridViewTextBoxColumn1.HeaderText = "RD_SUM";
            this.rDSUMDataGridViewTextBoxColumn1.Name = "rDSUMDataGridViewTextBoxColumn1";
            this.rDSUMDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sENDERBIKDataGridViewTextBoxColumn1
            // 
            this.sENDERBIKDataGridViewTextBoxColumn1.DataPropertyName = "SENDER_BIK";
            this.sENDERBIKDataGridViewTextBoxColumn1.HeaderText = "SENDER_BIK";
            this.sENDERBIKDataGridViewTextBoxColumn1.Name = "sENDERBIKDataGridViewTextBoxColumn1";
            this.sENDERBIKDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sENDERKODataGridViewTextBoxColumn1
            // 
            this.sENDERKODataGridViewTextBoxColumn1.DataPropertyName = "SENDER_KO";
            this.sENDERKODataGridViewTextBoxColumn1.HeaderText = "SENDER_KO";
            this.sENDERKODataGridViewTextBoxColumn1.Name = "sENDERKODataGridViewTextBoxColumn1";
            this.sENDERKODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sENDERBILLDataGridViewTextBoxColumn1
            // 
            this.sENDERBILLDataGridViewTextBoxColumn1.DataPropertyName = "SENDER_BILL";
            this.sENDERBILLDataGridViewTextBoxColumn1.HeaderText = "SENDER_BILL";
            this.sENDERBILLDataGridViewTextBoxColumn1.Name = "sENDERBILLDataGridViewTextBoxColumn1";
            this.sENDERBILLDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rECEIVERBIKDataGridViewTextBoxColumn1
            // 
            this.rECEIVERBIKDataGridViewTextBoxColumn1.DataPropertyName = "RECEIVER_BIK";
            this.rECEIVERBIKDataGridViewTextBoxColumn1.HeaderText = "RECEIVER_BIK";
            this.rECEIVERBIKDataGridViewTextBoxColumn1.Name = "rECEIVERBIKDataGridViewTextBoxColumn1";
            this.rECEIVERBIKDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rECEIVERKODataGridViewTextBoxColumn1
            // 
            this.rECEIVERKODataGridViewTextBoxColumn1.DataPropertyName = "RECEIVER_KO";
            this.rECEIVERKODataGridViewTextBoxColumn1.HeaderText = "RECEIVER_KO";
            this.rECEIVERKODataGridViewTextBoxColumn1.Name = "rECEIVERKODataGridViewTextBoxColumn1";
            this.rECEIVERKODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rECEIVERBILLDataGridViewTextBoxColumn1
            // 
            this.rECEIVERBILLDataGridViewTextBoxColumn1.DataPropertyName = "RECEIVER_BILL";
            this.rECEIVERBILLDataGridViewTextBoxColumn1.HeaderText = "RECEIVER_BILL";
            this.rECEIVERBILLDataGridViewTextBoxColumn1.Name = "rECEIVERBILLDataGridViewTextBoxColumn1";
            this.rECEIVERBILLDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kPDDataGridViewTextBoxColumn1
            // 
            this.kPDDataGridViewTextBoxColumn1.DataPropertyName = "KPD";
            this.kPDDataGridViewTextBoxColumn1.HeaderText = "KPD";
            this.kPDDataGridViewTextBoxColumn1.Name = "kPDDataGridViewTextBoxColumn1";
            this.kPDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kPDDATEDataGridViewTextBoxColumn1
            // 
            this.kPDDATEDataGridViewTextBoxColumn1.DataPropertyName = "KPD_DATE";
            this.kPDDATEDataGridViewTextBoxColumn1.HeaderText = "KPD_DATE";
            this.kPDDATEDataGridViewTextBoxColumn1.Name = "kPDDATEDataGridViewTextBoxColumn1";
            this.kPDDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // postavisoBindingSource
            // 
            this.postavisoBindingSource.DataMember = "post_aviso";
            this.postavisoBindingSource.DataSource = this.avisoDataSetBindingSource;
            // 
            // avisoDataSetBindingSource
            // 
            this.avisoDataSetBindingSource.DataSource = this.avisoDataSet;
            this.avisoDataSetBindingSource.Position = 0;
            // 
            // avisoDataSet
            // 
            this.avisoDataSet.DataSetName = "AvisoDataSet";
            this.avisoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 315);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(994, 29);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMain.Controls.Add(this.tpPostAviso);
            this.tcMain.Controls.Add(this.tpTeleAviso);
            this.tcMain.Location = new System.Drawing.Point(15, 47);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1166, 540);
            this.tcMain.TabIndex = 8;
            // 
            // tpPostAviso
            // 
            this.tpPostAviso.Controls.Add(this.dgvAvisoPost);
            this.tpPostAviso.Location = new System.Drawing.Point(4, 27);
            this.tpPostAviso.Margin = new System.Windows.Forms.Padding(4);
            this.tpPostAviso.Name = "tpPostAviso";
            this.tpPostAviso.Padding = new System.Windows.Forms.Padding(4);
            this.tpPostAviso.Size = new System.Drawing.Size(1158, 509);
            this.tpPostAviso.TabIndex = 0;
            this.tpPostAviso.Text = "Почтовое авизо";
            this.tpPostAviso.UseVisualStyleBackColor = true;
            // 
            // tpTeleAviso
            // 
            this.tpTeleAviso.Controls.Add(this.dgvAvisoTele);
            this.tpTeleAviso.Location = new System.Drawing.Point(4, 27);
            this.tpTeleAviso.Margin = new System.Windows.Forms.Padding(4);
            this.tpTeleAviso.Name = "tpTeleAviso";
            this.tpTeleAviso.Padding = new System.Windows.Forms.Padding(4);
            this.tpTeleAviso.Size = new System.Drawing.Size(1158, 509);
            this.tpTeleAviso.TabIndex = 1;
            this.tpTeleAviso.Text = "Телеграфное авизо";
            this.tpTeleAviso.UseVisualStyleBackColor = true;
            // 
            // dgvAvisoTele
            // 
            this.dgvAvisoTele.AllowUserToAddRows = false;
            this.dgvAvisoTele.AllowUserToDeleteRows = false;
            this.dgvAvisoTele.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAvisoTele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvisoTele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvisoTele.AutoGenerateColumns = false;
            this.dgvAvisoTele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvisoTele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nUMDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.pAYMENTTYPEDataGridViewTextBoxColumn,
            this.oPERATIONTYPEDataGridViewTextBoxColumn,
            this.rDNUMDataGridViewTextBoxColumn,
            this.rDDATEDataGridViewTextBoxColumn,
            this.oFFDATEDataGridViewTextBoxColumn,
            this.rDSUMDataGridViewTextBoxColumn,
            this.sENDERINNDataGridViewTextBoxColumn,
            this.sENDERKPPDataGridViewTextBoxColumn,
            this.sENDERNAMEDataGridViewTextBoxColumn,
            this.sENDERBIKDataGridViewTextBoxColumn,
            this.sENDERKODataGridViewTextBoxColumn,
            this.sENDERKONAMEDataGridViewTextBoxColumn,
            this.sENDERBILLDataGridViewTextBoxColumn,
            this.rECEIVERINNDataGridViewTextBoxColumn,
            this.rECEIVERKPPDataGridViewTextBoxColumn,
            this.rECEIVERNAMEDataGridViewTextBoxColumn,
            this.rECEIVERBIKDataGridViewTextBoxColumn,
            this.rECEIVERKODataGridViewTextBoxColumn,
            this.rECEIVERBILLDataGridViewTextBoxColumn,
            this.pAYMENTGOALDataGridViewTextBoxColumn,
            this.n101DataGridViewTextBoxColumn,
            this.n104DataGridViewTextBoxColumn,
            this.n105DataGridViewTextBoxColumn,
            this.n106DataGridViewTextBoxColumn,
            this.n107DataGridViewTextBoxColumn,
            this.n108DataGridViewTextBoxColumn,
            this.n109DataGridViewTextBoxColumn,
            this.n110DataGridViewTextBoxColumn,
            this.kPDDataGridViewTextBoxColumn,
            this.kPDDATEDataGridViewTextBoxColumn});
            this.dgvAvisoTele.DataSource = this.telegraphavisoBindingSource;
            this.dgvAvisoTele.Location = new System.Drawing.Point(7, 7);
            this.dgvAvisoTele.MultiSelect = false;
            this.dgvAvisoTele.Name = "dgvAvisoTele";
            this.dgvAvisoTele.ReadOnly = true;
            this.dgvAvisoTele.RowHeadersVisible = false;
            this.dgvAvisoTele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvisoTele.Size = new System.Drawing.Size(1143, 492);
            this.dgvAvisoTele.TabIndex = 0;
            // 
            // telegraphavisoBindingSource
            // 
            this.telegraphavisoBindingSource.DataMember = "telegraph_aviso";
            this.telegraphavisoBindingSource.DataSource = this.avisoDataSetBindingSource;
            // 
            // dlgSelectReport
            // 
            this.dlgSelectReport.Filter = "MS Word Documents|*.docx";
            this.dlgSelectReport.Title = "Выберите имя файла";
            // 
            // post_avisoTableAdapter
            // 
            this.post_avisoTableAdapter.ClearBeforeFill = true;
            // 
            // telegraph_avisoTableAdapter
            // 
            this.telegraph_avisoTableAdapter.ClearBeforeFill = true;
            // 
            // mmAdd
            // 
            this.mmAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAdd,
            this.mEdit,
            this.mDel,
            this.mPrint});
            this.mmAdd.Location = new System.Drawing.Point(0, 0);
            this.mmAdd.Name = "mmAdd";
            this.mmAdd.Size = new System.Drawing.Size(1194, 25);
            this.mmAdd.TabIndex = 13;
            this.mmAdd.Text = "Добавить";
            // 
            // mAdd
            // 
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(78, 21);
            this.mAdd.Text = "Добавить";
            this.mAdd.Click += new System.EventHandler(this.mAdd_Click);
            // 
            // mEdit
            // 
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(108, 21);
            this.mEdit.Text = "Редактировать";
            this.mEdit.Click += new System.EventHandler(this.mEdit_Click);
            // 
            // mDel
            // 
            this.mDel.Name = "mDel";
            this.mDel.Size = new System.Drawing.Size(67, 21);
            this.mDel.Text = "Удалить";
            this.mDel.Click += new System.EventHandler(this.mDel_Click);
            // 
            // mPrint
            // 
            this.mPrint.Name = "mPrint";
            this.mPrint.Size = new System.Drawing.Size(62, 21);
            this.mPrint.Text = "Печать";
            this.mPrint.Click += new System.EventHandler(this.mPrint_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMDataGridViewTextBoxColumn
            // 
            this.nUMDataGridViewTextBoxColumn.DataPropertyName = "NUM";
            this.nUMDataGridViewTextBoxColumn.HeaderText = "Номер авизо";
            this.nUMDataGridViewTextBoxColumn.Name = "nUMDataGridViewTextBoxColumn";
            this.nUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATE_DATE";
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "Дата авизо";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAYMENTTYPEDataGridViewTextBoxColumn
            // 
            this.pAYMENTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.HeaderText = "Вид платежа";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.Name = "pAYMENTTYPEDataGridViewTextBoxColumn";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oPERATIONTYPEDataGridViewTextBoxColumn
            // 
            this.oPERATIONTYPEDataGridViewTextBoxColumn.DataPropertyName = "OPERATION_TYPE";
            this.oPERATIONTYPEDataGridViewTextBoxColumn.HeaderText = "Вид операции";
            this.oPERATIONTYPEDataGridViewTextBoxColumn.Name = "oPERATIONTYPEDataGridViewTextBoxColumn";
            this.oPERATIONTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rDNUMDataGridViewTextBoxColumn
            // 
            this.rDNUMDataGridViewTextBoxColumn.DataPropertyName = "RD_NUM";
            this.rDNUMDataGridViewTextBoxColumn.HeaderText = "Номер РД";
            this.rDNUMDataGridViewTextBoxColumn.Name = "rDNUMDataGridViewTextBoxColumn";
            this.rDNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rDDATEDataGridViewTextBoxColumn
            // 
            this.rDDATEDataGridViewTextBoxColumn.DataPropertyName = "RD_DATE";
            this.rDDATEDataGridViewTextBoxColumn.HeaderText = "Дата РД";
            this.rDDATEDataGridViewTextBoxColumn.Name = "rDDATEDataGridViewTextBoxColumn";
            this.rDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oFFDATEDataGridViewTextBoxColumn
            // 
            this.oFFDATEDataGridViewTextBoxColumn.DataPropertyName = "OFF_DATE";
            this.oFFDATEDataGridViewTextBoxColumn.HeaderText = "Списано со счета  плательщика";
            this.oFFDATEDataGridViewTextBoxColumn.Name = "oFFDATEDataGridViewTextBoxColumn";
            this.oFFDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rDSUMDataGridViewTextBoxColumn
            // 
            this.rDSUMDataGridViewTextBoxColumn.DataPropertyName = "RD_SUM";
            this.rDSUMDataGridViewTextBoxColumn.HeaderText = "Сумма РД";
            this.rDSUMDataGridViewTextBoxColumn.Name = "rDSUMDataGridViewTextBoxColumn";
            this.rDSUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERINNDataGridViewTextBoxColumn
            // 
            this.sENDERINNDataGridViewTextBoxColumn.DataPropertyName = "SENDER_INN";
            this.sENDERINNDataGridViewTextBoxColumn.HeaderText = "ИНН плательщика";
            this.sENDERINNDataGridViewTextBoxColumn.Name = "sENDERINNDataGridViewTextBoxColumn";
            this.sENDERINNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERKPPDataGridViewTextBoxColumn
            // 
            this.sENDERKPPDataGridViewTextBoxColumn.DataPropertyName = "SENDER_KPP";
            this.sENDERKPPDataGridViewTextBoxColumn.HeaderText = "КПП плательщика";
            this.sENDERKPPDataGridViewTextBoxColumn.Name = "sENDERKPPDataGridViewTextBoxColumn";
            this.sENDERKPPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERNAMEDataGridViewTextBoxColumn
            // 
            this.sENDERNAMEDataGridViewTextBoxColumn.DataPropertyName = "SENDER_NAME";
            this.sENDERNAMEDataGridViewTextBoxColumn.HeaderText = "Наименование плательщика";
            this.sENDERNAMEDataGridViewTextBoxColumn.Name = "sENDERNAMEDataGridViewTextBoxColumn";
            this.sENDERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERBIKDataGridViewTextBoxColumn
            // 
            this.sENDERBIKDataGridViewTextBoxColumn.DataPropertyName = "SENDER_BIK";
            this.sENDERBIKDataGridViewTextBoxColumn.HeaderText = "БИК банка плательщика";
            this.sENDERBIKDataGridViewTextBoxColumn.Name = "sENDERBIKDataGridViewTextBoxColumn";
            this.sENDERBIKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERKODataGridViewTextBoxColumn
            // 
            this.sENDERKODataGridViewTextBoxColumn.DataPropertyName = "SENDER_KO";
            this.sENDERKODataGridViewTextBoxColumn.HeaderText = "Корсчет КО плательщика";
            this.sENDERKODataGridViewTextBoxColumn.Name = "sENDERKODataGridViewTextBoxColumn";
            this.sENDERKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERKONAMEDataGridViewTextBoxColumn
            // 
            this.sENDERKONAMEDataGridViewTextBoxColumn.DataPropertyName = "SENDER_KO_NAME";
            this.sENDERKONAMEDataGridViewTextBoxColumn.HeaderText = "Наименование КО плательщика";
            this.sENDERKONAMEDataGridViewTextBoxColumn.Name = "sENDERKONAMEDataGridViewTextBoxColumn";
            this.sENDERKONAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERBILLDataGridViewTextBoxColumn
            // 
            this.sENDERBILLDataGridViewTextBoxColumn.DataPropertyName = "SENDER_BILL";
            this.sENDERBILLDataGridViewTextBoxColumn.HeaderText = "Номер лицевого счета плательщика";
            this.sENDERBILLDataGridViewTextBoxColumn.Name = "sENDERBILLDataGridViewTextBoxColumn";
            this.sENDERBILLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERINNDataGridViewTextBoxColumn
            // 
            this.rECEIVERINNDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_INN";
            this.rECEIVERINNDataGridViewTextBoxColumn.HeaderText = "ИНН получателя";
            this.rECEIVERINNDataGridViewTextBoxColumn.Name = "rECEIVERINNDataGridViewTextBoxColumn";
            this.rECEIVERINNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERKPPDataGridViewTextBoxColumn
            // 
            this.rECEIVERKPPDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_KPP";
            this.rECEIVERKPPDataGridViewTextBoxColumn.HeaderText = "КПП получателя";
            this.rECEIVERKPPDataGridViewTextBoxColumn.Name = "rECEIVERKPPDataGridViewTextBoxColumn";
            this.rECEIVERKPPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERNAMEDataGridViewTextBoxColumn
            // 
            this.rECEIVERNAMEDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_NAME";
            this.rECEIVERNAMEDataGridViewTextBoxColumn.HeaderText = "Наименование получателя";
            this.rECEIVERNAMEDataGridViewTextBoxColumn.Name = "rECEIVERNAMEDataGridViewTextBoxColumn";
            this.rECEIVERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERBIKDataGridViewTextBoxColumn
            // 
            this.rECEIVERBIKDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_BIK";
            this.rECEIVERBIKDataGridViewTextBoxColumn.HeaderText = "БИК банка получателя";
            this.rECEIVERBIKDataGridViewTextBoxColumn.Name = "rECEIVERBIKDataGridViewTextBoxColumn";
            this.rECEIVERBIKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERKODataGridViewTextBoxColumn
            // 
            this.rECEIVERKODataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_KO";
            this.rECEIVERKODataGridViewTextBoxColumn.HeaderText = "Корсчет КО получателя";
            this.rECEIVERKODataGridViewTextBoxColumn.Name = "rECEIVERKODataGridViewTextBoxColumn";
            this.rECEIVERKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERBILLDataGridViewTextBoxColumn
            // 
            this.rECEIVERBILLDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_BILL";
            this.rECEIVERBILLDataGridViewTextBoxColumn.HeaderText = "Номер лицевого счета получателя";
            this.rECEIVERBILLDataGridViewTextBoxColumn.Name = "rECEIVERBILLDataGridViewTextBoxColumn";
            this.rECEIVERBILLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAYMENTGOALDataGridViewTextBoxColumn
            // 
            this.pAYMENTGOALDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_GOAL";
            this.pAYMENTGOALDataGridViewTextBoxColumn.HeaderText = "Назначение платежа";
            this.pAYMENTGOALDataGridViewTextBoxColumn.Name = "pAYMENTGOALDataGridViewTextBoxColumn";
            this.pAYMENTGOALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n101DataGridViewTextBoxColumn
            // 
            this.n101DataGridViewTextBoxColumn.DataPropertyName = "N101";
            this.n101DataGridViewTextBoxColumn.HeaderText = "101";
            this.n101DataGridViewTextBoxColumn.Name = "n101DataGridViewTextBoxColumn";
            this.n101DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n104DataGridViewTextBoxColumn
            // 
            this.n104DataGridViewTextBoxColumn.DataPropertyName = "N104";
            this.n104DataGridViewTextBoxColumn.HeaderText = "104";
            this.n104DataGridViewTextBoxColumn.Name = "n104DataGridViewTextBoxColumn";
            this.n104DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n105DataGridViewTextBoxColumn
            // 
            this.n105DataGridViewTextBoxColumn.DataPropertyName = "N105";
            this.n105DataGridViewTextBoxColumn.HeaderText = "105";
            this.n105DataGridViewTextBoxColumn.Name = "n105DataGridViewTextBoxColumn";
            this.n105DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n106DataGridViewTextBoxColumn
            // 
            this.n106DataGridViewTextBoxColumn.DataPropertyName = "N106";
            this.n106DataGridViewTextBoxColumn.HeaderText = "106";
            this.n106DataGridViewTextBoxColumn.Name = "n106DataGridViewTextBoxColumn";
            this.n106DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n107DataGridViewTextBoxColumn
            // 
            this.n107DataGridViewTextBoxColumn.DataPropertyName = "N107";
            this.n107DataGridViewTextBoxColumn.HeaderText = "107";
            this.n107DataGridViewTextBoxColumn.Name = "n107DataGridViewTextBoxColumn";
            this.n107DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n108DataGridViewTextBoxColumn
            // 
            this.n108DataGridViewTextBoxColumn.DataPropertyName = "N108";
            this.n108DataGridViewTextBoxColumn.HeaderText = "108";
            this.n108DataGridViewTextBoxColumn.Name = "n108DataGridViewTextBoxColumn";
            this.n108DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n109DataGridViewTextBoxColumn
            // 
            this.n109DataGridViewTextBoxColumn.DataPropertyName = "N109";
            this.n109DataGridViewTextBoxColumn.HeaderText = "109";
            this.n109DataGridViewTextBoxColumn.Name = "n109DataGridViewTextBoxColumn";
            this.n109DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // n110DataGridViewTextBoxColumn
            // 
            this.n110DataGridViewTextBoxColumn.DataPropertyName = "N110";
            this.n110DataGridViewTextBoxColumn.HeaderText = "110";
            this.n110DataGridViewTextBoxColumn.Name = "n110DataGridViewTextBoxColumn";
            this.n110DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kPDDataGridViewTextBoxColumn
            // 
            this.kPDDataGridViewTextBoxColumn.DataPropertyName = "KPD";
            this.kPDDataGridViewTextBoxColumn.HeaderText = "КПД";
            this.kPDDataGridViewTextBoxColumn.Name = "kPDDataGridViewTextBoxColumn";
            this.kPDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kPDDATEDataGridViewTextBoxColumn
            // 
            this.kPDDATEDataGridViewTextBoxColumn.DataPropertyName = "KPD_DATE";
            this.kPDDATEDataGridViewTextBoxColumn.HeaderText = "Дата КПД";
            this.kPDDATEDataGridViewTextBoxColumn.Name = "kPDDATEDataGridViewTextBoxColumn";
            this.kPDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 600);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mmAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mmAdd;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авизо";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisoPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavisoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisoDataSet)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpPostAviso.ResumeLayout(false);
            this.tpTeleAviso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisoTele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telegraphavisoBindingSource)).EndInit();
            this.mmAdd.ResumeLayout(false);
            this.mmAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvisoPost;
        private System.Windows.Forms.BindingSource avisoDataSetBindingSource;
        private AvisoDataSet avisoDataSet;
        private System.Windows.Forms.BindingSource postavisoBindingSource;
        private AvisoDataSetTableAdapters.post_avisoTableAdapter post_avisoTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpPostAviso;
        private System.Windows.Forms.TabPage tpTeleAviso;
        private SaveFileDialog dlgSelectReport;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NUM;
        private DataGridViewTextBoxColumn CREATE_DATE;
        private DataGridViewTextBoxColumn PAYMENT_TYPE;
        private DataGridViewTextBoxColumn OPERATION_TYPE;
        private DataGridViewTextBoxColumn RD_NUM;
        private DataGridViewTextBoxColumn RD_DATE;
        private DataGridViewTextBoxColumn RD_SUM;
        private DataGridViewTextBoxColumn SENDER_BIK;
        private DataGridViewTextBoxColumn SENDER_KO;
        private DataGridViewTextBoxColumn SENDER_BILL;
        private DataGridViewTextBoxColumn RECEIVER_BIK;
        private DataGridViewTextBoxColumn RECEIVER_KO;
        private DataGridViewTextBoxColumn RECEIVER_BILL;
        private DataGridViewTextBoxColumn KPD;
        private DataGridViewTextBoxColumn KPD_DATE;
        private DataGridView dgvAvisoTele;
        private BindingSource telegraphavisoBindingSource;
        private AvisoDataSetTableAdapters.telegraph_avisoTableAdapter telegraph_avisoTableAdapter;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nUMDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pAYMENTTYPEDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn oPERATIONTYPEDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rDNUMDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rDDATEDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rDSUMDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sENDERBIKDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sENDERKODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sENDERBILLDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rECEIVERBIKDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rECEIVERKODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rECEIVERBILLDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kPDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kPDDATEDataGridViewTextBoxColumn1;
        private MenuStrip mmAdd;
        private ToolStripMenuItem mAdd;
        private ToolStripMenuItem mEdit;
        private ToolStripMenuItem mDel;
        private ToolStripMenuItem mPrint;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nUMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pAYMENTTYPEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oPERATIONTYPEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rDNUMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rDDATEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oFFDATEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rDSUMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sENDERINNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sENDERKPPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sENDERNAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sENDERBIKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sENDERKODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sENDERKONAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sENDERBILLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rECEIVERINNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rECEIVERKPPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rECEIVERNAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rECEIVERBIKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rECEIVERKODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rECEIVERBILLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pAYMENTGOALDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn n101DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn n104DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn n105DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn n106DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn n107DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn n108DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn n109DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn n110DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kPDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kPDDATEDataGridViewTextBoxColumn;
    }
}

