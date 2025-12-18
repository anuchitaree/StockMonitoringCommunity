namespace StockMonitoringCommunity
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            serialCOMPortToolStripMenuItem = new ToolStripMenuItem();
            inputPatternToolStripMenuItem = new ToolStripMenuItem();
            connectionToServerToolStripMenuItem = new ToolStripMenuItem();
            utilityToolStripMenuItem = new ToolStripMenuItem();
            serialCOMPortMonitorToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelMain = new Panel();
            panel2 = new Panel();
            textBox6 = new TextBox();
            button6 = new Button();
            textBox5 = new TextBox();
            button5 = new Button();
            textBox4 = new TextBox();
            button4 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingToolStripMenuItem, utilityToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(772, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serialCOMPortToolStripMenuItem, inputPatternToolStripMenuItem, connectionToServerToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(56, 20);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // serialCOMPortToolStripMenuItem
            // 
            serialCOMPortToolStripMenuItem.Name = "serialCOMPortToolStripMenuItem";
            serialCOMPortToolStripMenuItem.Size = new Size(184, 22);
            serialCOMPortToolStripMenuItem.Text = "Serial COM port";
            serialCOMPortToolStripMenuItem.Click += serialCOMPortToolStripMenuItem_Click;
            // 
            // inputPatternToolStripMenuItem
            // 
            inputPatternToolStripMenuItem.Name = "inputPatternToolStripMenuItem";
            inputPatternToolStripMenuItem.Size = new Size(184, 22);
            inputPatternToolStripMenuItem.Text = "Input pattern";
            inputPatternToolStripMenuItem.Click += inputPatternToolStripMenuItem_Click;
            // 
            // connectionToServerToolStripMenuItem
            // 
            connectionToServerToolStripMenuItem.Name = "connectionToServerToolStripMenuItem";
            connectionToServerToolStripMenuItem.Size = new Size(184, 22);
            connectionToServerToolStripMenuItem.Text = "Connection to server";
            connectionToServerToolStripMenuItem.Click += connectionToServerToolStripMenuItem_Click;
            // 
            // utilityToolStripMenuItem
            // 
            utilityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serialCOMPortMonitorToolStripMenuItem });
            utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            utilityToolStripMenuItem.Size = new Size(50, 20);
            utilityToolStripMenuItem.Text = "Utility";
            // 
            // serialCOMPortMonitorToolStripMenuItem
            // 
            serialCOMPortMonitorToolStripMenuItem.Name = "serialCOMPortMonitorToolStripMenuItem";
            serialCOMPortMonitorToolStripMenuItem.Size = new Size(204, 22);
            serialCOMPortMonitorToolStripMenuItem.Text = "Serial COM port monitor";
            serialCOMPortMonitorToolStripMenuItem.Click += serialCOMPortMonitorToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.217617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.78239F));
            tableLayoutPanel1.Controls.Add(panelMain, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.044944F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95.9550552F));
            tableLayoutPanel1.Size = new Size(772, 445);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(244, 21);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(525, 421);
            panelMain.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 421);
            panel2.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(48, 170);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 23);
            textBox6.TabIndex = 1;
            // 
            // button6
            // 
            button6.Location = new Point(3, 169);
            button6.Name = "button6";
            button6.Size = new Size(39, 24);
            button6.TabIndex = 0;
            button6.Text = "Ch6";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(48, 141);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(3, 140);
            button5.Name = "button5";
            button5.Size = new Size(39, 24);
            button5.TabIndex = 0;
            button5.Text = "Ch5";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(48, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(3, 111);
            button4.Name = "button4";
            button4.Size = new Size(39, 24);
            button4.TabIndex = 0;
            button4.Text = "Ch4";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(48, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(3, 82);
            button3.Name = "button3";
            button3.Size = new Size(39, 24);
            button3.TabIndex = 0;
            button3.Text = "Ch3";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(3, 53);
            button2.Name = "button2";
            button2.Size = new Size(39, 24);
            button2.TabIndex = 0;
            button2.Text = "Ch2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 24);
            button1.Name = "button1";
            button1.Size = new Size(39, 24);
            button1.TabIndex = 0;
            button1.Text = "Ch1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 469);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Stock monitoring [ free version ]";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem serialCOMPortToolStripMenuItem;
        private ToolStripMenuItem inputPatternToolStripMenuItem;
        private ToolStripMenuItem connectionToServerToolStripMenuItem;
        private ToolStripMenuItem utilityToolStripMenuItem;
        private ToolStripMenuItem serialCOMPortMonitorToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelMain;
        private Panel panel2;
        private Button button1;
        private TextBox textBox6;
        private Button button6;
        private TextBox textBox5;
        private Button button5;
        private TextBox textBox4;
        private Button button4;
        private TextBox textBox3;
        private Button button3;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}
