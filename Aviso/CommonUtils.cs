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
                         e.Value = new Nullable<DateTime>();
                     }
                     else
                     {
                         DateTime val = Convert.ToDateTime(e.Value).Date;
                         e.Value = new Nullable<DateTime>(val);
                     }                    
                }
            }
        }



    }
}
