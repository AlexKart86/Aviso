using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novacode;

//Класс для формирования отчета по шаблону 
//Заполняет поля пользователя в отчете и выводит его в другой файл
namespace Aviso
{
    public static class ReportOutput
    {
        public static bool CreateReport(string TemplateFileName, string OutputFileName, List<Tuple<string, string>> PropertyList)
        {
            DocX doc = DocX.Load(TemplateFileName);
            foreach(Tuple<string, string> prop in PropertyList )
            {
                doc.AddCustomProperty(new CustomProperty(prop.Item1, prop.Item2));
            }
            doc.SaveAs(OutputFileName);
            return true;
        }
    }
}
