namespace WindowsFormsApplication1
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
            this.city = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.city.FormattingEnabled = true;
            this.city.ItemHeight = 20;
            this.city.Items.AddRange(new object[] {
            "檀香山(夏威夷州)",
            "丹佛(科羅拉多州)",
            "明尼亞波利斯(明尼蘇達州)",
            "紐約(紐約州)",
            "舊金山(加利福尼亞州)"});
            this.city.Location = new System.Drawing.Point(44, 55);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(215, 104);
            this.city.TabIndex = 0;
            this.city.SelectedIndexChanged += new System.EventHandler(this.city_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.Label1.Location = new System.Drawing.Point(12, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 23);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "城市 :";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "對應時區";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.output.ForeColor = System.Drawing.SystemColors.ControlText;
            this.output.Location = new System.Drawing.Point(44, 248);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(215, 23);
            this.output.TabIndex = 3;
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.display.Location = new System.Drawing.Point(264, 175);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(98, 32);
            this.display.TabIndex = 4;
            this.display.Text = "確定";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.exit.Location = new System.Drawing.Point(264, 281);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(98, 32);
            this.exit.TabIndex = 5;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 330);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.display);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.city);
            this.Name = "Form1";
            this.Text = "時區對應程式   ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox city;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button exit;
    }
}

