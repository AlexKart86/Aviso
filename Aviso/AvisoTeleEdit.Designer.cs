using System.Windows.Forms;

namespace Aviso
{
    partial class AvisoTeleEdit
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

        //Делаем кнопку закрыть недоступной
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOperationType = new System.Windows.Forms.ComboBox();
            this.txtRDNum = new System.Windows.Forms.MaskedTextBox();
            this.errOperType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errAvisoNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtpRDDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.errPaymentType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSenderBill = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRDSum = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenderKOName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSenderKPP = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSenderINN = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSenderBill = new System.Windows.Forms.MaskedTextBox();
            this.btnSenderSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSenderKO = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSenderBIK = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReceiverKOName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtReceiverINN = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtReceiverKPP = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtReceiverBill = new System.Windows.Forms.MaskedTextBox();
            this.btnReceiverSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbReceiverKO = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbReceiverBIK = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpKPDDate = new System.Windows.Forms.DateTimePicker();
            this.txtKPD = new System.Windows.Forms.MaskedTextBox();
            this.errReceiverBill = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSenderKO = new System.Windows.Forms.ErrorProvider(this.components);
            this.errReceiverKO = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSenderBIK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errReceiverBIK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errRDDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errRDNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpOffDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.errOffDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt110 = new System.Windows.Forms.MaskedTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txt109 = new System.Windows.Forms.MaskedTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt108 = new System.Windows.Forms.MaskedTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt107 = new System.Windows.Forms.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txt106 = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt105 = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txt104 = new System.Windows.Forms.MaskedTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt101 = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtPaymentGoal = new System.Windows.Forms.TextBox();
            this.errSenderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errReceiverName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPaymentGoal = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errOperType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAvisoNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSenderBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errReceiverBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSenderKO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errReceiverKO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSenderBIK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errReceiverBIK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRDDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOffDate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSenderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errReceiverName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(143, 15);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.MaxLength = 3;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(156, 23);
            this.txtNum.TabIndex = 0;
            this.txtNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер авизо";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Checked = false;
            this.dtpCreatedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDate.Location = new System.Drawing.Point(143, 50);
            this.dtpCreatedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.ShowCheckBox = true;
            this.dtpCreatedDate.Size = new System.Drawing.Size(156, 23);
            this.dtpCreatedDate.TabIndex = 1;
            this.dtpCreatedDate.ValueChanged += new System.EventHandler(this.dtpRDDate_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 462);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(143, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата авизо";
            // 
            // cbItemType
            // 
            this.cbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Items.AddRange(new object[] {
            "Почтой",
            "Телеграфом"});
            this.cbItemType.Location = new System.Drawing.Point(143, 85);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(156, 24);
            this.cbItemType.TabIndex = 2;
            this.cbItemType.Validating += new System.ComponentModel.CancelEventHandler(this.cbItemType_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вид платежа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вид операции";
            // 
            // cbOperationType
            // 
            this.cbOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Items.AddRange(new object[] {
            "01",
            "02",
            "06",
            "16",
            "09"});
            this.cbOperationType.Location = new System.Drawing.Point(143, 121);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(156, 24);
            this.cbOperationType.TabIndex = 3;
            this.cbOperationType.Validating += new System.ComponentModel.CancelEventHandler(this.OperType_Validating);
            // 
            // txtRDNum
            // 
            this.txtRDNum.Location = new System.Drawing.Point(143, 157);
            this.txtRDNum.Mask = "999999";
            this.txtRDNum.Name = "txtRDNum";
            this.txtRDNum.Size = new System.Drawing.Size(156, 23);
            this.txtRDNum.TabIndex = 4;
            this.txtRDNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtRDNum_Validating);
            // 
            // errOperType
            // 
            this.errOperType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errOperType.ContainerControl = this;
            // 
            // errAvisoNum
            // 
            this.errAvisoNum.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAvisoNum.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Номер РД";
            // 
            // dtpRDDate
            // 
            this.dtpRDDate.Checked = false;
            this.dtpRDDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRDDate.Location = new System.Drawing.Point(143, 192);
            this.dtpRDDate.Name = "dtpRDDate";
            this.dtpRDDate.ShowCheckBox = true;
            this.dtpRDDate.Size = new System.Drawing.Size(156, 23);
            this.dtpRDDate.TabIndex = 5;
            this.dtpRDDate.ValueChanged += new System.EventHandler(this.dtpRDDate_ValueChanged);
            this.dtpRDDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpRDDate_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата РД";
            // 
            // errPaymentType
            // 
            this.errPaymentType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPaymentType.ContainerControl = this;
            // 
            // errSenderBill
            // 
            this.errSenderBill.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errSenderBill.ContainerControl = this;
            // 
            // txtRDSum
            // 
            this.txtRDSum.Location = new System.Drawing.Point(143, 273);
            this.txtRDSum.Name = "txtRDSum";
            this.txtRDSum.PromptChar = ' ';
            this.txtRDSum.Size = new System.Drawing.Size(156, 23);
            this.txtRDSum.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Сумма РД";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenderKOName);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtSenderName);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtSenderKPP);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtSenderINN);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtSenderBill);
            this.groupBox1.Controls.Add(this.btnSenderSearch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbSenderKO);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbSenderBIK);
            this.groupBox1.Location = new System.Drawing.Point(325, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 416);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Плательщик";
            // 
            // txtSenderKOName
            // 
            this.txtSenderKOName.Location = new System.Drawing.Point(20, 305);
            this.txtSenderKOName.MaxLength = 120;
            this.txtSenderKOName.Name = "txtSenderKOName";
            this.txtSenderKOName.Size = new System.Drawing.Size(259, 23);
            this.txtSenderKOName.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 285);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 17);
            this.label20.TabIndex = 14;
            this.label20.Text = "Наименование КО";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(20, 150);
            this.txtSenderName.MaxLength = 160;
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(259, 23);
            this.txtSenderName.TabIndex = 2;
            this.txtSenderName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenderName_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Наименование";
            // 
            // txtSenderKPP
            // 
            this.txtSenderKPP.Location = new System.Drawing.Point(20, 97);
            this.txtSenderKPP.Mask = "999999999";
            this.txtSenderKPP.Name = "txtSenderKPP";
            this.txtSenderKPP.Size = new System.Drawing.Size(259, 23);
            this.txtSenderKPP.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 17);
            this.label18.TabIndex = 11;
            this.label18.Text = "КПП";
            // 
            // txtSenderINN
            // 
            this.txtSenderINN.Location = new System.Drawing.Point(20, 45);
            this.txtSenderINN.Mask = "999999999999";
            this.txtSenderINN.Name = "txtSenderINN";
            this.txtSenderINN.Size = new System.Drawing.Size(259, 23);
            this.txtSenderINN.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 9;
            this.label17.Text = "ИНН";
            // 
            // txtSenderBill
            // 
            this.txtSenderBill.Location = new System.Drawing.Point(20, 354);
            this.txtSenderBill.Mask = "99999999999999999999";
            this.txtSenderBill.Name = "txtSenderBill";
            this.txtSenderBill.Size = new System.Drawing.Size(259, 23);
            this.txtSenderBill.TabIndex = 6;
            this.txtSenderBill.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenderBill_Validating);
            // 
            // btnSenderSearch
            // 
            this.btnSenderSearch.Location = new System.Drawing.Point(21, 383);
            this.btnSenderSearch.Name = "btnSenderSearch";
            this.btnSenderSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSenderSearch.TabIndex = 7;
            this.btnSenderSearch.TabStop = false;
            this.btnSenderSearch.Text = "Найти";
            this.btnSenderSearch.UseVisualStyleBackColor = true;
            this.btnSenderSearch.Click += new System.EventHandler(this.btnSenderSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Номер л/счета";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Корсчет КО";
            // 
            // cbSenderKO
            // 
            this.cbSenderKO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSenderKO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSenderKO.FormattingEnabled = true;
            this.cbSenderKO.Location = new System.Drawing.Point(20, 248);
            this.cbSenderKO.Name = "cbSenderKO";
            this.cbSenderKO.Size = new System.Drawing.Size(259, 24);
            this.cbSenderKO.TabIndex = 4;
            this.cbSenderKO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDigits_KeyPress);
            this.cbSenderKO.Validating += new System.ComponentModel.CancelEventHandler(this.cbSenderKO_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "БИК банка";
            // 
            // cbSenderBIK
            // 
            this.cbSenderBIK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSenderBIK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSenderBIK.FormattingEnabled = true;
            this.cbSenderBIK.Location = new System.Drawing.Point(20, 196);
            this.cbSenderBIK.Name = "cbSenderBIK";
            this.cbSenderBIK.Size = new System.Drawing.Size(259, 24);
            this.cbSenderBIK.TabIndex = 3;
            this.cbSenderBIK.SelectedIndexChanged += new System.EventHandler(this.cbSenderBIK_SelectedIndexChanged);
            this.cbSenderBIK.TextChanged += new System.EventHandler(this.cbSenderBIK_SelectedIndexChanged);
            this.cbSenderBIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDigits_KeyPress);
            this.cbSenderBIK.Validating += new System.ComponentModel.CancelEventHandler(this.cbSenderBIK_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceiverKOName);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtReceiverINN);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtReceiverName);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtReceiverKPP);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtReceiverBill);
            this.groupBox2.Controls.Add(this.btnReceiverSearch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbReceiverKO);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbReceiverBIK);
            this.groupBox2.Location = new System.Drawing.Point(646, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 413);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Получатель";
            // 
            // txtReceiverKOName
            // 
            this.txtReceiverKOName.Location = new System.Drawing.Point(20, 302);
            this.txtReceiverKOName.MaxLength = 120;
            this.txtReceiverKOName.Name = "txtReceiverKOName";
            this.txtReceiverKOName.Size = new System.Drawing.Size(259, 23);
            this.txtReceiverKOName.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 282);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(130, 17);
            this.label24.TabIndex = 21;
            this.label24.Text = "Наименование КО";
            // 
            // txtReceiverINN
            // 
            this.txtReceiverINN.Location = new System.Drawing.Point(20, 42);
            this.txtReceiverINN.Mask = "999999999999";
            this.txtReceiverINN.Name = "txtReceiverINN";
            this.txtReceiverINN.Size = new System.Drawing.Size(259, 23);
            this.txtReceiverINN.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 17);
            this.label23.TabIndex = 20;
            this.label23.Text = "ИНН";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(20, 147);
            this.txtReceiverName.MaxLength = 160;
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(259, 23);
            this.txtReceiverName.TabIndex = 2;
            this.txtReceiverName.Validating += new System.ComponentModel.CancelEventHandler(this.txtReceiverName_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(106, 17);
            this.label22.TabIndex = 17;
            this.label22.Text = "Наименование";
            // 
            // txtReceiverKPP
            // 
            this.txtReceiverKPP.Location = new System.Drawing.Point(20, 94);
            this.txtReceiverKPP.Mask = "999999999";
            this.txtReceiverKPP.Name = "txtReceiverKPP";
            this.txtReceiverKPP.Size = new System.Drawing.Size(259, 23);
            this.txtReceiverKPP.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 17);
            this.label21.TabIndex = 16;
            this.label21.Text = "КПП ";
            // 
            // txtReceiverBill
            // 
            this.txtReceiverBill.Location = new System.Drawing.Point(20, 351);
            this.txtReceiverBill.Mask = "99999999999999999999";
            this.txtReceiverBill.Name = "txtReceiverBill";
            this.txtReceiverBill.Size = new System.Drawing.Size(259, 23);
            this.txtReceiverBill.TabIndex = 6;
            this.txtReceiverBill.Validating += new System.ComponentModel.CancelEventHandler(this.txtReceiverBill_Validating);
            // 
            // btnReceiverSearch
            // 
            this.btnReceiverSearch.Location = new System.Drawing.Point(20, 380);
            this.btnReceiverSearch.Name = "btnReceiverSearch";
            this.btnReceiverSearch.Size = new System.Drawing.Size(75, 28);
            this.btnReceiverSearch.TabIndex = 14;
            this.btnReceiverSearch.TabStop = false;
            this.btnReceiverSearch.Text = "Найти";
            this.btnReceiverSearch.UseVisualStyleBackColor = true;
            this.btnReceiverSearch.Click += new System.EventHandler(this.btnReceiverSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Номер л/счета";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Корсчет КО";
            // 
            // cbReceiverKO
            // 
            this.cbReceiverKO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbReceiverKO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReceiverKO.FormattingEnabled = true;
            this.cbReceiverKO.Location = new System.Drawing.Point(20, 245);
            this.cbReceiverKO.Name = "cbReceiverKO";
            this.cbReceiverKO.Size = new System.Drawing.Size(259, 24);
            this.cbReceiverKO.TabIndex = 4;
            this.cbReceiverKO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDigits_KeyPress);
            this.cbReceiverKO.Validating += new System.ComponentModel.CancelEventHandler(this.cbReceiverKO_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "БИК банка";
            // 
            // cbReceiverBIK
            // 
            this.cbReceiverBIK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbReceiverBIK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReceiverBIK.FormattingEnabled = true;
            this.cbReceiverBIK.Location = new System.Drawing.Point(20, 193);
            this.cbReceiverBIK.Name = "cbReceiverBIK";
            this.cbReceiverBIK.Size = new System.Drawing.Size(259, 24);
            this.cbReceiverBIK.TabIndex = 3;
            this.cbReceiverBIK.SelectedIndexChanged += new System.EventHandler(this.cbReceiverBIK_SelectedIndexChanged);
            this.cbReceiverBIK.TextChanged += new System.EventHandler(this.cbReceiverBIK_SelectedIndexChanged);
            this.cbReceiverBIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDigits_KeyPress);
            this.cbReceiverBIK.Validating += new System.ComponentModel.CancelEventHandler(this.cbReceiverBIK_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "КПД";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Дата КПД";
            // 
            // dtpKPDDate
            // 
            this.dtpKPDDate.Checked = false;
            this.dtpKPDDate.CustomFormat = "dd/MM/yyyy";
            this.dtpKPDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKPDDate.Location = new System.Drawing.Point(143, 343);
            this.dtpKPDDate.Name = "dtpKPDDate";
            this.dtpKPDDate.ShowCheckBox = true;
            this.dtpKPDDate.Size = new System.Drawing.Size(156, 23);
            this.dtpKPDDate.TabIndex = 9;
            this.dtpKPDDate.ValueChanged += new System.EventHandler(this.dtpRDDate_ValueChanged);
            // 
            // txtKPD
            // 
            this.txtKPD.Location = new System.Drawing.Point(143, 309);
            this.txtKPD.Mask = "99999 999";
            this.txtKPD.Name = "txtKPD";
            this.txtKPD.Size = new System.Drawing.Size(156, 23);
            this.txtKPD.TabIndex = 8;
            // 
            // errReceiverBill
            // 
            this.errReceiverBill.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errReceiverBill.ContainerControl = this;
            // 
            // errSenderKO
            // 
            this.errSenderKO.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errSenderKO.ContainerControl = this;
            // 
            // errReceiverKO
            // 
            this.errReceiverKO.ContainerControl = this;
            // 
            // errSenderBIK
            // 
            this.errSenderBIK.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errSenderBIK.ContainerControl = this;
            // 
            // errReceiverBIK
            // 
            this.errReceiverBIK.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errReceiverBIK.ContainerControl = this;
            // 
            // errRDDate
            // 
            this.errRDDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errRDDate.ContainerControl = this;
            // 
            // errRDNum
            // 
            this.errRDNum.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errRDNum.ContainerControl = this;
            // 
            // dtpOffDate
            // 
            this.dtpOffDate.Checked = false;
            this.dtpOffDate.CustomFormat = "dd/MM/yyyy";
            this.dtpOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOffDate.Location = new System.Drawing.Point(143, 232);
            this.dtpOffDate.Name = "dtpOffDate";
            this.dtpOffDate.ShowCheckBox = true;
            this.dtpOffDate.Size = new System.Drawing.Size(156, 23);
            this.dtpOffDate.TabIndex = 6;
            this.dtpOffDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpOffDate_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Списано со счета";
            // 
            // errOffDate
            // 
            this.errOffDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errOffDate.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt110);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.txt109);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.txt108);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.txt107);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.txt106);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.txt105);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txt104);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txt101);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Location = new System.Drawing.Point(974, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 408);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // txt110
            // 
            this.txt110.Location = new System.Drawing.Point(49, 350);
            this.txt110.Mask = "aa";
            this.txt110.Name = "txt110";
            this.txt110.Size = new System.Drawing.Size(172, 23);
            this.txt110.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(11, 353);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 17);
            this.label32.TabIndex = 4;
            this.label32.Text = "110";
            // 
            // txt109
            // 
            this.txt109.Location = new System.Drawing.Point(49, 306);
            this.txt109.Mask = "aaaaaaaaaa";
            this.txt109.Name = "txt109";
            this.txt109.Size = new System.Drawing.Size(172, 23);
            this.txt109.TabIndex = 6;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(11, 309);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 17);
            this.label31.TabIndex = 4;
            this.label31.Text = "109";
            // 
            // txt108
            // 
            this.txt108.Location = new System.Drawing.Point(49, 262);
            this.txt108.Mask = "aaaaaaaaaaaaaaa";
            this.txt108.Name = "txt108";
            this.txt108.Size = new System.Drawing.Size(172, 23);
            this.txt108.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 265);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 17);
            this.label30.TabIndex = 4;
            this.label30.Text = "108";
            // 
            // txt107
            // 
            this.txt107.Location = new System.Drawing.Point(49, 218);
            this.txt107.Mask = "aaaaaaaaaa";
            this.txt107.Name = "txt107";
            this.txt107.Size = new System.Drawing.Size(172, 23);
            this.txt107.TabIndex = 4;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 221);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 17);
            this.label29.TabIndex = 4;
            this.label29.Text = "107";
            // 
            // txt106
            // 
            this.txt106.Location = new System.Drawing.Point(49, 174);
            this.txt106.Mask = "aa";
            this.txt106.Name = "txt106";
            this.txt106.Size = new System.Drawing.Size(172, 23);
            this.txt106.TabIndex = 3;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(11, 177);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 17);
            this.label28.TabIndex = 4;
            this.label28.Text = "106";
            // 
            // txt105
            // 
            this.txt105.Location = new System.Drawing.Point(49, 130);
            this.txt105.Mask = "99999999999";
            this.txt105.Name = "txt105";
            this.txt105.Size = new System.Drawing.Size(172, 23);
            this.txt105.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 133);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 17);
            this.label27.TabIndex = 4;
            this.label27.Text = "105";
            // 
            // txt104
            // 
            this.txt104.Location = new System.Drawing.Point(49, 86);
            this.txt104.Mask = "99999999999999999999";
            this.txt104.Name = "txt104";
            this.txt104.Size = new System.Drawing.Size(172, 23);
            this.txt104.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 89);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 17);
            this.label26.TabIndex = 2;
            this.label26.Text = "104";
            // 
            // txt101
            // 
            this.txt101.Location = new System.Drawing.Point(49, 42);
            this.txt101.Mask = "99";
            this.txt101.Name = "txt101";
            this.txt101.Size = new System.Drawing.Size(43, 23);
            this.txt101.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 17);
            this.label25.TabIndex = 0;
            this.label25.Text = "101";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(16, 384);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(149, 17);
            this.label33.TabIndex = 25;
            this.label33.Text = "Назначение платежа";
            // 
            // txtPaymentGoal
            // 
            this.txtPaymentGoal.Location = new System.Drawing.Point(19, 405);
            this.txtPaymentGoal.Multiline = true;
            this.txtPaymentGoal.Name = "txtPaymentGoal";
            this.txtPaymentGoal.Size = new System.Drawing.Size(280, 50);
            this.txtPaymentGoal.TabIndex = 10;
            this.txtPaymentGoal.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaymentGoal_Validating);
            // 
            // errSenderName
            // 
            this.errSenderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errSenderName.ContainerControl = this;
            // 
            // errReceiverName
            // 
            this.errReceiverName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errReceiverName.ContainerControl = this;
            // 
            // errPaymentGoal
            // 
            this.errPaymentGoal.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPaymentGoal.ContainerControl = this;
            // 
            // AvisoTeleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1269, 503);
            this.Controls.Add(this.txtPaymentGoal);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtpOffDate);
            this.Controls.Add(this.txtKPD);
            this.Controls.Add(this.dtpKPDDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRDSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpRDDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRDNum);
            this.Controls.Add(this.cbOperationType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbItemType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AvisoTeleEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление/Редактирование телеграфного авизо";
            this.Load += new System.EventHandler(this.AvisoTeleEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errOperType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAvisoNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSenderBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errReceiverBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSenderKO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errReceiverKO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSenderBIK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errReceiverBIK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRDDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOffDate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSenderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errReceiverName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentGoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOperationType;
        private System.Windows.Forms.MaskedTextBox txtRDNum;
        private System.Windows.Forms.ErrorProvider errOperType;
        private System.Windows.Forms.ErrorProvider errAvisoNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRDDate;
        private System.Windows.Forms.ErrorProvider errPaymentType;
        private System.Windows.Forms.ErrorProvider errSenderBill;
        private System.Windows.Forms.MaskedTextBox txtRDSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSenderBIK;
        private System.Windows.Forms.Button btnReceiverSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbReceiverKO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbReceiverBIK;
        private System.Windows.Forms.Button btnSenderSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSenderKO;
        private System.Windows.Forms.DateTimePicker dtpKPDDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtReceiverBill;
        private System.Windows.Forms.MaskedTextBox txtSenderBill;
        private System.Windows.Forms.MaskedTextBox txtKPD;
        private ErrorProvider errReceiverBill;
        private ErrorProvider errSenderKO;
        private ErrorProvider errReceiverKO;
        private ErrorProvider errSenderBIK;
        private ErrorProvider errReceiverBIK;
        private ErrorProvider errRDDate;
        private ErrorProvider errRDNum;
        private Label label16;
        private DateTimePicker dtpOffDate;
        private ErrorProvider errOffDate;
        private MaskedTextBox txtSenderKPP;
        private Label label18;
        private MaskedTextBox txtSenderINN;
        private Label label17;
        private TextBox txtSenderName;
        private Label label19;
        private TextBox txtSenderKOName;
        private Label label20;
        private TextBox txtReceiverKOName;
        private Label label24;
        private MaskedTextBox txtReceiverINN;
        private Label label23;
        private TextBox txtReceiverName;
        private Label label22;
        private MaskedTextBox txtReceiverKPP;
        private Label label21;
        private GroupBox groupBox3;
        private MaskedTextBox txt110;
        private Label label32;
        private MaskedTextBox txt109;
        private Label label31;
        private MaskedTextBox txt108;
        private Label label30;
        private MaskedTextBox txt107;
        private Label label29;
        private MaskedTextBox txt106;
        private Label label28;
        private MaskedTextBox txt105;
        private Label label27;
        private MaskedTextBox txt104;
        private Label label26;
        private MaskedTextBox txt101;
        private Label label25;
        private TextBox txtPaymentGoal;
        private Label label33;
        private ErrorProvider errSenderName;
        private ErrorProvider errReceiverName;
        private ErrorProvider errPaymentGoal;
    }
}