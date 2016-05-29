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
            this.postavisoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avisoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avisoDataSet = new Aviso.AvisoDataSet();
            this.dgvLookup = new System.Windows.Forms.DataGridView();
            this.btnEditAviso = new System.Windows.Forms.Button();
            this.btnAddAviso = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.post_avisoTableAdapter = new Aviso.AvisoDataSetTableAdapters.post_avisoTableAdapter();
            this.btnDeleteAviso = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATIONTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDSUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERBIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENDERBILLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERBIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIVERBILLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisoPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavisoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookup)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAvisoPost
            // 
            this.dgvAvisoPost.AllowUserToAddRows = false;
            this.dgvAvisoPost.AllowUserToDeleteRows = false;
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
            this.iDDataGridViewTextBoxColumn,
            this.nUMDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.pAYMENTTYPEDataGridViewTextBoxColumn,
            this.oPERATIONTYPEDataGridViewTextBoxColumn,
            this.rDNUMDataGridViewTextBoxColumn,
            this.rDDATEDataGridViewTextBoxColumn,
            this.rDSUMDataGridViewTextBoxColumn,
            this.sENDERBIKDataGridViewTextBoxColumn,
            this.sENDERKODataGridViewTextBoxColumn,
            this.sENDERBILLDataGridViewTextBoxColumn,
            this.rECEIVERBIKDataGridViewTextBoxColumn,
            this.rECEIVERKODataGridViewTextBoxColumn,
            this.rECEIVERBILLDataGridViewTextBoxColumn,
            this.kPDDataGridViewTextBoxColumn,
            this.kPDDATEDataGridViewTextBoxColumn});
            this.dgvAvisoPost.DataSource = this.postavisoBindingSource;
            this.dgvAvisoPost.Location = new System.Drawing.Point(8, 4);
            this.dgvAvisoPost.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAvisoPost.MultiSelect = false;
            this.dgvAvisoPost.Name = "dgvAvisoPost";
            this.dgvAvisoPost.ReadOnly = true;
            this.dgvAvisoPost.RowHeadersVisible = false;
            this.dgvAvisoPost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvisoPost.Size = new System.Drawing.Size(1145, 293);
            this.dgvAvisoPost.TabIndex = 0;
            this.dgvAvisoPost.DoubleClick += new System.EventHandler(this.btnEditAviso_Click);
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
            // dgvLookup
            // 
            this.dgvLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLookup.Location = new System.Drawing.Point(728, 373);
            this.dgvLookup.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLookup.Name = "dgvLookup";
            this.dgvLookup.Size = new System.Drawing.Size(433, 224);
            this.dgvLookup.TabIndex = 1;
            // 
            // btnEditAviso
            // 
            this.btnEditAviso.Location = new System.Drawing.Point(114, 359);
            this.btnEditAviso.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAviso.Name = "btnEditAviso";
            this.btnEditAviso.Size = new System.Drawing.Size(113, 26);
            this.btnEditAviso.TabIndex = 2;
            this.btnEditAviso.Text = "Редактировать";
            this.btnEditAviso.UseVisualStyleBackColor = true;
            this.btnEditAviso.Click += new System.EventHandler(this.btnEditAviso_Click);
            // 
            // btnAddAviso
            // 
            this.btnAddAviso.Location = new System.Drawing.Point(18, 359);
            this.btnAddAviso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAviso.Name = "btnAddAviso";
            this.btnAddAviso.Size = new System.Drawing.Size(88, 26);
            this.btnAddAviso.TabIndex = 3;
            this.btnAddAviso.Text = "Добавить";
            this.btnAddAviso.UseVisualStyleBackColor = true;
            this.btnAddAviso.Click += new System.EventHandler(this.btnAddAviso_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavisoBindingSource, "NUM", true));
            this.textBox1.Location = new System.Drawing.Point(396, 502);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 21);
            this.textBox1.TabIndex = 5;
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 408);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 337);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAvisoPost);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1156, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Почтовое авизо";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1156, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Телеграфное авизо";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // post_avisoTableAdapter
            // 
            this.post_avisoTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteAviso
            // 
            this.btnDeleteAviso.Location = new System.Drawing.Point(234, 359);
            this.btnDeleteAviso.Name = "btnDeleteAviso";
            this.btnDeleteAviso.Size = new System.Drawing.Size(75, 26);
            this.btnDeleteAviso.TabIndex = 9;
            this.btnDeleteAviso.Text = "Удалить";
            this.btnDeleteAviso.UseVisualStyleBackColor = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMDataGridViewTextBoxColumn
            // 
            this.nUMDataGridViewTextBoxColumn.DataPropertyName = "NUM";
            this.nUMDataGridViewTextBoxColumn.HeaderText = "NUM";
            this.nUMDataGridViewTextBoxColumn.Name = "nUMDataGridViewTextBoxColumn";
            this.nUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATE_DATE";
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "CREATE_DATE";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAYMENTTYPEDataGridViewTextBoxColumn
            // 
            this.pAYMENTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.HeaderText = "PAYMENT_TYPE";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.Name = "pAYMENTTYPEDataGridViewTextBoxColumn";
            this.pAYMENTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oPERATIONTYPEDataGridViewTextBoxColumn
            // 
            this.oPERATIONTYPEDataGridViewTextBoxColumn.DataPropertyName = "OPERATION_TYPE";
            this.oPERATIONTYPEDataGridViewTextBoxColumn.HeaderText = "OPERATION_TYPE";
            this.oPERATIONTYPEDataGridViewTextBoxColumn.Name = "oPERATIONTYPEDataGridViewTextBoxColumn";
            this.oPERATIONTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rDNUMDataGridViewTextBoxColumn
            // 
            this.rDNUMDataGridViewTextBoxColumn.DataPropertyName = "RD_NUM";
            this.rDNUMDataGridViewTextBoxColumn.HeaderText = "RD_NUM";
            this.rDNUMDataGridViewTextBoxColumn.Name = "rDNUMDataGridViewTextBoxColumn";
            this.rDNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rDDATEDataGridViewTextBoxColumn
            // 
            this.rDDATEDataGridViewTextBoxColumn.DataPropertyName = "RD_DATE";
            this.rDDATEDataGridViewTextBoxColumn.HeaderText = "RD_DATE";
            this.rDDATEDataGridViewTextBoxColumn.Name = "rDDATEDataGridViewTextBoxColumn";
            this.rDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rDSUMDataGridViewTextBoxColumn
            // 
            this.rDSUMDataGridViewTextBoxColumn.DataPropertyName = "RD_SUM";
            this.rDSUMDataGridViewTextBoxColumn.HeaderText = "RD_SUM";
            this.rDSUMDataGridViewTextBoxColumn.Name = "rDSUMDataGridViewTextBoxColumn";
            this.rDSUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERBIKDataGridViewTextBoxColumn
            // 
            this.sENDERBIKDataGridViewTextBoxColumn.DataPropertyName = "SENDER_BIK";
            this.sENDERBIKDataGridViewTextBoxColumn.HeaderText = "SENDER_BIK";
            this.sENDERBIKDataGridViewTextBoxColumn.Name = "sENDERBIKDataGridViewTextBoxColumn";
            this.sENDERBIKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERKODataGridViewTextBoxColumn
            // 
            this.sENDERKODataGridViewTextBoxColumn.DataPropertyName = "SENDER_KO";
            this.sENDERKODataGridViewTextBoxColumn.HeaderText = "SENDER_KO";
            this.sENDERKODataGridViewTextBoxColumn.Name = "sENDERKODataGridViewTextBoxColumn";
            this.sENDERKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENDERBILLDataGridViewTextBoxColumn
            // 
            this.sENDERBILLDataGridViewTextBoxColumn.DataPropertyName = "SENDER_BILL";
            this.sENDERBILLDataGridViewTextBoxColumn.HeaderText = "SENDER_BILL";
            this.sENDERBILLDataGridViewTextBoxColumn.Name = "sENDERBILLDataGridViewTextBoxColumn";
            this.sENDERBILLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERBIKDataGridViewTextBoxColumn
            // 
            this.rECEIVERBIKDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_BIK";
            this.rECEIVERBIKDataGridViewTextBoxColumn.HeaderText = "RECEIVER_BIK";
            this.rECEIVERBIKDataGridViewTextBoxColumn.Name = "rECEIVERBIKDataGridViewTextBoxColumn";
            this.rECEIVERBIKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERKODataGridViewTextBoxColumn
            // 
            this.rECEIVERKODataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_KO";
            this.rECEIVERKODataGridViewTextBoxColumn.HeaderText = "RECEIVER_KO";
            this.rECEIVERKODataGridViewTextBoxColumn.Name = "rECEIVERKODataGridViewTextBoxColumn";
            this.rECEIVERKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIVERBILLDataGridViewTextBoxColumn
            // 
            this.rECEIVERBILLDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER_BILL";
            this.rECEIVERBILLDataGridViewTextBoxColumn.HeaderText = "RECEIVER_BILL";
            this.rECEIVERBILLDataGridViewTextBoxColumn.Name = "rECEIVERBILLDataGridViewTextBoxColumn";
            this.rECEIVERBILLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kPDDataGridViewTextBoxColumn
            // 
            this.kPDDataGridViewTextBoxColumn.DataPropertyName = "KPD";
            this.kPDDataGridViewTextBoxColumn.HeaderText = "KPD";
            this.kPDDataGridViewTextBoxColumn.Name = "kPDDataGridViewTextBoxColumn";
            this.kPDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kPDDATEDataGridViewTextBoxColumn
            // 
            this.kPDDATEDataGridViewTextBoxColumn.DataPropertyName = "KPD_DATE";
            this.kPDDATEDataGridViewTextBoxColumn.HeaderText = "KPD_DATE";
            this.kPDDATEDataGridViewTextBoxColumn.Name = "kPDDATEDataGridViewTextBoxColumn";
            this.kPDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavisoBindingSource, "PAYMENT_TYPE", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Почтой",
            "Телеграфом"});
            this.comboBox1.Location = new System.Drawing.Point(57, 459);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDeleteAviso);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddAviso);
            this.Controls.Add(this.btnEditAviso);
            this.Controls.Add(this.dgvLookup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Авизо";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvisoPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavisoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookup)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvisoPost;
        private System.Windows.Forms.BindingSource avisoDataSetBindingSource;
        private AvisoDataSet avisoDataSet;
        private System.Windows.Forms.BindingSource postavisoBindingSource;
        private AvisoDataSetTableAdapters.post_avisoTableAdapter post_avisoTableAdapter;
        private System.Windows.Forms.DataGridView dgvLookup;
        private System.Windows.Forms.Button btnEditAviso;
        private System.Windows.Forms.Button btnAddAviso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYMENT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATION_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RD_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn RD_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RD_SUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENDER_BIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENDER_KO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENDER_BILL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIVER_BIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIVER_KO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIVER_BILL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPD_DATE;
        private System.Windows.Forms.Button btnDeleteAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATIONTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDSUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENDERBIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENDERKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENDERBILLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECEIVERBIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECEIVERKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECEIVERBILLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

