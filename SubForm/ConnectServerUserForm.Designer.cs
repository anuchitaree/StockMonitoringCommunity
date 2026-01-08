namespace StockMonitoringCommunity.SubForm
{
    partial class ConnectServerUserForm
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
            lbResult = new Label();
            btnSave = new Button();
            btnTest = new Button();
            cmbStore = new ComboBox();
            label5 = new Label();
            txtIP = new TextBox();
            txtPort = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "Connection to Stock server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 67);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 0;
            label2.Text = "URL or IP Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 67);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 0;
            label3.Text = "Port number";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(124, 131);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(39, 15);
            lbResult.TabIndex = 0;
            lbResult.Text = "Result";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(311, 186);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(311, 123);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // cmbStore
            // 
            cmbStore.FormattingEnabled = true;
            cmbStore.Location = new Point(25, 186);
            cmbStore.Name = "cmbStore";
            cmbStore.Size = new Size(254, 23);
            cmbStore.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 168);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 0;
            label5.Text = "Store Id";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(27, 89);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(159, 23);
            txtIP.TabIndex = 4;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(227, 89);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(159, 23);
            txtPort.TabIndex = 4;
            // 
            // ConnectServerUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPort);
            Controls.Add(txtIP);
            Controls.Add(cmbStore);
            Controls.Add(btnTest);
            Controls.Add(btnSave);
            Controls.Add(lbResult);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConnectServerUserForm";
            Size = new Size(432, 305);
            Load += ConnectServerUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbResult;
        private Button btnSave;
        private Button btnTest;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cmbStore;
        private Label label5;
        private TextBox txtIP;
        private TextBox txtPort;
    }
}
