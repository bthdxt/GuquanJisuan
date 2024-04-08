namespace GuquanForm
{
    partial class GuquanJisuanForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GetCsvFileBtn = new Button();
            GetCsvFiletextBox = new TextBox();
            GetCsvFileLab = new Label();
            JsItemLab = new Label();
            JsItemcomboBox = new ComboBox();
            JsStarBtn = new Button();
            GuquanBiTextBox = new TextBox();
            CopyBtn = new Button();
            JsZhongJiancheckBox = new CheckBox();
            BaoLiuXiaoShulabel = new Label();
            BaoLiuXiaoShuComboBox = new ComboBox();
            SuspendLayout();
            // 
            // GetCsvFileBtn
            // 
            GetCsvFileBtn.Location = new Point(457, 12);
            GetCsvFileBtn.Name = "GetCsvFileBtn";
            GetCsvFileBtn.Size = new Size(75, 23);
            GetCsvFileBtn.TabIndex = 0;
            GetCsvFileBtn.Text = "选择文件";
            GetCsvFileBtn.UseVisualStyleBackColor = true;
            GetCsvFileBtn.Click += GetCsvFileBtn_Click;
            // 
            // GetCsvFiletextBox
            // 
            GetCsvFiletextBox.Enabled = false;
            GetCsvFiletextBox.Location = new Point(116, 12);
            GetCsvFiletextBox.Name = "GetCsvFiletextBox";
            GetCsvFiletextBox.Size = new Size(335, 23);
            GetCsvFiletextBox.TabIndex = 1;
            // 
            // GetCsvFileLab
            // 
            GetCsvFileLab.AutoSize = true;
            GetCsvFileLab.Location = new Point(12, 15);
            GetCsvFileLab.Name = "GetCsvFileLab";
            GetCsvFileLab.Size = new Size(98, 17);
            GetCsvFileLab.TabIndex = 2;
            GetCsvFileLab.Text = "选择csv文件路径";
            // 
            // JsItemLab
            // 
            JsItemLab.AutoSize = true;
            JsItemLab.Location = new Point(12, 45);
            JsItemLab.Name = "JsItemLab";
            JsItemLab.Size = new Size(80, 17);
            JsItemLab.TabIndex = 3;
            JsItemLab.Text = "选择计算对象";
            // 
            // JsItemcomboBox
            // 
            JsItemcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            JsItemcomboBox.FormattingEnabled = true;
            JsItemcomboBox.Location = new Point(116, 42);
            JsItemcomboBox.Name = "JsItemcomboBox";
            JsItemcomboBox.Size = new Size(335, 25);
            JsItemcomboBox.TabIndex = 4;
            // 
            // JsStarBtn
            // 
            JsStarBtn.Location = new Point(457, 42);
            JsStarBtn.Name = "JsStarBtn";
            JsStarBtn.Size = new Size(75, 23);
            JsStarBtn.TabIndex = 5;
            JsStarBtn.Text = "开始计算";
            JsStarBtn.UseVisualStyleBackColor = true;
            JsStarBtn.Click += JsStarBtn_Click;
            // 
            // GuquanBiTextBox
            // 
            GuquanBiTextBox.Location = new Point(12, 104);
            GuquanBiTextBox.Margin = new Padding(2);
            GuquanBiTextBox.Multiline = true;
            GuquanBiTextBox.Name = "GuquanBiTextBox";
            GuquanBiTextBox.ScrollBars = ScrollBars.Both;
            GuquanBiTextBox.Size = new Size(522, 272);
            GuquanBiTextBox.TabIndex = 6;
            // 
            // CopyBtn
            // 
            CopyBtn.Location = new Point(396, 385);
            CopyBtn.Margin = new Padding(2);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(139, 25);
            CopyBtn.TabIndex = 7;
            CopyBtn.Text = "复制结果到剪切板";
            CopyBtn.UseVisualStyleBackColor = true;
            CopyBtn.Click += CopyBtn_Click;
            // 
            // JsZhongJiancheckBox
            // 
            JsZhongJiancheckBox.AutoSize = true;
            JsZhongJiancheckBox.Location = new Point(385, 77);
            JsZhongJiancheckBox.Margin = new Padding(2);
            JsZhongJiancheckBox.Name = "JsZhongJiancheckBox";
            JsZhongJiancheckBox.Size = new Size(147, 21);
            JsZhongJiancheckBox.TabIndex = 8;
            JsZhongJiancheckBox.Text = "计算中间公司股份占比";
            JsZhongJiancheckBox.UseVisualStyleBackColor = true;
            // 
            // BaoLiuXiaoShulabel
            // 
            BaoLiuXiaoShulabel.AutoSize = true;
            BaoLiuXiaoShulabel.Location = new Point(12, 79);
            BaoLiuXiaoShulabel.Name = "BaoLiuXiaoShulabel";
            BaoLiuXiaoShulabel.Size = new Size(80, 17);
            BaoLiuXiaoShulabel.TabIndex = 9;
            BaoLiuXiaoShulabel.Text = "小数保留位数";
            // 
            // BaoLiuXiaoShuComboBox
            // 
            BaoLiuXiaoShuComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BaoLiuXiaoShuComboBox.FormattingEnabled = true;
            BaoLiuXiaoShuComboBox.Location = new Point(116, 73);
            BaoLiuXiaoShuComboBox.Name = "BaoLiuXiaoShuComboBox";
            BaoLiuXiaoShuComboBox.Size = new Size(128, 25);
            BaoLiuXiaoShuComboBox.TabIndex = 10;
            // 
            // GuquanJisuanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 418);
            Controls.Add(BaoLiuXiaoShuComboBox);
            Controls.Add(BaoLiuXiaoShulabel);
            Controls.Add(JsZhongJiancheckBox);
            Controls.Add(CopyBtn);
            Controls.Add(GuquanBiTextBox);
            Controls.Add(JsStarBtn);
            Controls.Add(JsItemcomboBox);
            Controls.Add(JsItemLab);
            Controls.Add(GetCsvFileLab);
            Controls.Add(GetCsvFiletextBox);
            Controls.Add(GetCsvFileBtn);
            Name = "GuquanJisuanForm";
            Text = "股权计算器V1.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetCsvFileBtn;
        private TextBox GetCsvFiletextBox;
        private Label GetCsvFileLab;
        private Label JsItemLab;
        private ComboBox JsItemcomboBox;
        private Button JsStarBtn;
        private TextBox GuquanBiTextBox;
        private Button CopyBtn;
        private CheckBox JsZhongJiancheckBox;
        private Label BaoLiuXiaoShulabel;
        private ComboBox BaoLiuXiaoShuComboBox;
    }
}