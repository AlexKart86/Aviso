using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Класс для печати одного почтового авизо
namespace Aviso
{
    public class AvisoPostReporter: AvisoReporter
    {
        public override bool PrintCurrent(BindingSource bs, string result_file)
        {
            DataRowView row = (DataRowView) bs.Current;
            List<Tuple<string, string>> lst = new List<Tuple<string, string>>();

            //Формируем поле LONG_ADDRESS
            string rks = LookupList.LookupNewNum(Convert.ToString(row["RECEIVER_BIK"]), "RKC");
            string ind = LookupList.LookupNewNum(rks, "IND");
            string nnp = LookupList.LookupNewNum(rks, "NNP");
            string namen = LookupList.LookupNewNum(rks, "NAMEN");
            string tnp = LookupList.LookupNewNum(rks, "TNP");
            tnp = LookupList.DecodeTNP(tnp);

            string long_addr = ind + ", " + tnp + " " + nnp + ", " + namen;
            lst.Add(new Tuple<string, string>("LONG_ADDRESS", long_addr));
            lst.Add(new Tuple<string, string>("BIK_B", rks));

            string receiver_ko = Convert.ToString(row["RECEIVER_KO"]);
            if (receiver_ko == string.Format("{0:D20}", 0))
                receiver_ko = "";
            else if (string.IsNullOrEmpty(receiver_ko))
                receiver_ko = string.Format("{0:D20}", 0);
            
            lst.Add(new Tuple<string, string>("RECEIVER_KO", receiver_ko));

            lst.Add(new Tuple<string, string>("RECEIVER_BIK", Convert.ToString(row["RECEIVER_BIK"])));
            string receiver_bill = Convert.ToString(row["RECEIVER_BILL"]);
            if (receiver_bill == string.Format("{0:D20}", 0))
                receiver_bill = "";
            
            lst.Add(new Tuple<string, string>("RECEIVER_BILL", receiver_bill));

            string summ;
            string summ_kop;
            CommonUtils.PrepareSum(row["RD_SUM"], out summ, out summ_kop);

            lst.Add(new Tuple<string, string>("SUMM", summ));
            lst.Add(new Tuple<string, string>("SUMM_KOP", summ_kop));
            lst.Add(new Tuple<string, string>("RD_NUM", Convert.ToString(row["RD_NUM"])));

            DateTime rd_date = Convert.ToDateTime(row["RD_DATE"]);                       
            lst.Add(new Tuple<string, string>("RD_DATE", CommonUtils.FormatDate(rd_date)));
            DateTime aviso_date = Convert.ToDateTime(row["CREATE_DATE"]);
            lst.Add(new Tuple<string, string>("AVISO_DATE", CommonUtils.FormatDate(aviso_date)));
            DateTime kpd_date = Convert.ToDateTime(row["KPD_DATE"]);
            lst.Add(new Tuple<string, string>("KPD_DATE", CommonUtils.FormatDate(kpd_date)));

            string sender_ko = Convert.ToString(row["sender_KO"]);
            if (sender_ko == string.Format("{0:D20}", 0))
                sender_ko = "";
            else if (string.IsNullOrEmpty(sender_ko))
                sender_ko = string.Format("{0:D20}", 0);
            lst.Add(new Tuple<string, string>("SENDER_KO", sender_ko));
            lst.Add(new Tuple<string, string>("SENDER_BIK", Convert.ToString(row["SENDER_BIK"])));
            string sender_bill = Convert.ToString(row["SENDER_BILL"]);
            if (sender_bill == string.Format("{0:D20}", 0))
                sender_bill = "";
            lst.Add(new Tuple<string, string>("SENDER_BILL",sender_bill));

            lst.Add(new Tuple<string, string>("NUM", Convert.ToString(row["NUM"])));
            lst.Add(new Tuple<string, string>("KPD", Convert.ToString(row["KPD"])));

            //Определяемся, какой из шаблонов нужен
            string template_name = "";
            string sender_bik = Convert.ToString(row["SENDER_BIK"]);
            if (sender_bik.Substring(0,4) == "0475")            
               template_name = CommonUtils.GetCurrentDir() + @"\Templates\credit_post_aviso.docx";
            else
            {
                string receiver_bik = Convert.ToString(row["RECEIVER_BIK"]);
                if (receiver_bik.Substring(0,4) == "0475")
                    template_name = CommonUtils.GetCurrentDir() + @"\Templates\debit_post_aviso.docx";
            }
            if (!string.IsNullOrEmpty(template_name))
                return ReportOutput.CreateReport(template_name, result_file, lst);
            else
                return false;
        }
    }
}
