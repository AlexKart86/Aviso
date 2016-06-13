using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Общие функции, используемые в нескольких формах
namespace Aviso
{
    public  static class CommonUtils
    {

        public static string GetCurrentDir()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return (System.IO.Path.GetDirectoryName(executable));
        }

        public static bool CheckRequiredField(Control sender, ErrorProvider err)
        {
            if (String.IsNullOrEmpty(sender.Text))
            {
                err.SetError(sender, "Данное поле должно быть заполненным");
                return true;
            }
            else
            {
                err.SetError(sender, String.Empty);
                return false;
            }
        }

        //Функция, позволяющая корректно отображать пустую дату из БД     
        public static void dtpPicker_Format(object sender, ConvertEventArgs e)
        {

            // e.Value is the object value, we format it to be what we want to show up in the control 
            Binding b = sender as Binding;
            if (b != null)
            {
                DateTimePicker dtp = (b.Control as DateTimePicker);
                if (dtp != null)
                {
                    if (e.Value == System.DBNull.Value || e.Value == null)
                      {
                            dtp.ShowCheckBox = true;
                            dtp.Checked = false;
                            // have to set e.Value to SOMETHING, since it’s coming in as NULL 
                            // if i set to DateTime.Today, and that’s DIFFERENT than the control’s current  
                            // value, then it triggers a CHANGE to the value, which CHECKS the box (not ok) 
                            // the trick – set e.Value to whatever value the control currently has.   
                            // This does NOT cause a CHANGE, and the checkbox stays OFF. 
                            e.Value = dtp.Value;
                    }
                      else
                      {
                          dtp.ShowCheckBox = true;
                          dtp.Checked = true;
                          // leave e.Value unchanged – it’s not null, so the DTP is fine with it. 
                      }
                }
            }
        }

        // Функция, позволяющая корректно передать пустую дату из DateTimePicker в БД 
        public static void dtpPicker_Parse(object sender, ConvertEventArgs e)
        {
            // e.value is the formatted value coming from the control.   
            // we change it to be the value we want to stuff in the object. 
            Binding b = sender as Binding;
            if (b != null)
            {
                DateTimePicker dtp = (b.Control as DateTimePicker);
                if (dtp != null)
                {
                    if (dtp.Checked == false)
                     {
                         dtp.ShowCheckBox = true;
                         dtp.Checked = false;
                        //e.Value = new Nullable<DateTime>();
                        e.Value = DBNull.Value;

                     }
                     else
                     {
                         DateTime val = Convert.ToDateTime(e.Value).Date;
                         e.Value = new Nullable<DateTime>(val);
                     }                    
                }
            }
        }

        public static string FormatDate(DateTime t)
        {
            return t.ToString("dd'/'MM'/'yyyy");
        }

        //Проверяет, является ли флоат переменная целочисенной 
        public static bool IsInteger(double number)
        {
            return number == Math.Truncate(number);
        }

        public static void PrepareSum(object RD_SUM, out string summ, out string summ_kop)
        {
            double summ_f = Convert.ToDouble(RD_SUM);
            summ = Convert.ToString(RD_SUM);

            summ_kop = "";
            //Определяем, является ли сумма целочисленной
            //Чтоб знать, дописывать копейки или нет             
            if (!IsInteger(summ_f))
            {
                summ_kop = "КОПЕЕК";
                //Оставляем только цифры в сумме, увеличивая ее в 100 раз                 
                summ = Math.Truncate(summ_f * 100).ToString();
            }
        }



        //Функция, позволяющая корректно отображать число с копейками из БД     
        public static void rdSum_Format(object sender, ConvertEventArgs e)
        {            
            if (e.Value != System.DBNull.Value && e.Value != null && !string.IsNullOrEmpty(Convert.ToString(e.Value)))
                 e.Value = Convert.ToDouble(e.Value).ToString("########0.00");
        }

        public static void rdSum_Parse(object sender, ConvertEventArgs e)
        {
            if (e.Value != System.DBNull.Value && e.Value != null && !string.IsNullOrEmpty(Convert.ToString(e.Value)))
            {
                double d = double.Parse(Convert.ToString(e.Value));
                d = Math.Round(d, 2);
                e.Value = d;
            }
        }

    }
}
