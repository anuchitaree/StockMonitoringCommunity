namespace StockMonitoringCommunity.SubForm
{
    partial class InputPatternUserForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbPatt = new ComboBox();
            TbScan = new TextBox();
            Tblen = new TextBox();
            TbResult = new TextBox();
            TbStart = new TextBox();
            TbEnd = new TextBox();
            TbNumber = new TextBox();
            TbTotal = new TextBox();
            TbUq = new TextBox();
            label10 = new Label();
            TbUnqTxt = new TextBox();
            btnGetStart = new Button();
            btnEndPos = new Button();
            btnTotal = new Button();
            btnUnqStart = new Button();
            btnUnqTxt = new Button();
            btnSave = new Button();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 10);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Pattern No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(209, 15);
            label2.TabIndex = 0;
            label2.Text = "Raw messages from CH1 or paste here";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 122);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 119);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Result";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 156);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 0;
            label5.Text = "Start position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 181);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 0;
            label6.Text = "End position";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 207);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 0;
            label7.Text = "Number of charactor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 234);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 0;
            label8.Text = "Total charator";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 265);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 0;
            label9.Text = "Unquie start position";
            // 
            // cmbPatt
            // 
            cmbPatt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatt.FormattingEnabled = true;
            cmbPatt.Location = new Point(105, 7);
            cmbPatt.Name = "cmbPatt";
            cmbPatt.Size = new Size(121, 23);
            cmbPatt.TabIndex = 1;
            cmbPatt.SelectedIndexChanged += cmbPatt_SelectedIndexChanged;
            // 
            // TbScan
            // 
            TbScan.Location = new Point(3, 53);
            TbScan.Multiline = true;
            TbScan.Name = "TbScan";
            TbScan.Size = new Size(398, 58);
            TbScan.TabIndex = 2;
            TbScan.KeyUp += TbScan_KeyUp;
            TbScan.MouseUp += TbScan_MouseUp;
            // 
            // Tblen
            // 
            Tblen.Location = new Point(363, 117);
            Tblen.Name = "Tblen";
            Tblen.ReadOnly = true;
            Tblen.Size = new Size(38, 23);
            Tblen.TabIndex = 2;
            Tblen.TextAlign = HorizontalAlignment.Center;
            // 
            // TbResult
            // 
            TbResult.Location = new Point(48, 117);
            TbResult.Name = "TbResult";
            TbResult.Size = new Size(203, 23);
            TbResult.TabIndex = 2;
            // 
            // TbStart
            // 
            TbStart.Location = new Point(105, 153);
            TbStart.Name = "TbStart";
            TbStart.Size = new Size(74, 23);
            TbStart.TabIndex = 2;
            TbStart.TextAlign = HorizontalAlignment.Center;
            // 
            // TbEnd
            // 
            TbEnd.Location = new Point(105, 178);
            TbEnd.Name = "TbEnd";
            TbEnd.Size = new Size(74, 23);
            TbEnd.TabIndex = 2;
            TbEnd.TextAlign = HorizontalAlignment.Center;
            // 
            // TbNumber
            // 
            TbNumber.Location = new Point(147, 204);
            TbNumber.Name = "TbNumber";
            TbNumber.Size = new Size(74, 23);
            TbNumber.TabIndex = 2;
            TbNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // TbTotal
            // 
            TbTotal.Location = new Point(147, 233);
            TbTotal.Name = "TbTotal";
            TbTotal.Size = new Size(74, 23);
            TbTotal.TabIndex = 2;
            TbTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // TbUq
            // 
            TbUq.Location = new Point(146, 262);
            TbUq.Name = "TbUq";
            TbUq.Size = new Size(74, 23);
            TbUq.TabIndex = 2;
            TbUq.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 289);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 0;
            label10.Text = "Unquie text";
            // 
            // TbUnqTxt
            // 
            TbUnqTxt.Location = new Point(23, 315);
            TbUnqTxt.Name = "TbUnqTxt";
            TbUnqTxt.Size = new Size(378, 23);
            TbUnqTxt.TabIndex = 2;
            // 
            // btnGetStart
            // 
            btnGetStart.Location = new Point(185, 148);
            btnGetStart.Name = "btnGetStart";
            btnGetStart.Size = new Size(48, 23);
            btnGetStart.TabIndex = 3;
            btnGetStart.Text = "Get";
            btnGetStart.UseVisualStyleBackColor = true;
            btnGetStart.Click += btnGetStart_Click;
            // 
            // btnEndPos
            // 
            btnEndPos.Location = new Point(185, 175);
            btnEndPos.Name = "btnEndPos";
            btnEndPos.Size = new Size(48, 23);
            btnEndPos.TabIndex = 3;
            btnEndPos.Text = "Get";
            btnEndPos.UseVisualStyleBackColor = true;
            btnEndPos.Click += btnEndPos_Click;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(227, 232);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(48, 23);
            btnTotal.TabIndex = 3;
            btnTotal.Text = "Get";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnUnqStart
            // 
            btnUnqStart.Location = new Point(226, 262);
            btnUnqStart.Name = "btnUnqStart";
            btnUnqStart.Size = new Size(48, 23);
            btnUnqStart.TabIndex = 3;
            btnUnqStart.Text = "Get";
            btnUnqStart.UseVisualStyleBackColor = true;
            btnUnqStart.Click += btnUnqStart_Click;
            // 
            // btnUnqTxt
            // 
            btnUnqTxt.Location = new Point(226, 291);
            btnUnqTxt.Name = "btnUnqTxt";
            btnUnqTxt.Size = new Size(48, 23);
            btnUnqTxt.TabIndex = 3;
            btnUnqTxt.Text = "Get";
            btnUnqTxt.UseVisualStyleBackColor = true;
            btnUnqTxt.Click += btnUnqTxt_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(318, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 57);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(257, 119);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(52, 23);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // InputPatternUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCheck);
            Controls.Add(btnSave);
            Controls.Add(btnUnqTxt);
            Controls.Add(btnUnqStart);
            Controls.Add(btnTotal);
            Controls.Add(btnEndPos);
            Controls.Add(btnGetStart);
            Controls.Add(TbUnqTxt);
            Controls.Add(TbUq);
            Controls.Add(TbTotal);
            Controls.Add(TbNumber);
            Controls.Add(TbEnd);
            Controls.Add(TbStart);
            Controls.Add(TbResult);
            Controls.Add(Tblen);
            Controls.Add(TbScan);
            Controls.Add(cmbPatt);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InputPatternUserForm";
            Size = new Size(417, 341);
            Load += InputPatternUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmbPatt;
        private TextBox TbScan;
        private TextBox Tblen;
        private TextBox TbResult;
        private Button btnCheck;
        private TextBox TbStart;
        private TextBox TbEnd;
        private TextBox TbNumber;
        private TextBox TbTotal;
        private TextBox TbUq;
        private Label label10;
        private TextBox TbUnqTxt;
        private Button btnGetStart;
        private Button btnEndPos;
        private Button btnTotal;
        private Button btnUnqStart;
        private Button btnUnqTxt;
        private Button btnSave;
    }
}
