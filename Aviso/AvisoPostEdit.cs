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
    public partial class AvisoPostEdit : Form
    {
        private BindingSource bs_main;
        private BindingSource bs_lookup;

        //Настройка биндингов 
        private void InitBindList()
        {
            txtNum.DataBindings.Add("Text", bs_main, "NUM", false);

            Binding b_CreateDate = new Binding("Value", bs_main, "CREATE_DATE", true);
            dtpCreatedDate.DataBindings.Add(b_CreateDate);
            b_CreateDate.Format += new ConvertEventHandler(CommonUtils.dtpPicker_Format);
            b_CreateDate.Parse += new ConvertEventHandler(CommonUtils.dtpPicker_Parse);

            cbItemType.DataBindings.Add("Text", bs_main, "PAYMENT_TYPE");
            cbOperationType.DataBindings.Add("Text", bs_main, "OPERATION_TYPE");
            txtRDNum.DataBindings.Add("Text", bs_main, "RD_NUM");

            Binding b_RDDate = new Binding("Value", bs_main, "RD_DATE", true);
            dtpRDDate.DataBindings.Add(b_RDDate);
            b_RDDate.Format += new ConvertEventHandler(CommonUtils.dtpPicker_Format);
            b_RDDate.Parse += new ConvertEventHandler(CommonUtils.dtpPicker_Parse);

            txtRDSum.DataBindings.Add("Text", bs_main, "RD_SUM");
            txtKPD.DataBindings.Add("Text", bs_main, "KPD");

            Binding b_KPDDate = new Binding("Value", bs_main, "KPD_DATE", true);
            dtpKPDDate.DataBindings.Add(b_KPDDate);
            b_KPDDate.Format += new ConvertEventHandler(CommonUtils.dtpPicker_Format);
            b_KPDDate.Parse += new ConvertEventHandler(CommonUtils.dtpPicker_Parse);

            cbSenderBIK.DataBindings.Add("Text", bs_main, "SENDER_BIK");
            cbSenderKO.DataBindings.Add("Text", bs_main, "SENDER_KO");
            txtSenderBill.DataBindings.Add("Text", bs_main, "SENDER_BILL");

            cbReceiverBIK.DataBindings.Add("Text", bs_main, "RECEIVER_BIK");
            cbReceiverKO.DataBindings.Add("Text", bs_main, "RECEIVER_KO");
            txtReceiverBill.DataBindings.Add("Text", bs_main, "RECEIVER_BILL");

            cbReceiverBIK.DataSource = bs_lookup;
            cbReceiverBIK.ValueMember = "NEWNUM";
            cbReceiverBIK.DisplayMember = "NEWNUM";

            cbReceiverKO.DataSource = bs_lookup;
            cbReceiverKO.ValueMember = "KSNP";
            cbReceiverKO.DisplayMember = "KSNP";

            cbSenderBIK.DataSource = bs_lookup;
            cbSenderBIK.ValueMember = "NEWNUM";
            cbSenderBIK.DisplayMember = "NEWNUM";

            cbReceiverKO.DataSource = bs_lookup;
            cbReceiverKO.ValueMember = "KSNP";
            cbReceiverKO.DisplayMember = "KSNP";
        }

        public AvisoPostEdit(BindingSource bs_main, BindingSource bs_lookup)
        {
            this.bs_lookup = bs_lookup;
            this.bs_main = bs_main;
            InitializeComponent();
            InitBindList();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            dtpCreatedDate.Value = System.DateTime.Today;                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void OperType_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = CommonUtils.CheckRequiredField((Control)sender, errOperType);
        }

        private void txtNum_Validating(object sender, CancelEventArgs e)
        {
                        
        }

        private void AvisoPostEdit_Load(object sender, EventArgs e)
        {

        }

        private void cbItemType_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = CommonUtils.CheckRequiredField((Control)sender, errPaymentType);
        }

        private void AllowDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbReceiverBIK_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbReceiverBIK_TextUpdate(object sender, EventArgs e)
        {
            
            cbReceiverKO.Text = cbReceiverBIK.Text;
        }
    }
}
