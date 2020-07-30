using ClosedXML.Excel;

namespace VocabularyBook
{
    public class UpdateData
    {
        /// <summary>
        /// エクセルの印を更新する
        /// </summary>
        /// <param name="rowNumber">現在のrowNumber</param>
        /// <param name="checkBoxValue">チェックボックス数値</param>
        public static void UpdateShouldReview(int rowNumber, bool checkBoxValue, string filePath)
        {
            // エクセルを読み込む
            var workbook = new XLWorkbook(filePath);
            
            // 最初のワークシートを選択
            var workSheet = workbook.Worksheet(1);

            // 現在のrowを選択
            var row = workSheet.Row(rowNumber);

            // 印を更新する
            row.Cell("D").Value = checkBoxValue ? "1" : "0";

            // エクセルを保存する
            workbook.Save();
        }
    }
}
