namespace StockMonitoringCommunity.SubForm
{
    partial class StoreUserControl
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
            txtStoreID = new TextBox();
            txtStoreName = new TextBox();
            txtStoreLocation = new TextBox();
            btnSave = new Button();
            btnRead = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 53);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "StoreID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 88);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 129);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 12);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 0;
            label4.Text = "Store";
            // 
            // txtStoreID
            // 
            txtStoreID.Location = new Point(83, 50);
            txtStoreID.Name = "txtStoreID";
            txtStoreID.Size = new Size(173, 23);
            txtStoreID.TabIndex = 1;
            // 
            // txtStoreName
            // 
            txtStoreName.Location = new Point(83, 85);
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(173, 23);
            txtStoreName.TabIndex = 1;
            // 
            // txtStoreLocation
            // 
            txtStoreLocation.Location = new Point(95, 121);
            txtStoreLocation.Name = "txtStoreLocation";
            txtStoreLocation.Size = new Size(173, 23);
            txtStoreLocation.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(295, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(486, 42);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(519, 133);
            dataGridView1.TabIndex = 3;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // StoreUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(txtStoreLocation);
            Controls.Add(txtStoreName);
            Controls.Add(txtStoreID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "StoreUserControl";
            Size = new Size(584, 312);
            Load += StoreUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStoreID;
        private TextBox txtStoreName;
        private TextBox txtStoreLocation;
        private Button btnSave;
        private Button btnRead;
        private DataGridView dataGridView1;
    }
}
