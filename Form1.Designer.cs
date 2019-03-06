namespace 算数ドリル
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.InBox = new System.Windows.Forms.TextBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.GroupBox();
            this.RBwaru = new System.Windows.Forms.RadioButton();
            this.RBkakeru = new System.Windows.Forms.RadioButton();
            this.RBhiku = new System.Windows.Forms.RadioButton();
            this.mondaiLbl = new System.Windows.Forms.Label();
            this.RBtasu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB30 = new System.Windows.Forms.RadioButton();
            this.RB20 = new System.Windows.Forms.RadioButton();
            this.RB10 = new System.Windows.Forms.RadioButton();
            this.mondaiLbl2 = new System.Windows.Forms.Label();
            this.mondaicount = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Type.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(28, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "答え";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InBox
            // 
            this.InBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InBox.Location = new System.Drawing.Point(102, 351);
            this.InBox.Name = "InBox";
            this.InBox.Size = new System.Drawing.Size(146, 29);
            this.InBox.TabIndex = 1;
            this.InBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InBox_KeyPress);
            // 
            // OutBox
            // 
            this.OutBox.BackColor = System.Drawing.Color.White;
            this.OutBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutBox.Location = new System.Drawing.Point(261, 103);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.ReadOnly = true;
            this.OutBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutBox.Size = new System.Drawing.Size(274, 277);
            this.OutBox.TabIndex = 2;
            this.OutBox.TextChanged += new System.EventHandler(this.OutBox_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(39, 313);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(187, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "開　始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Type
            // 
            this.Type.Controls.Add(this.RBwaru);
            this.Type.Controls.Add(this.RBkakeru);
            this.Type.Controls.Add(this.RBhiku);
            this.Type.Controls.Add(this.mondaiLbl);
            this.Type.Controls.Add(this.RBtasu);
            this.Type.Location = new System.Drawing.Point(31, 12);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(504, 66);
            this.Type.TabIndex = 5;
            this.Type.TabStop = false;
            this.Type.Text = "タイプ";
            this.Type.Enter += new System.EventHandler(this.Type_Enter);
            // 
            // RBwaru
            // 
            this.RBwaru.AutoSize = true;
            this.RBwaru.Location = new System.Drawing.Point(406, 30);
            this.RBwaru.Name = "RBwaru";
            this.RBwaru.Size = new System.Drawing.Size(55, 16);
            this.RBwaru.TabIndex = 10;
            this.RBwaru.Text = "割り算";
            this.RBwaru.UseVisualStyleBackColor = true;
            // 
            // RBkakeru
            // 
            this.RBkakeru.AutoSize = true;
            this.RBkakeru.Location = new System.Drawing.Point(283, 30);
            this.RBkakeru.Name = "RBkakeru";
            this.RBkakeru.Size = new System.Drawing.Size(57, 16);
            this.RBkakeru.TabIndex = 9;
            this.RBkakeru.Text = "掛け算";
            this.RBkakeru.UseVisualStyleBackColor = true;
            // 
            // RBhiku
            // 
            this.RBhiku.AutoSize = true;
            this.RBhiku.Location = new System.Drawing.Point(161, 30);
            this.RBhiku.Name = "RBhiku";
            this.RBhiku.Size = new System.Drawing.Size(56, 16);
            this.RBhiku.TabIndex = 8;
            this.RBhiku.Text = "引き算";
            this.RBhiku.UseVisualStyleBackColor = true;
            this.RBhiku.CheckedChanged += new System.EventHandler(this.RBhiku_CheckedChanged);
            // 
            // mondaiLbl
            // 
            this.mondaiLbl.BackColor = System.Drawing.SystemColors.Control;
            this.mondaiLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mondaiLbl.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mondaiLbl.Location = new System.Drawing.Point(64, 72);
            this.mondaiLbl.Name = "mondaiLbl";
            this.mondaiLbl.Size = new System.Drawing.Size(505, 55);
            this.mondaiLbl.TabIndex = 4;
            this.mondaiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RBtasu
            // 
            this.RBtasu.AutoSize = true;
            this.RBtasu.Checked = true;
            this.RBtasu.Location = new System.Drawing.Point(32, 30);
            this.RBtasu.Name = "RBtasu";
            this.RBtasu.Size = new System.Drawing.Size(56, 16);
            this.RBtasu.TabIndex = 7;
            this.RBtasu.TabStop = true;
            this.RBtasu.Text = "足し算";
            this.RBtasu.UseVisualStyleBackColor = true;
            this.RBtasu.CheckedChanged += new System.EventHandler(this.RBtasu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB30);
            this.groupBox2.Controls.Add(this.RB20);
            this.groupBox2.Controls.Add(this.RB10);
            this.groupBox2.Location = new System.Drawing.Point(32, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "問題数";
            // 
            // RB30
            // 
            this.RB30.AutoSize = true;
            this.RB30.Location = new System.Drawing.Point(139, 34);
            this.RB30.Name = "RB30";
            this.RB30.Size = new System.Drawing.Size(55, 16);
            this.RB30.TabIndex = 2;
            this.RB30.Text = "30　問";
            this.RB30.UseVisualStyleBackColor = true;
            // 
            // RB20
            // 
            this.RB20.AutoSize = true;
            this.RB20.Location = new System.Drawing.Point(78, 34);
            this.RB20.Name = "RB20";
            this.RB20.Size = new System.Drawing.Size(55, 16);
            this.RB20.TabIndex = 1;
            this.RB20.Text = "20　問";
            this.RB20.UseVisualStyleBackColor = true;
            this.RB20.CheckedChanged += new System.EventHandler(this.RB20_CheckedChanged);
            // 
            // RB10
            // 
            this.RB10.AutoSize = true;
            this.RB10.Checked = true;
            this.RB10.Location = new System.Drawing.Point(14, 34);
            this.RB10.Name = "RB10";
            this.RB10.Size = new System.Drawing.Size(55, 16);
            this.RB10.TabIndex = 0;
            this.RB10.TabStop = true;
            this.RB10.Text = "10　問";
            this.RB10.UseVisualStyleBackColor = true;
            // 
            // mondaiLbl2
            // 
            this.mondaiLbl2.BackColor = System.Drawing.Color.White;
            this.mondaiLbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mondaiLbl2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mondaiLbl2.Location = new System.Drawing.Point(31, 260);
            this.mondaiLbl2.Name = "mondaiLbl2";
            this.mondaiLbl2.Size = new System.Drawing.Size(217, 41);
            this.mondaiLbl2.TabIndex = 7;
            this.mondaiLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mondaiLbl2.Click += new System.EventHandler(this.mondaiLbl2_Click);
            // 
            // mondaicount
            // 
            this.mondaicount.AutoSize = true;
            this.mondaicount.Location = new System.Drawing.Point(44, 198);
            this.mondaicount.Name = "mondaicount";
            this.mondaicount.Size = new System.Drawing.Size(0, 12);
            this.mondaicount.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(31, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 28);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 425);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mondaicount);
            this.Controls.Add(this.mondaiLbl2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.InBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "算数ドリル";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Type.ResumeLayout(false);
            this.Type.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InBox;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox Type;
        private System.Windows.Forms.Label mondaiLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB30;
        private System.Windows.Forms.RadioButton RB20;
        private System.Windows.Forms.RadioButton RB10;
        private System.Windows.Forms.RadioButton RBtasu;
        private System.Windows.Forms.RadioButton RBhiku;
        private System.Windows.Forms.Label mondaiLbl2;
        private System.Windows.Forms.Label mondaicount;
        private System.Windows.Forms.RadioButton RBwaru;
        private System.Windows.Forms.RadioButton RBkakeru;
        private System.Windows.Forms.ListBox listBox1;
    }
}

