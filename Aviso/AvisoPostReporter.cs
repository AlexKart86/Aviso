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
    public static class AvisoPostReporter
    {
        public static bool PrintCurrent(BindingSource bs, string result_file)
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
            lst.Add(new Tuple<string, string>("RECEIVER_KO", Convert.ToString(row["RECEIVER_KO"])));

            string template_name;
            template_name = CommonUtils.GetCurrentDir() + @"\credit_post_aviso.docx";

            return ReportOutput.CreateReport(template_name, result_file, lst);
        }
    }
}
