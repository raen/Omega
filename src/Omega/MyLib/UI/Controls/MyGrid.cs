using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace Omega.MyLib.UI.Controls
{
    public class MyGrid : DataGridView
    {
        public DataRow GetFocusedDataRow()
        {
            DataGridViewRow drgFocused = this.CurrentRow;
            if (drgFocused == null)
                return null;

            DataRowView drvFocused = (DataRowView)drgFocused.DataBoundItem;
            return drvFocused.Row;
        }

        public DataRow GetDataRowByRowIndex(int rowIndex)
        {
            if (rowIndex >= this.Rows.Count || rowIndex < 0)
                return null;

            if (this.Rows[rowIndex] == null)
                return null;

            DataGridViewRow dgvr = this.Rows[rowIndex];

            if (dgvr.DataBoundItem == null)
                return null;

            DataRowView drv = (DataRowView)dgvr.DataBoundItem;
            return drv.Row;
        }

        public DataRow ConvertDataGridVievRowToDataRow(DataGridViewRow dgvr)
        {
            DataRowView drv = (DataRowView)dgvr.DataBoundItem;
            return drv.Row;
        }

        public void InitColumnsAsInvisible(params DataColumn[] arrDataColumn)
        {
            foreach (DataColumn dataColumn in arrDataColumn)
                this.Columns[dataColumn.ColumnName].Visible = false;
        }
    }
}
