﻿using System;
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
    public partial class AvisoTeleEdit : Form
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

            Binding b_RDSum = new Binding("Text", bs_main, "RD_SUM", true);
            b_RDSum.Format += new ConvertEventHandler(CommonUtils.rdSum_Format);
            b_RDSum.Parse += new ConvertEventHandler(CommonUtils.rdSum_Parse);
            txtRDSum.DataBindings.Add(b_RDSum);

            txtKPD.DataBindings.Add("Text", bs_main, "KPD");

            Binding b_KPDDate = new Binding("Value", bs_main, "KPD_DATE", true);
            dtpKPDDate.DataBindings.Add(b_KPDDate);
            b_KPDDate.Format += new ConvertEventHandler(CommonUtils.dtpPicker_Format);
            b_KPDDate.Parse += new ConvertEventHandler(CommonUtils.dtpPicker_Parse);

            Binding b_offDate = new Binding("Value", bs_main, "OFF_DATE", true);
            dtpOffDate.DataBindings.Add(b_offDate);
            b_offDate.Format += new ConvertEventHandler(CommonUtils.dtpPicker_Format);
            b_offDate.Parse += new ConvertEventHandler(CommonUtils.dtpPicker_Parse);

            txtSenderINN.DataBindings.Add("Text", bs_main, "SENDER_INN");
            txtSenderKPP.DataBindings.Add("Text", bs_main, "SENDER_KPP");
            txtSenderName.DataBindings.Add("Text", bs_main, "SENDER_NAME");
            txtSenderKOName.DataBindings.Add("Text", bs_main, "SENDER_KO_NAME");

            txtReceiverINN.DataBindings.Add("Text", bs_main, "RECEIVER_INN");
            txtReceiverKPP.DataBindings.Add("Text", bs_main, "RECEIVER_KPP");
            txtReceiverName.DataBindings.Add("Text", bs_main, "RECEIVER_NAME");
            txtReceiverKOName.DataBindings.Add("Text", bs_main, "RECEIVER_KO_NAME");

            txtPaymentGoal.DataBindings.Add("Text", bs_main, "PAYMENT_GOAL");

            txt101.DataBindings.Add("Text", bs_main, "N101");
            txt104.DataBindings.Add("Text", bs_main, "N104");
            txt105.DataBindings.Add("Text", bs_main, "N105");
            txt106.DataBindings.Add("Text", bs_main, "N106");
            txt107.DataBindings.Add("Text", bs_main, "N107");
            txt108.DataBindings.Add("Text", bs_main, "N108");
            txt109.DataBindings.Add("Text", bs_main, "N109");
            txt110.DataBindings.Add("Text", bs_main, "N110");
        }

        public AvisoTeleEdit(BindingSource bs_main)
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

        private void AvisoTeleEdit_Load(object sender, EventArgs e)
        {
            dtpRDDate.Checked = !IsFieldNull("RD_DATE");
            dtpCreatedDate.Checked = !IsFieldNull("CREATE_DATE");
            dtpKPDDate.Checked = !IsFieldNull("KPD_DATE");
            dtpOffDate.Checked = !IsFieldNull("OFF_DATE");
            DtpRefreshFormat(dtpRDDate);
            DtpRefreshFormat(dtpKPDDate);
            DtpRefreshFormat(dtpCreatedDate);
            DtpRefreshFormat(dtpOffDate);
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
            txtReceiverKOName.Text = LookupList.LookupNewNum(cbReceiverBIK.Text, "NAMEP");
        }
        

        private void cbSenderBIK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSenderKO.Text = LookupList.LookupNewNum(cbSenderBIK.Text, "KSNP");
            txtSenderKOName.Text = LookupList.LookupNewNum(cbSenderBIK.Text, "NAMEP");
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

        private void cbSenderBIK_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbSenderBIK.Text))
            {
                e.Cancel = true;
                errSenderBIK.SetError(cbSenderBIK, "Данное поле должно быть заполненным");
            }
            else if (string.IsNullOrEmpty(LookupList.LookupNewNum(cbSenderBIK.Text, "NEWNUM")))
            {
                e.Cancel = true;
                errSenderBIK.SetError(cbSenderBIK, "Введен несуществующий БИК");
            }
            else
                errSenderBIK.SetError(cbSenderBIK, "");
        }

        private void cbReceiverBIK_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbReceiverBIK.Text))
            {
                e.Cancel = true;
                errReceiverBIK.SetError(cbReceiverBIK, "Данное поле должно быть заполненным");
            }
            else if (string.IsNullOrEmpty(LookupList.LookupNewNum(cbReceiverBIK.Text, "NEWNUM")))
            {
                e.Cancel = true;
                errReceiverBIK.SetError(cbReceiverBIK, "Введен несуществующий БИК");
            }
            else
                errReceiverBIK.SetError(cbReceiverBIK, "");
        }

        private void dtpRDDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpRDDate.Checked && dtpRDDate.Value.Date > DateTime.Today)
            {
                e.Cancel = true;
                errRDDate.SetError(dtpRDDate, "Дата РД не может быть большей за текущую дату");
            }
            else
                errRDDate.SetError(dtpRDDate, "");
        }

        private void txtRDNum_Validating(object sender, CancelEventArgs e)
        {
            Int32 i;
            if (string.IsNullOrEmpty(txtRDNum.Text))
            {
                e.Cancel = true;
                errRDNum.SetError(txtRDNum, "Данное поле должно быть заполненным");
            }
            else if (!Int32.TryParse(txtRDNum.Text, out i) || i <= 0)
            {
                e.Cancel = true;
                errRDNum.SetError(txtRDNum, "В данное поле не может быть занесено нулевое значение");
            }
            else
                errRDNum.SetError(txtRDNum, "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dtpOffDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpOffDate.Checked && dtpOffDate.Value.Date > DateTime.Today)
            {
                e.Cancel = true;
                errOffDate.SetError(dtpOffDate, "Дата списания со счета не может быть большей за текущую дату");
            }
            else
                errOffDate.SetError(dtpOffDate, "");
        }

        private void txtSenderName_Validating(object sender, CancelEventArgs e)
        {
           e.Cancel =  CommonUtils.CheckRequiredField((Control)sender, errSenderName);
        }

        private void txtReceiverName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = CommonUtils.CheckRequiredField((Control)sender, errReceiverName);
        }

        private void txtPaymentGoal_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = CommonUtils.CheckRequiredField((Control)sender, errPaymentGoal);
        }

        private void txtNum_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum.Text))
            {
                e.Cancel = true;
                errAvisoNum.SetError(txtNum, "Данное поле должно быть заполненным");
            }
            else if (txtNum.Text.Length != 3)
            {
                e.Cancel = true;
                errAvisoNum.SetError(txtNum, "Номер авизо должен состоять из трех цифр");
            }
            else
                errAvisoNum.SetError(txtNum, "");
        }

        private void txtRDSum_Validating(object sender, CancelEventArgs e)
        {
            double val;
            if (!string.IsNullOrEmpty(txtRDSum.Text) && !CommonUtils.SafeConvertToString(txtRDSum.Text, out val))
            {
                e.Cancel = true;
                errRDSum.SetError(txtRDSum, "В данное поле внесено некорректная сумма");
            }
            else
                errRDSum.SetError(txtRDSum, "");
        }
    }
}

