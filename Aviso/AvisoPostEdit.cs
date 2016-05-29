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
            Binding b = new Binding("Value", bs_main, "CREATE_DATE", true);
            dtpCreatedDate.DataBindings.Add(b);
            b.Format += new ConvertEventHandler(dtBirthdayNullable_Format);
            b.Parse += new ConvertEventHandler(dtBirthdayNullable_Parse);
            cbItemType.DataBindings.Add("Text", bs_main, "PAYMENT_TYPE");
        }

        public AvisoPostEdit(BindingSource bs_main, BindingSource bs_lookup)
        {
            this.bs_lookup = bs_lookup;
            this.bs_main = bs_main;
            InitializeComponent();
            InitBindList();
        }

        private void AvisoPostEdit_Load(object sender, EventArgs e)
        {

        }

        private void post_avisoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpCreatedDate.Value = System.DateTime.Today;                        
        }


        // OBJECT PROPERTY –> CONTROL VALUE     
        void dtBirthdayNullable_Format(object sender, ConvertEventArgs e)
        {

            // e.Value is the object value, we format it to be what we want to show up in the control 
            Binding b = sender as Binding;
            if (b != null)

            {

                DateTimePicker dtp = (b.Control as DateTimePicker);

                if (dtp != null)

                {

                    if (e.Value == System.DBNull.Value)

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

// CONTROL VALUE –> OBJECT PROPERTY 
void dtBirthdayNullable_Parse( object sender, ConvertEventArgs e)
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

        private void AvisoPostEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ValidateChildren();
        }
    }
}
