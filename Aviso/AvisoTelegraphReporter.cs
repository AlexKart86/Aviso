using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviso
{
    class AvisoTelegraphReporter : AvisoReporter
    {
        public override bool PrintCurrent(BindingSource bs, string result_file)
        {
            DataRowView row = (DataRowView)bs.Current;
            List<Tuple<string, string>> lst = new List<Tuple<string, string>>();
            for (int idx=0; idx<row.Row.Table.Columns.Count - 1; ++idx)
            {
                string val;

                DataColumn col = row.Row.Table.Columns[idx];
                if (col.DataType == typeof(System.DateTime))
                {
                    DateTime dt = Convert.ToDateTime(row[idx]);
                    val = CommonUtils.FormatDate(dt);
                }
                else
                    val = Convert.ToString(row[idx]);
                if (!string.IsNullOrEmpty(val))
                {
                    val = "<" + val + ">";
                }
                lst.Add(new Tuple<string, string>(row.Row.Table.Columns[idx].ColumnName,
                        val));              
            }

            lst.Add(new Tuple<string, string>("RECEIVER_KO_NAME", Convert.ToString(row["RECEIVER_KO_NAME"])));

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

            /*string receiver_ko = Convert.ToString(row["RECEIVER_KO"]);
            if (string.IsNullOrEmpty(receiver_ko))
                receiver_ko = string.Format("{0:D20}", 0);

            lst.Add(new Tuple<string, string>("RECEIVER_KO", receiver_ko));
            lst.Add(new Tuple<string, string>("RECEIVER_BIK", Convert.ToString(row["RECEIVER_BIK"])));
            lst.Add(new Tuple<string, string>("RECEIVER_BILL", Convert.ToString(row["RECEIVER_BILL"])));*/

            string summ = Convert.ToString(row["RD_SUM"]);
            lst.Add(new Tuple<string, string>("SUMM", summ));

            string summ_kop = "";
            //Определяем, является ли сумма целочисленной
            int i;
            if (!Int32.TryParse(summ, out i))
            {                
                summ_kop = "КОПЕЕК";
                //Оставляем только цифры в сумме                  
                summ = new Regex(@"[^\d]+").Replace(summ, "");
            }
            lst.Add(new Tuple<string, string>("SUMM_KOP", summ_kop));
            lst.Add(new Tuple<string, string>("RD_NUM", Convert.ToString(row["RD_NUM"])));

            string is_inn_receiver = "";
            if (!string.IsNullOrEmpty(Convert.ToString(row["RECEIVER_INN"])))
                is_inn_receiver = "ИНН";
            lst.Add(new Tuple<string, string>("IS_INN_RECEIVER", is_inn_receiver));


            string is_kpp_receiver = "";
            if (!string.IsNullOrEmpty(Convert.ToString(row["RECEIVER_KPP"])))
                is_kpp_receiver = "КПП";
            lst.Add(new Tuple<string, string>("IS_KPP_RECEIVER", is_kpp_receiver));


            string is_inn_sender = "";
            if (!string.IsNullOrEmpty(Convert.ToString(row["SENDER_INN"])))
                is_inn_sender = "ИНН";
            lst.Add(new Tuple<string, string>("IS_INN_SENDER", is_inn_sender));


            string is_kpp_sender = "";
            if (!string.IsNullOrEmpty(Convert.ToString(row["SENDER_KPP"])))
                is_kpp_sender = "КПП";
            lst.Add(new Tuple<string, string>("IS_KPP_SENDER", is_kpp_sender));



            //Определяемся, какой из шаблонов нужен
            string template_name = "";
            string sender_bik = Convert.ToString(row["SENDER_BIK"]);
            if (sender_bik.Substring(0, 4) == "0475")
                template_name = CommonUtils.GetCurrentDir() + @"\Templates\credit_telegraph_aviso.docx";
            else
            {
                string receiver_bik = Convert.ToString(row["RECEIVER_BIK"]);
                if (receiver_bik.Substring(0, 4) == "0475")
                    template_name = CommonUtils.GetCurrentDir() + @"\Templates\debit_telegraph_aviso.docx";
            }
            if (!string.IsNullOrEmpty(template_name))
                return ReportOutput.CreateReport(template_name, result_file, lst);
            else
                return false;
        }

    }
}
