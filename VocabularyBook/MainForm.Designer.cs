﻿namespace VocabularyBook
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.chkShouldReview = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbFilepath = new System.Windows.Forms.Label();
            this.pnlQA = new System.Windows.Forms.Panel();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.chkHideQuestion = new System.Windows.Forms.CheckBox();
            this.chkShuffle = new System.Windows.Forms.CheckBox();
            this.chkReviewOnly = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbQuestionNumber = new System.Windows.Forms.Label();
            this.richTbxQuestion = new System.Windows.Forms.RichTextBox();
            this.richTbxAnswer = new System.Windows.Forms.RichTextBox();
            this.pnlQA.SuspendLayout();
            this.pnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ａ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(361, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ｂ";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAnswer.Location = new System.Drawing.Point(282, 129);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(69, 66);
            this.btnAnswer.TabIndex = 4;
            this.btnAnswer.Text = "回答";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(516, 267);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 34);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "次へ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // chkShouldReview
            // 
            this.chkShouldReview.AutoSize = true;
            this.chkShouldReview.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkShouldReview.Location = new System.Drawing.Point(511, 11);
            this.chkShouldReview.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chkShouldReview.Name = "chkShouldReview";
            this.chkShouldReview.Size = new System.Drawing.Size(106, 23);
            this.chkShouldReview.TabIndex = 6;
            this.chkShouldReview.Text = "印をつける";
            this.chkShouldReview.UseVisualStyleBackColor = true;
            this.chkShouldReview.CheckedChanged += new System.EventHandler(this.chkShouldReview_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBack.Location = new System.Drawing.Point(17, 267);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbFilepath
            // 
            this.lbFilepath.AutoSize = true;
            this.lbFilepath.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lbFilepath.Location = new System.Drawing.Point(11, 11);
            this.lbFilepath.Name = "lbFilepath";
            this.lbFilepath.Size = new System.Drawing.Size(50, 14);
            this.lbFilepath.TabIndex = 8;
            this.lbFilepath.Text = "filepath";
            this.lbFilepath.Click += new System.EventHandler(this.lbFilepath_Click);
            // 
            // pnlQA
            // 
            this.pnlQA.Controls.Add(this.pnlStart);
            this.pnlQA.Controls.Add(this.btnAnswer);
            this.pnlQA.Controls.Add(this.chkShouldReview);
            this.pnlQA.Controls.Add(this.label2);
            this.pnlQA.Controls.Add(this.btnBack);
            this.pnlQA.Controls.Add(this.btnNext);
            this.pnlQA.Controls.Add(this.lbFilepath);
            this.pnlQA.Controls.Add(this.label1);
            this.pnlQA.Controls.Add(this.btnHome);
            this.pnlQA.Controls.Add(this.lbQuestionNumber);
            this.pnlQA.Controls.Add(this.richTbxQuestion);
            this.pnlQA.Controls.Add(this.richTbxAnswer);
            this.pnlQA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQA.Location = new System.Drawing.Point(0, 0);
            this.pnlQA.Name = "pnlQA";
            this.pnlQA.Size = new System.Drawing.Size(638, 308);
            this.pnlQA.TabIndex = 9;
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.chkHideQuestion);
            this.pnlStart.Controls.Add(this.chkShuffle);
            this.pnlStart.Controls.Add(this.chkReviewOnly);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(0, 0);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(638, 311);
            this.pnlStart.TabIndex = 9;
            // 
            // chkHideQuestion
            // 
            this.chkHideQuestion.AutoSize = true;
            this.chkHideQuestion.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkHideQuestion.Location = new System.Drawing.Point(494, 218);
            this.chkHideQuestion.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chkHideQuestion.Name = "chkHideQuestion";
            this.chkHideQuestion.Size = new System.Drawing.Size(123, 23);
            this.chkHideQuestion.TabIndex = 3;
            this.chkHideQuestion.Text = "問題非表示";
            this.chkHideQuestion.UseVisualStyleBackColor = true;
            this.chkHideQuestion.CheckedChanged += new System.EventHandler(this.chkHideQuestion_CheckedChanged);
            // 
            // chkShuffle
            // 
            this.chkShuffle.AutoSize = true;
            this.chkShuffle.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkShuffle.Location = new System.Drawing.Point(494, 247);
            this.chkShuffle.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chkShuffle.Name = "chkShuffle";
            this.chkShuffle.Size = new System.Drawing.Size(86, 23);
            this.chkShuffle.TabIndex = 2;
            this.chkShuffle.Text = "シャフル";
            this.chkShuffle.UseVisualStyleBackColor = true;
            this.chkShuffle.CheckedChanged += new System.EventHandler(this.chkShuffle_CheckedChanged);
            // 
            // chkReviewOnly
            // 
            this.chkReviewOnly.AutoSize = true;
            this.chkReviewOnly.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkReviewOnly.Location = new System.Drawing.Point(494, 274);
            this.chkReviewOnly.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chkReviewOnly.Name = "chkReviewOnly";
            this.chkReviewOnly.Size = new System.Drawing.Size(134, 23);
            this.chkReviewOnly.TabIndex = 1;
            this.chkReviewOnly.Text = "印の問題のみ";
            this.chkReviewOnly.UseVisualStyleBackColor = true;
            this.chkReviewOnly.CheckedChanged += new System.EventHandler(this.chkReviewOnly_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStart.Location = new System.Drawing.Point(216, 218);
            this.btnStart.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 77);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHome.Location = new System.Drawing.Point(267, 267);
            this.btnHome.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(101, 34);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "ホーム";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbQuestionNumber
            // 
            this.lbQuestionNumber.AutoSize = true;
            this.lbQuestionNumber.Font = new System.Drawing.Font("MS UI Gothic", 13.875F);
            this.lbQuestionNumber.Location = new System.Drawing.Point(526, 41);
            this.lbQuestionNumber.Name = "lbQuestionNumber";
            this.lbQuestionNumber.Size = new System.Drawing.Size(81, 19);
            this.lbQuestionNumber.TabIndex = 11;
            this.lbQuestionNumber.Text = "問題:0/0";
            // 
            // richTbxQuestion
            // 
            this.richTbxQuestion.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTbxQuestion.Location = new System.Drawing.Point(17, 66);
            this.richTbxQuestion.Name = "richTbxQuestion";
            this.richTbxQuestion.ReadOnly = true;
            this.richTbxQuestion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTbxQuestion.Size = new System.Drawing.Size(250, 196);
            this.richTbxQuestion.TabIndex = 12;
            this.richTbxQuestion.Text = "インドメタシン";
            this.richTbxQuestion.TextChanged += new System.EventHandler(this.richTbxQuestion_TextChanged);
            // 
            // richTbxAnswer
            // 
            this.richTbxAnswer.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTbxAnswer.Location = new System.Drawing.Point(366, 66);
            this.richTbxAnswer.Name = "richTbxAnswer";
            this.richTbxAnswer.ReadOnly = true;
            this.richTbxAnswer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTbxAnswer.Size = new System.Drawing.Size(250, 196);
            this.richTbxAnswer.TabIndex = 13;
            this.richTbxAnswer.Text = "強力なCOX阻害薬だが、イヌネコに対して・・・";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 308);
            this.Controls.Add(this.pnlQA);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "MainForm";
            this.Text = "単語帳";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlQA.ResumeLayout(false);
            this.pnlQA.PerformLayout();
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox chkShouldReview;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbFilepath;
        private System.Windows.Forms.Panel pnlQA;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.CheckBox chkReviewOnly;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkShuffle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.CheckBox chkHideQuestion;
        private System.Windows.Forms.Label lbQuestionNumber;
        private System.Windows.Forms.RichTextBox richTbxQuestion;
        private System.Windows.Forms.RichTextBox richTbxAnswer;
    }
}

