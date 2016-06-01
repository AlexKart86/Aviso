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

        //Настройка биндингов 
        private void InitBindList()
        {


            cbSenderBIK.DataBindings.Add("Text", bs_main, "SENDER_BIK");
            cbSenderKO.DataBindings.Add("Text", bs_main, "SENDER_KO");
            txtSenderBill.DataBindings.Add("Text", bs_main, "SENDER_BILL");

            cbReceiverBIK.DataBindings.Add("Text", bs_main, "RECEIVER_BIK");
            cbReceiverKO.DataBindings.Add("Text", bs_main, "RECEIVER_KO");
            txtReceiverBill.DataBindings.Add("Text", bs_main, "RECEIVER_BILL");

            cbReceiverKO.DataSource = LookupList.GetNewLookupBS("KSNP is not null");
            cbReceiverKO.ValueMember = "KSNP";
            cbReceiverKO.DisplayMember = "KSNP";

            cbReceiverBIK.DataSource = LookupList.GetNewLookupBS();
            cbReceiverBIK.ValueMember = "NEWNUM";
            cbReceiverBIK.DisplayMember = "NEWNUM";


            cbSenderBIK.DataSource = LookupList.GetNewLookupBS();
            cbSenderBIK.ValueMember = "NEWNUM";
            cbSenderBIK.DisplayMember = "NEWNUM";

            cbSenderKO.DataSource = LookupList.GetNewLookupBS("KSNP is not null");
            cbSenderKO.ValueMember = "KSNP";
            cbSenderKO.DisplayMember = "KSNP";

           /* LookupList.FillComboBox(cbReceiverKO, "KSNP");
            LookupList.FillComboBox(cbReceiverBIK, "NEWNUM");
            LookupList.FillComboBox(cbSenderKO, "KSNP");
            LookupList.FillComboBox(cbSenderBIK, "NEWNUM");*/

            txtNum.DataBindings.Add("Text", bs_main, "NUM", false);

            Binding b_CreateDate = new Binding("Value", bs_main, "CREATE_DATE", true);
            dtpCreatedDate.DataBindings.Add(b_CreateDate);
            b_CreateDate.Format += new ConvertEventHandler(CommonUtils.dtpPicker_Format);
            b_CreateDate.Parse += new ConvertEventHandler(CommonUtils.dtpPicker_Parse);

            cbItemType.DataBindings.Add("Text", bs_main, "PAYMENT_TYPE");
            cbOperationType.DataBindings.Add("Text", bs_main, "OPERATION_TYPE");
            txtRDNum.DataBindings.Add("Text", bs_main, "RD_NUM");

            Binding b_RDDate = new Binding("Value", bs_main, "RD_DATE", true);            
            b_RDDate.Format += new ConvertEventHandler(CommonUtils.dtpPicker_Format);
            b_RDDate.Parse += new ConvertEventHandler(CommonUtils.dtpPicker_Parse);
            dtpRDDate.DataBindings.Add(b_RDDate);            

            txtRDSum.DataBindings.Add("Text", bs_main, "RD_SUM");
            txtKPD.DataBindings.Add("Text", bs_main, "KPD");

            Binding b_KPDDate = new Binding("Value", bs_main, "KPD_DATE", true);
            dtpKPDDate.DataBindings.Add(b_KPDDate);
            b_KPDDate.Format += new ConvertEventHandler(CommonUtils.dtpPicker_Format);
            b_KPDDate.Parse += new ConvertEventHandler(CommonUtils.dtpPicker_Parse);   
        }

        public AvisoPostEdit(BindingSource bs_main)
        {            
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

        private bool IsFieldNull(string field_name)
        {
            DataRowView row = (DataRowView)bs_main.Current;
            if (Convert.ToString(row[field_name]) == "")
                return true;
            else
                return false;                
        }

        private void AvisoPostEdit_Load(object sender, EventArgs e)
        {
            dtpRDDate.Checked = !IsFieldNull("RD_DATE");
            dtpCreatedDate.Checked = !IsFieldNull("CREATE_DATE");
            dtpKPDDate.Checked = !IsFieldNull("KPD_DATE");
            DtpRefreshFormat(dtpRDDate);
            DtpRefreshFormat(dtpKPDDate);
            DtpRefreshFormat(dtpCreatedDate);            
        }

        private void cbItemType_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = CommonUtils.CheckRequiredField((Control)sender, errPaymentType);
        }

        private void AllowDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bs_main.Current;
            if (Convert.ToString(row["RD_DATE"]) == "")
                MessageBox.Show("NULL!");
            else
                MessageBox.Show("Not Null");
        }

        private void DtpRefreshFormat(DateTimePicker dtp)
        {
            dtp.CustomFormat = dtp.Checked ? "dd/MM/yyyy" : " ";
        }

        private void dtpRDDate_ValueChanged(object sender, EventArgs e)
        {
            DtpRefreshFormat((DateTimePicker)sender);
        }


        private void btnSenderSearch_Click(object sender, EventArgs e)
        {
            SelectBank frm = new SelectBank();
            LookupList.lookupBs.Position =  LookupList.lookupBs.Find("NEWNUM", cbSenderBIK.Text);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRowView row = (DataRowView)LookupList.lookupBs.Current;
                cbSenderBIK.Text = Convert.ToString(row["NEWNUM"]);
                cbSenderKO.Text = Convert.ToString(row["KSNP"]);
            }
        }

        private void btnReceiverSearch_Click(object sender, EventArgs e)
        {
            SelectBank frm = new SelectBank();
            LookupList.lookupBs.Position = LookupList.lookupBs.Find("NEWNUM", cbReceiverBIK.Text);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRowView row = (DataRowView)LookupList.lookupBs.Current;
                cbReceiverBIK.Text = Convert.ToString(row["NEWNUM"]);
                cbReceiverKO.Text = Convert.ToString(row["KSNP"]);
            }
        }

        private void txtSenderBill_Validating(object sender, CancelEventArgs e)
        {
            //Поле "Номер лицевого счета отправителя" должно быть
            //Заполненным, если пусто поле "КО отправителя"
            if (String.IsNullOrEmpty(cbSenderKO.Text) && String.IsNullOrEmpty(txtSenderBill.Text))
            {
                e.Cancel = true;
                errSenderBill.SetError(txtSenderBill, "Данное поле должно быть заполненным,\r\n поскольку поле \"Корсчет КО плательщика\" не заполнено");
            }
            else
                errSenderBill.SetError(txtSenderBill, "");
        }

        private void txtReceiverBill_Validating(object sender, CancelEventArgs e)
        {
            //Поле "Номер лицевого счета получателя" должно быть
            //Заполненным, если пусто поле "КО получателя"
            if (String.IsNullOrEmpty(cbReceiverKO.Text) && String.IsNullOrEmpty(txtReceiverBill.Text))
            {
                e.Cancel = true;
                errReceiverBill.SetError(txtReceiverBill, "Данное поле должно быть заполненным, \r\n поскольку поле \"Корсчет КО получателя\" не заполнено");
            }
            else
                errReceiverBill.SetError(txtReceiverBill, "");
        }

        //Автоподстановка КО при выборе БИК банка
        private void cbReceiverBIK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbReceiverKO.Text = LookupList.LookupNewNum(cbReceiverBIK.Text, "KSNP");
        }
        

        private void cbSenderBIK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSenderKO.Text = LookupList.LookupNewNum(cbSenderBIK.Text, "KSNP");
        }

        private void cbSenderKO_Validating(object sender, CancelEventArgs e)
        {
            //Если БИК и КО оба заполнены, то они должны соответствовать друг другу
            if (!string.IsNullOrEmpty(cbSenderBIK.Text) && !string.IsNullOrEmpty(cbSenderKO.Text)
                 && LookupList.LookupNewNum(cbSenderBIK.Text, "KSNP") != cbSenderKO.Text)
            {
                e.Cancel = true;
                errSenderKO.SetError(cbSenderKO, "КО плательщика не соответсвтвует БИК плательщика");
            }
            else
                errSenderKO.SetError(cbSenderKO, "");
        }

        private void cbReceiverKO_Validating(object sender, CancelEventArgs e)
        {
            //Если БИК и КО оба заполнены, то они должны соответствовать друг другу
            if (!string.IsNullOrEmpty(cbReceiverBIK.Text) && !string.IsNullOrEmpty(cbReceiverKO.Text)
                 && LookupList.LookupNewNum(cbReceiverBIK.Text, "KSNP") != cbReceiverKO.Text)
            {
                e.Cancel = true;
                errReceiverKO.SetError(cbReceiverKO, "КО получателя не соответсвтвует БИК получателя");
            }
            else
                errReceiverKO.SetError(cbReceiverKO, "");
        }
    }
}
