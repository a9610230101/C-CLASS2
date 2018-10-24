namespace score
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.scoreIn = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.statistics = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入成績:";
            // 
            // scoreIn
            // 
            this.scoreIn.Location = new System.Drawing.Point(172, 31);
            this.scoreIn.Margin = new System.Windows.Forms.Padding(5);
            this.scoreIn.Name = "scoreIn";
            this.scoreIn.Size = new System.Drawing.Size(230, 29);
            this.scoreIn.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(417, 28);
            this.Add.Margin = new System.Windows.Forms.Padding(5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(125, 38);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // scoreListBox
            // 
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.ItemHeight = 20;
            this.scoreListBox.Location = new System.Drawing.Point(172, 83);
            this.scoreListBox.Margin = new System.Windows.Forms.Padding(5);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(230, 264);
            this.scoreListBox.TabIndex = 3;
            this.scoreListBox.SelectedIndexChanged += new System.EventHandler(this.scoreListBox_SelectedIndexChanged);
            // 
            // statistics
            // 
            this.statistics.Location = new System.Drawing.Point(40, 365);
            this.statistics.Margin = new System.Windows.Forms.Padding(5);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(125, 38);
            this.statistics.TabIndex = 4;
            this.statistics.Text = "統計";
            this.statistics.UseVisualStyleBackColor = true;
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(413, 365);
            this.exit.Margin = new System.Windows.Forms.Padding(5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 38);
            this.exit.TabIndex = 5;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(228, 365);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(125, 38);
            this.clear.TabIndex = 6;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "成績:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.scoreListBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.scoreIn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scoreIn;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.Button statistics;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label2;
    }
}

