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
            label4 = new Label();
            bntSave = new Button();
            btnTest = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            label2.Location = new Point(25, 58);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 0;
            label2.Text = "URL or IP Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 134);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 0;
            label3.Text = "Port number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 206);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Result";
            // 
            // bntSave
            // 
            bntSave.Location = new Point(327, 153);
            bntSave.Name = "bntSave";
            bntSave.Size = new Size(75, 23);
            bntSave.TabIndex = 1;
            bntSave.Text = "Save";
            bntSave.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(327, 206);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 23);
            textBox2.TabIndex = 2;
            // 
            // ConnectServerUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnTest);
            Controls.Add(bntSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConnectServerUserForm";
            Size = new Size(432, 305);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bntSave;
        private Button btnTest;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
