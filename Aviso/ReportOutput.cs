using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novacode;
using System.Windows.Forms;

//Класс для формирования отчета по шаблону 
//Заполняет поля пользователя в отчете и выводит его в другой файл
namespace Aviso
{
    public static class ReportOutput
    {
        public static bool CreateReport(string TemplateFileName, string OutputFileName, List<Tuple<string, string>> PropertyList)
        {
            DocX doc;
            try
            {
                doc = DocX.Load(TemplateFileName);
            }
            catch (Exception E)
            {
                MessageBox.Show("Ошибка при считывании шаблона отчета:\n\r" +
                      TemplateFileName + "\n\r" + 
                      E.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            foreach(Tuple<string, string> prop in PropertyList )
            {
                doc.ReplaceText("@" + prop.Item1 + "@", prop.Item2);
                // doc.AddCustomProperty(new CustomProperty(prop.Item1, prop.Item2));
            }
            try
            {
                doc.SaveAs(OutputFileName);
            }
            catch (Exception E)
            {
                MessageBox.Show("Ошибка при сохранении отчета:\n\r" +
                      TemplateFileName + "\n\r" +
                      E.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
    }
}
