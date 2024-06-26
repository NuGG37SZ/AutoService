﻿using System;
using System.Windows.Forms;

namespace AutoService.Classes
{
    public class ExportExcelDataGridView
    {
        public static void ExportExcel(DataGridView grid)
        {
            if (grid == null || grid.Rows.Count <= 0)
            {
                MessageBox.Show("Данные для экспорта не обнаружены.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < grid.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = grid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    for (int j = 0; j < grid.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = grid.Rows[i].Cells[j].Value.ToString();
                    }
                }

                excel.Range[excel.Cells[1, 1], excel.Cells[1, grid.Columns.Count]].Interior.Color = System.Drawing.Color.Transparent;
                excel.Range[excel.Cells[1, 1], excel.Cells[grid.Rows.Count + 1, grid.Columns.Count]].Borders.LineStyle = 
                    Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                excel.Columns.AutoFit();
                excel.Visible = true;
                excel = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

