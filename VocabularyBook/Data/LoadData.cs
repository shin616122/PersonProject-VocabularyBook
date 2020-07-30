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
        public static List<RowData> LoadDataFromExcel(string filePath, bool isReviewOnlyChcked)
        {
            try
            {
                // パスのエクセルを読み込む
                var workbook = new XLWorkbook(filePath);
                // 1行目はヘッダーの想定で、それをスキップして2列目かつデータを入ってるセルのみ読み込む。
                var rows = workbook.Worksheet(1).RangeUsed().RowsUsed().Skip(1);

                // エラーチェック
                if(!rows.Any())
                {
                    //　Nullチェック
                    MessageBox.Show("エラー: エクセルファイルにデータがありません。",
                                    "姉御に連絡して！ ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

                    Environment.Exit(1);
                }
                //else
                //{

                //// フォマードチェック
                //MessageBox.Show("姉御に連絡して！ エクセルのフォマードが対応していません。",
                //                "残念でした",
                //                MessageBoxButtons.OK,
                //                MessageBoxIcon.Exclamation);

                //Environment.Exit(1);
                //}

                // RowDataのリストを作る
                var rowDataList = new List<RowData>();

                // rowsのデータをRowDataに突っ込む
                foreach (var row in rows)
                {
                    var rowData = new RowData
                    {
                        // TODO 数式も読めるように書き直す
                        RowNumber = row.RowNumber(),
                        Id = Convert.ToInt32(row.Cell("A").GetString()),
                        Question = row.Cell("B").GetString(),
                        Answer = row.Cell("C").GetString(),
                        ShouldReview = Convert.ToInt32(row.Cell("D").GetString())
                    };

                    // 突っ込んだRowDataをリストに突っ込む
                    rowDataList.Add(rowData);
                }

                // 印の問題のみにフィルタリング
                if(isReviewOnlyChcked)
                {
                    rowDataList = rowDataList.Where(row => row.ShouldReview == 1).ToList();
                }


                return rowDataList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex.Message,
                                "姉御に連絡して！",
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