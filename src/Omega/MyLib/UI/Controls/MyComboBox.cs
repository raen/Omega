using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Omega.MyLib.UI.Controls
{
    //TODO dodac inicjacje przez podanie enuma (zerznac z pracy)
    public class MyComboBox : ComboBox
    {

        public void Init(Enum enumList, Type enumType)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("value", typeof(System.Int32));
            dataTable.Columns.Add("text", typeof(String));

            EnumUtils.FillDataTableWithEnum(enumType, dataTable, "value", null, "text");


            //DataRow row;
    
            //TODO dbrac nazwe z description
            //Array values = System.Enum.GetValues(enumType);
            //Array names = System.Enum.GetNames(enumType);

            //for (int i = 0; i < names.Length; i++ )
            //{
            //    row = dataTable.NewRow();
            //    row["value"] = values.GetValue(i);
            //    row["text"] = names.GetValue(i);
            //    dataTable.Rows.Add(row);
            //}

            this.DisplayMember = "text";
            this.ValueMember = "value";
            this.DataSource = dataTable;
        }
    }
}
