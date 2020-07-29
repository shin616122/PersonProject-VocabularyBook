using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VocabularyBook
{
    public partial class MainForm : Form
    {
        private List<RowData> RowDataList { get; set; }
        private int CurrentRowNumber { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォーム
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO 全問 or 印 の選択

            // TODO 指定ディレクトリ（EXEと同じPath）にある.xlsxを取得

            // 問題一覧の取得
            RowDataList = LoadData.LoadDataFromExcel();

            // 一番目の問題をtbxQuestionにロードする
            tbxQuestion.Text = RowDataList.First().Question;

            // ロードした問題のID
            CurrentRowNumber = RowDataList.First().RowNumber;

            // tbxAnswerを初期化
            tbxAnswer.Text = String.Empty;

            // TODO 問題一覧のシャッフル

        }

        /// <summary>
        /// 回答ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            // 答えをtbxAnswerにロードする
            tbxAnswer.Text = RowDataList.Where(row => row.RowNumber == CurrentRowNumber).Select(row => row.Answer).FirstOrDefault();
        }

#region いらないやつ
        /// <summary>
        /// A
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxQuestion_TextChanged(object sender, EventArgs e)
        {
            // いらないやつ後で消す
        }

        /// <summary>
        /// B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxAnswer_TextChanged(object sender, EventArgs e)
        {

        }
#endregion

        /// <summary>
        /// 次へボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO もっときれいな書き方があるはず
                // もしCurrentRowNumberが最後なら、リセットする
                if(CurrentRowNumber != RowDataList.Last().RowNumber)
                {
                    // 次の問題をロードする
                    tbxQuestion.Text = RowDataList.SkipWhile(row => row.RowNumber != CurrentRowNumber).Skip(1).First().Question; ;

                    // ロードした問題のIDを更新する
                    CurrentRowNumber = RowDataList.SkipWhile(row => row.RowNumber != CurrentRowNumber).Skip(1).First().RowNumber;
                }
                else
                {
                    // 最初の問題をロードする
                    tbxQuestion.Text = RowDataList.First().Question; ;

                    // 最初の問題のIDを更新する
                    CurrentRowNumber = RowDataList.First().RowNumber;

                }

                // tbxAnswerを初期化
                tbxAnswer.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("姉御に連絡して！ エラー: " + ex.Message,
                                "残念でした",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                throw ex;
            }
        }

        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO もっときれいな書き方があるはず
                // もしCurrentRowNumberが最後なら、リセットする
                if (CurrentRowNumber != RowDataList.First().RowNumber)
                {
                    // 前の問題をロードする
                    tbxQuestion.Text = RowDataList.TakeWhile(row => row.RowNumber != CurrentRowNumber).Last().Question; ;

                    // ロードした問題のIDを更新する
                    CurrentRowNumber = RowDataList.TakeWhile(row => row.RowNumber != CurrentRowNumber).Last().RowNumber;
                }
                else
                {
                    // 最後の問題をロードする
                    tbxQuestion.Text = RowDataList.Last().Question; ;

                    // 最後の問題のIDを更新する
                    CurrentRowNumber = RowDataList.Last().RowNumber;

                }

                // tbxAnswerを初期化
                tbxAnswer.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("姉御に連絡して！ エラー: " + ex.Message,
                                "残念でした",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                throw ex;
            }
        }

        /// <summary>
        /// 印チェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShouldReview_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("工事中だよ！",
                "残念でした",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}