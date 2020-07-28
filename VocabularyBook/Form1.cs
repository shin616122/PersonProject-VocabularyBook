using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VocabularyBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォーム
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO 全問 or 印 の選択

            // TODO 指定ディレクトリ（EXEと同じPath）にある.xlsxを取得

            // TODO 問題一覧の取得

            // TODO 問題一覧のシャッフル

        }

        /// <summary>
        /// 回答ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var results = LoadData(sender, e);
            var temp = 1;
            //MessageBox.Show("工事中だよ！",
            //    "残念でした",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// A
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // いらないやつ後で消す
        }

        /// <summary>
        /// 次へボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("工事中だよ！",
                "残念でした",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("工事中だよ！",
                "残念でした",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 印チェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("工事中だよ！",
                "残念でした",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// エクセルファイルからデータを読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private List<RowData> LoadData(object sender, EventArgs e)
        {
            try
            {
                // Load Excel workbook from path
                var workbook = new XLWorkbook(@"D:\Personal\VocabularyBook\List.xlsx"); // TODO change path
                // Select all used rows on 1 sheet and skip first row
                var rows = workbook.Worksheet(1).RangeUsed().RowsUsed().Skip(1);

                // Make an empty RowData List
                var rowsList = new List<RowData>();

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
                    rowsList.Add(rowData);
                }
                return rowsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "エラー" ,
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
