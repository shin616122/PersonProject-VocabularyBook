namespace VocabularyBook
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
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.tbxAnswer = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.chkShouldReview = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 39);
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
            this.label2.Location = new System.Drawing.Point(372, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ｂ";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Enabled = false;
            this.tbxQuestion.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxQuestion.Location = new System.Drawing.Point(18, 67);
            this.tbxQuestion.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(251, 196);
            this.tbxQuestion.TabIndex = 2;
            this.tbxQuestion.Text = "インドメタシン";
            this.tbxQuestion.TextChanged += new System.EventHandler(this.tbxQuestion_TextChanged);
            // 
            // tbxAnswer
            // 
            this.tbxAnswer.Enabled = false;
            this.tbxAnswer.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxAnswer.Location = new System.Drawing.Point(367, 67);
            this.tbxAnswer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbxAnswer.Multiline = true;
            this.tbxAnswer.Name = "tbxAnswer";
            this.tbxAnswer.Size = new System.Drawing.Size(251, 196);
            this.tbxAnswer.TabIndex = 3;
            this.tbxAnswer.Text = "強力なCOX阻害薬だが、イヌネコに対して・・・";
            this.tbxAnswer.TextChanged += new System.EventHandler(this.tbxAnswer_TextChanged);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAnswer.Location = new System.Drawing.Point(282, 134);
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
            this.btnNext.Location = new System.Drawing.Point(515, 268);
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
            this.chkShouldReview.Location = new System.Drawing.Point(523, 12);
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
            this.btnBack.Location = new System.Drawing.Point(18, 268);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 308);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkShouldReview);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.tbxAnswer);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "MainForm";
            this.Text = "単語帳";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.TextBox tbxAnswer;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox chkShouldReview;
        private System.Windows.Forms.Button btnBack;
    }
}

