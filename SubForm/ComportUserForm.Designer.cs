using StockMonitoringCommunity.Services;

namespace StockMonitoringCommunity.SubForm
{
    partial class ComportUserForm
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

                UiEventBus.MessagePublished -= OnMessage;
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
            cmbCom = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbBaudrate = new ComboBox();
            cmbPatt2 = new ComboBox();
            label6 = new Label();
            cmbParity = new ComboBox();
            cmbPatt3 = new ComboBox();
            label8 = new Label();
            cmbLength = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            cmbPatt6 = new ComboBox();
            label14 = new Label();
            cmbInput = new ComboBox();
            cmbEnable = new ComboBox();
            cmbCh = new ComboBox();
            cmbStop = new ComboBox();
            cmbHand = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            label13 = new Label();
            label15 = new Label();
            cmbPatt1 = new ComboBox();
            btnReset = new Button();
            btnSave = new Button();
            label16 = new Label();
            txtLastedit = new TextBox();
            cmbPatt4 = new ComboBox();
            cmbPatt5 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Ch.number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "COM Port";
            // 
            // cmbCom
            // 
            cmbCom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCom.FormattingEnabled = true;
            cmbCom.Location = new Point(92, 52);
            cmbCom.Name = "cmbCom";
            cmbCom.Size = new Size(121, 23);
            cmbCom.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 57);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 0;
            label3.Text = "Input pattern 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Baud rate";
            // 
            // cmbBaudrate
            // 
            cmbBaudrate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBaudrate.FormattingEnabled = true;
            cmbBaudrate.Location = new Point(92, 81);
            cmbBaudrate.Name = "cmbBaudrate";
            cmbBaudrate.Size = new Size(121, 23);
            cmbBaudrate.TabIndex = 1;
            // 
            // cmbPatt2
            // 
            cmbPatt2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatt2.FormattingEnabled = true;
            cmbPatt2.Location = new Point(325, 81);
            cmbPatt2.Name = "cmbPatt2";
            cmbPatt2.Size = new Size(130, 23);
            cmbPatt2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 113);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 0;
            label6.Text = "Parity";
            // 
            // cmbParity
            // 
            cmbParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(92, 110);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(121, 23);
            cmbParity.TabIndex = 1;
            // 
            // cmbPatt3
            // 
            cmbPatt3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatt3.FormattingEnabled = true;
            cmbPatt3.Location = new Point(325, 110);
            cmbPatt3.Name = "cmbPatt3";
            cmbPatt3.Size = new Size(130, 23);
            cmbPatt3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 142);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 0;
            label8.Text = "Data length";
            // 
            // cmbLength
            // 
            cmbLength.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLength.FormattingEnabled = true;
            cmbLength.Location = new Point(92, 139);
            cmbLength.Name = "cmbLength";
            cmbLength.Size = new Size(121, 23);
            cmbLength.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 171);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 0;
            label10.Text = "Stop bit";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 200);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 0;
            label12.Text = "Handshake";
            // 
            // cmbPatt6
            // 
            cmbPatt6.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatt6.FormattingEnabled = true;
            cmbPatt6.Location = new Point(325, 197);
            cmbPatt6.Name = "cmbPatt6";
            cmbPatt6.Size = new Size(130, 23);
            cmbPatt6.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 234);
            label14.Name = "label14";
            label14.Size = new Size(85, 15);
            label14.TabIndex = 0;
            label14.Text = "Input direction";
            // 
            // cmbInput
            // 
            cmbInput.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInput.FormattingEnabled = true;
            cmbInput.Location = new Point(92, 231);
            cmbInput.Name = "cmbInput";
            cmbInput.Size = new Size(121, 23);
            cmbInput.TabIndex = 1;
            // 
            // cmbEnable
            // 
            cmbEnable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEnable.FormattingEnabled = true;
            cmbEnable.Location = new Point(325, 226);
            cmbEnable.Name = "cmbEnable";
            cmbEnable.Size = new Size(130, 23);
            cmbEnable.TabIndex = 1;
            // 
            // cmbCh
            // 
            cmbCh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCh.FormattingEnabled = true;
            cmbCh.Location = new Point(92, 21);
            cmbCh.Name = "cmbCh";
            cmbCh.Size = new Size(121, 23);
            cmbCh.TabIndex = 1;
            cmbCh.TextChanged += cmbCh_TextChanged;
            // 
            // cmbStop
            // 
            cmbStop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStop.FormattingEnabled = true;
            cmbStop.Location = new Point(92, 171);
            cmbStop.Name = "cmbStop";
            cmbStop.Size = new Size(121, 23);
            cmbStop.TabIndex = 1;
            // 
            // cmbHand
            // 
            cmbHand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHand.FormattingEnabled = true;
            cmbHand.Location = new Point(92, 199);
            cmbHand.Name = "cmbHand";
            cmbHand.Size = new Size(121, 23);
            cmbHand.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 84);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 0;
            label5.Text = "Input pattern 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 113);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 0;
            label7.Text = "Input pattern 3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(234, 139);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 0;
            label9.Text = "Input pattern 4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(234, 171);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 0;
            label11.Text = "Input pattern 5";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(234, 197);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 0;
            label13.Text = "Input pattern 6";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(234, 231);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 0;
            label15.Text = "Enable";
            // 
            // cmbPatt1
            // 
            cmbPatt1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatt1.FormattingEnabled = true;
            cmbPatt1.Location = new Point(325, 52);
            cmbPatt1.Name = "cmbPatt1";
            cmbPatt1.Size = new Size(130, 23);
            cmbPatt1.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(371, 18);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 27);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(452, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 31);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(234, 263);
            label16.Name = "label16";
            label16.Size = new Size(48, 15);
            label16.TabIndex = 0;
            label16.Text = "Lastedit";
            // 
            // txtLastedit
            // 
            txtLastedit.Location = new Point(325, 260);
            txtLastedit.Name = "txtLastedit";
            txtLastedit.ReadOnly = true;
            txtLastedit.Size = new Size(130, 23);
            txtLastedit.TabIndex = 3;
            // 
            // cmbPatt4
            // 
            cmbPatt4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatt4.FormattingEnabled = true;
            cmbPatt4.Location = new Point(325, 139);
            cmbPatt4.Name = "cmbPatt4";
            cmbPatt4.Size = new Size(130, 23);
            cmbPatt4.TabIndex = 1;
            // 
            // cmbPatt5
            // 
            cmbPatt5.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatt5.FormattingEnabled = true;
            cmbPatt5.Location = new Point(325, 168);
            cmbPatt5.Name = "cmbPatt5";
            cmbPatt5.Size = new Size(130, 23);
            cmbPatt5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1280, 278);
            dataGridView1.TabIndex = 4;
            // 
            // ComportUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(txtLastedit);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(cmbEnable);
            Controls.Add(cmbPatt6);
            Controls.Add(cmbPatt5);
            Controls.Add(cmbPatt4);
            Controls.Add(cmbPatt3);
            Controls.Add(cmbPatt1);
            Controls.Add(cmbPatt2);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(cmbInput);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(cmbHand);
            Controls.Add(cmbStop);
            Controls.Add(cmbLength);
            Controls.Add(label8);
            Controls.Add(cmbParity);
            Controls.Add(label6);
            Controls.Add(cmbBaudrate);
            Controls.Add(label4);
            Controls.Add(cmbCh);
            Controls.Add(cmbCom);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ComportUserForm";
            Size = new Size(1382, 666);
            Load += ComportUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbCom;
        private Label label3;
        //private ComboBox comboBox2;
        private Label label4;
        private ComboBox cmbBaudrate;
        private ComboBox cmbPatt2;
        private Label label6;
        private ComboBox cmbParity;
        private ComboBox cmbPatt3;
        private Label label8;
        private ComboBox cmbLength;
        //private ComboBox comboBox8;
        private Label label10;
        //private ComboBox comboBox9;
        //private ComboBox comboBox10;
        private Label label12;
        //private ComboBox comboBox11;
        private ComboBox cmbPatt6;
        private Label label14;
        private ComboBox cmbInput;
        private ComboBox cmbEnable;
        private ComboBox cmbCh;
        private ComboBox cmbStop;
        private ComboBox cmbHand;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label11;
        private Label label13;
        private Label label15;
        private ComboBox cmbPatt1;
        private Button btnReset;
        private Button btnSave;
        private Label label16;
        private TextBox txtLastedit;
        private ComboBox cmbPatt4;
        private ComboBox cmbPatt5;
        private DataGridView dataGridView1;
    }
}
