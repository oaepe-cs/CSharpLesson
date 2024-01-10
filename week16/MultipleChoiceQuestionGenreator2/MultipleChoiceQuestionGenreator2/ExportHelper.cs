using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MultipleChoiceQuestionGenreator2
{
    public class ExportHelper
    {
        public static string ExportCsv(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                int rowCount = 1;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Export to CSV";
                sfd.Filter = "CSV Files |*.csv| Docs files|*.docx|All files|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            string headerName = dataGridView.Columns[i].HeaderText + ",";

                            sw.Write(headerName);
                        }
                        sw.WriteLine();

                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            if (dataGridView.Rows[i].Cells[0].Value != null)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    string value = dataGridView.Rows[i].Cells[j].Value.ToString();

                                    if (value.Contains(","))
                                    {
                                        value = "\"" + value.Replace("\"", "\"\"") + "\"" + ",";
                                    }
                                    else
                                    {
                                        value = value + ",";
                                    }
                                    sw.Write(value);
                                }
                            }
                            sw.WriteLine();
                            rowCount++;
                        }
                        sw.WriteLine();

                        return rowCount + " row(s) exported successfully!";
                    }
                }
            }
            return "No record executed.";
        }
    }
}
