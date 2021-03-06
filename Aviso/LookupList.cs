﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviso
{
    public static class LookupList
    {
        //Компоненты для данных подстановки
        public static readonly OleDbDataAdapter lookupAdapter;
        public static readonly DataSet lookupDataSet;
        public static readonly BindingSource lookupBs;

        public static BindingSource GetNewLookupBS(string filter = "")
        {
            BindingSource bs = new BindingSource(lookupDataSet, lookupDataSet.Tables[0].TableName);
            bs.DataSource = lookupDataSet;
            if (!String.IsNullOrEmpty(filter))
                bs.Filter = filter;

            return bs;
        }

        public static string DecodeTNP(string tnp)
        {
            switch (tnp)
            {
                case "1":
                    return "г.";                    
                case "2":
                    return "п.";                    
                case "3":
                    return "с.";                    
                case "4":
                    return "пгт.";                    
                case "5":
                    return "ст-ца";                    
                default:
                    return "";
            }
        }

        static LookupList()
        {
            string constr = ConfigurationManager.ConnectionStrings["Dictionary"].ConnectionString;            
            string path = CommonUtils.GetCurrentDir();
            constr = constr.Replace("|DataDirectory|", path);
            OleDbConnection con = new OleDbConnection(constr);
            string sql = "select * from BNKSEEK.DBF";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            con.Open();
            lookupDataSet = new DataSet();
            lookupAdapter = new OleDbDataAdapter(cmd);
            lookupAdapter.Fill(lookupDataSet);
            con.Close();
            lookupBs = new BindingSource(lookupDataSet, lookupDataSet.Tables[0].TableName);            
        }

        //Ищет в лукапном списке строку, для которой newnum = первый параметр
        //И возвращает значение, записанное в поле resultFieldName
        public static string LookupNewNum(string newnum, string resultFieldName)
        {
            int pos = lookupBs.Find("NEWNUM", newnum);
            if (pos < 0)
                return "";
            else
            {
                lookupBs.Position = pos;
                DataRowView  row = (DataRowView) lookupBs.Current;
                return Convert.ToString(row[resultFieldName]);
            }            
        }

        //Заполня
        public static void FillComboBox(ComboBox cb, string field_name, bool IsAddEmpty = false )
        {
            cb.Items.Clear();            
            foreach (DataRow row in lookupDataSet.Tables[0].Rows)
            {
                if (IsAddEmpty || !string.IsNullOrEmpty(Convert.ToString(row[field_name])))
                    cb.Items.Add(Convert.ToString(row[field_name]));                    
            }
        }


    }
}
