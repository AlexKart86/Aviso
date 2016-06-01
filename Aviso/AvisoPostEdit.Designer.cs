using System.Windows.Forms;

namespace Aviso
{
    partial class AvisoPostEdit
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
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRDSum = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenderBill = new System.Windows.Forms.MaskedTextBox();
            this.btnSenderSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSenderKO = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSenderBIK = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.errOperType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAvisoNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(24, 346);
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
            this.btnCancel.Location = new System.Drawing.Point(143, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // txtRDSum
            // 
            this.txtRDSum.Location = new System.Drawing.Point(143, 227);
            this.txtRDSum.Name = "txtRDSum";
            this.txtRDSum.PromptChar = ' ';
            this.txtRDSum.Size = new System.Drawing.Size(156, 23);
            this.txtRDSum.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Сумма РД";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenderBill);
            this.groupBox1.Controls.Add(this.btnSenderSearch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbSenderKO);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbSenderBIK);
            this.groupBox1.Location = new System.Drawing.Point(325, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 240);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Плательщик";
            // 
            // txtSenderBill
            // 
            this.txtSenderBill.Location = new System.Drawing.Point(17, 155);
            this.txtSenderBill.Mask = "99999999999999999999";
            this.txtSenderBill.Name = "txtSenderBill";
            this.txtSenderBill.Size = new System.Drawing.Size(259, 23);
            this.txtSenderBill.TabIndex = 2;
            // 
            // btnSenderSearch
            // 
            this.btnSenderSearch.Location = new System.Drawing.Point(20, 199);
            this.btnSenderSearch.Name = "btnSenderSearch";
            this.btnSenderSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSenderSearch.TabIndex = 7;
            this.btnSenderSearch.TabStop = false;
            this.btnSenderSearch.Text = "Найти";
            this.btnSenderSearch.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Номер л/счета";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 77);
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
            this.cbSenderKO.Location = new System.Drawing.Point(17, 97);
            this.cbSenderKO.Name = "cbSenderKO";
            this.cbSenderKO.Size = new System.Drawing.Size(259, 24);
            this.cbSenderKO.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 25);
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
            this.cbSenderBIK.Location = new System.Drawing.Point(17, 45);
            this.cbSenderBIK.Name = "cbSenderBIK";
            this.cbSenderBIK.Size = new System.Drawing.Size(259, 24);
            this.cbSenderBIK.TabIndex = 0;
            this.cbSenderBIK.TextUpdate += new System.EventHandler(this.cbSenderBIK_TextUpdate);
            this.cbSenderBIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDigits_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceiverBill);
            this.groupBox2.Controls.Add(this.btnReceiverSearch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbReceiverKO);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbReceiverBIK);
            this.groupBox2.Location = new System.Drawing.Point(646, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 237);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Получатель";
            // 
            // txtReceiverBill
            // 
            this.txtReceiverBill.Location = new System.Drawing.Point(20, 152);
            this.txtReceiverBill.Mask = "99999999999999999999";
            this.txtReceiverBill.Name = "txtReceiverBill";
            this.txtReceiverBill.Size = new System.Drawing.Size(259, 23);
            this.txtReceiverBill.TabIndex = 2;
            // 
            // btnReceiverSearch
            // 
            this.btnReceiverSearch.Location = new System.Drawing.Point(23, 196);
            this.btnReceiverSearch.Name = "btnReceiverSearch";
            this.btnReceiverSearch.Size = new System.Drawing.Size(75, 28);
            this.btnReceiverSearch.TabIndex = 14;
            this.btnReceiverSearch.TabStop = false;
            this.btnReceiverSearch.Text = "Найти";
            this.btnReceiverSearch.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Номер л/счета";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 74);
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
            this.cbReceiverKO.Location = new System.Drawing.Point(20, 94);
            this.cbReceiverKO.Name = "cbReceiverKO";
            this.cbReceiverKO.Size = new System.Drawing.Size(259, 24);
            this.cbReceiverKO.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 22);
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
            this.cbReceiverBIK.Location = new System.Drawing.Point(20, 42);
            this.cbReceiverBIK.Name = "cbReceiverBIK";
            this.cbReceiverBIK.Size = new System.Drawing.Size(259, 24);
            this.cbReceiverBIK.TabIndex = 0;
            this.cbReceiverBIK.TextUpdate += new System.EventHandler(this.cbReceiverBIK_TextUpdate);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "КПД";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 298);
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
            this.dtpKPDDate.Location = new System.Drawing.Point(143, 297);
            this.dtpKPDDate.Name = "dtpKPDDate";
            this.dtpKPDDate.ShowCheckBox = true;
            this.dtpKPDDate.Size = new System.Drawing.Size(156, 23);
            this.dtpKPDDate.TabIndex = 8;
            this.dtpKPDDate.ValueChanged += new System.EventHandler(this.dtpRDDate_ValueChanged);
            // 
            // txtKPD
            // 
            this.txtKPD.Location = new System.Drawing.Point(143, 263);
            this.txtKPD.Mask = "99999 999";
            this.txtKPD.Name = "txtKPD";
            this.txtKPD.Size = new System.Drawing.Size(156, 23);
            this.txtKPD.TabIndex = 7;
            // 
            // AvisoPostEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(978, 396);
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
            this.Name = "AvisoPostEdit";
            this.Text = "Добавление/Редактирование почтового авизо";
            this.Load += new System.EventHandler(this.AvisoPostEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errOperType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAvisoNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ErrorProvider errorProvider2;
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
    }
}