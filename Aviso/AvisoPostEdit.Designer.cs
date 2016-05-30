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
            this.button3 = new System.Windows.Forms.Button();
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errOperType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAvisoNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер авизо";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDate.Location = new System.Drawing.Point(143, 48);
            this.dtpCreatedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(156, 23);
            this.dtpCreatedDate.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 482);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(143, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Отменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
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
            this.cbItemType.Location = new System.Drawing.Point(143, 81);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(156, 24);
            this.cbItemType.TabIndex = 8;
            this.cbItemType.Validating += new System.ComponentModel.CancelEventHandler(this.cbItemType_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вид платежа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 117);
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
            this.cbOperationType.Location = new System.Drawing.Point(143, 115);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(156, 24);
            this.cbOperationType.TabIndex = 11;
            this.cbOperationType.Validating += new System.ComponentModel.CancelEventHandler(this.OperType_Validating);
            // 
            // txtRDNum
            // 
            this.txtRDNum.Location = new System.Drawing.Point(143, 155);
            this.txtRDNum.Mask = "999999";
            this.txtRDNum.Name = "txtRDNum";
            this.txtRDNum.PromptChar = '0';
            this.txtRDNum.Size = new System.Drawing.Size(156, 23);
            this.txtRDNum.TabIndex = 12;
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
            this.label5.Location = new System.Drawing.Point(21, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Номер РД";
            // 
            // dtpRDDate
            // 
            this.dtpRDDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRDDate.Location = new System.Drawing.Point(143, 190);
            this.dtpRDDate.Name = "dtpRDDate";
            this.dtpRDDate.Size = new System.Drawing.Size(156, 23);
            this.dtpRDDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 193);
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(143, 232);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(156, 23);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // AvisoPostEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(961, 522);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpRDDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRDNum);
            this.Controls.Add(this.cbOperationType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbItemType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AvisoPostEdit";
            this.Text = "Добавление/Редактирование почтового авизо";
            this.Load += new System.EventHandler(this.AvisoPostEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errOperType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAvisoNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}