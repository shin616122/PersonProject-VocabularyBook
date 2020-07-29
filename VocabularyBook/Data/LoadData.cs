using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VocabularyBook
{
    public class LoadData
    {
        /// <summary>
        /// エクセルファイルからデータを読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static List<RowData> LoadDataFromExcel()
        {
            try
            {
                // Load Excel workbook from path
                var workbook = new XLWorkbook(@"D:\Personal\VocabularyBook\List.xlsx"); // TODO change path
                // Select all used rows on 1 sheet and skip first row
                var rows = workbook.Worksheet(1).RangeUsed().RowsUsed().Skip(1);

                // Make an empty RowData List
                var rowDataList = new List<RowData>();

                // Loop throught all rows and insert to model
                foreach (var row in rows)
                {
                    var rowData = new RowData
                    {
                        // TODO Read formula
                        RowNumber = row.RowNumber(),
                        Id = Convert.ToInt32(row.Cell("A").GetString()),
                        Question = row.Cell("B").GetString(),
                        Answer = row.Cell("C").GetString(),
                        ShouldReview = Convert.ToInt32(row.Cell("D").GetString())
                    };

                    // Add rowData to rowsList
                    rowDataList.Add(rowData);
                }
                return rowDataList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                throw ex;
            }
        }
    }

    /// <summary>
    /// エクセルから読み込んだモデル
    /// </summary>
    public class RowData
    {
        public int RowNumber { get; set; }
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int ShouldReview { get; set; }
    }

}