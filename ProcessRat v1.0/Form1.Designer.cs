namespace ProcessRat_v1._0
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PrList = new System.Windows.Forms.ListView();
            this.PrID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Da = new System.Windows.Forms.Label();
            this.Wa = new System.Windows.Forms.Label();
            this.Sa = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.killDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrList
            // 
            this.PrList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PrID,
            this.PrName,
            this.PrPath});
            this.PrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrList.GridLines = true;
            this.PrList.HideSelection = false;
            this.PrList.Location = new System.Drawing.Point(3, 16);
            this.PrList.Name = "PrList";
            this.PrList.Size = new System.Drawing.Size(759, 461);
            this.PrList.TabIndex = 0;
            this.PrList.UseCompatibleStateImageBehavior = false;
            this.PrList.View = System.Windows.Forms.View.Details;
            this.PrList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.PrList_ColumnClick);
            this.PrList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrList_MouseClick);
            // 
            // PrID
            // 
            this.PrID.Text = "Process ID";
            this.PrID.Width = 79;
            // 
            // PrName
            // 
            this.PrName.Text = "Process Name";
            this.PrName.Width = 133;
            // 
            // PrPath
            // 
            this.PrPath.Text = "Process Path";
            this.PrPath.Width = 550;
            // 
            // Da
            // 
            this.Da.AutoSize = true;
            this.Da.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Da.ForeColor = System.Drawing.Color.Red;
            this.Da.Location = new System.Drawing.Point(21, 5);
            this.Da.Name = "Da";
            this.Da.Size = new System.Drawing.Size(131, 30);
            this.Da.TabIndex = 1;
            this.Da.Text = "Dangerous: 0";
            // 
            // Wa
            // 
            this.Wa.AutoSize = true;
            this.Wa.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wa.ForeColor = System.Drawing.Color.Orange;
            this.Wa.Location = new System.Drawing.Point(188, 5);
            this.Wa.Name = "Wa";
            this.Wa.Size = new System.Drawing.Size(123, 30);
            this.Wa.TabIndex = 2;
            this.Wa.Text = "Warnings: 0";
            // 
            // Sa
            // 
            this.Sa.AutoSize = true;
            this.Sa.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sa.ForeColor = System.Drawing.Color.LimeGreen;
            this.Sa.Location = new System.Drawing.Point(364, 5);
            this.Sa.Name = "Sa";
            this.Sa.Size = new System.Drawing.Size(72, 30);
            this.Sa.TabIndex = 3;
            this.Sa.Text = "Safe: 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tesetToolStripMenuItem,
            this.killDeleteToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.testToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 114);
            // 
            // tesetToolStripMenuItem
            // 
            this.tesetToolStripMenuItem.Name = "tesetToolStripMenuItem";
            this.tesetToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tesetToolStripMenuItem.Text = "Kill";
            this.tesetToolStripMenuItem.Click += new System.EventHandler(this.tesetToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.testToolStripMenuItem.Text = "Details";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.testToolStripMenuItem1.Text = "Open File Location";
            this.testToolStripMenuItem1.Click += new System.EventHandler(this.testToolStripMenuItem1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(501, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "AutoRefresh";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(673, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrList);
            this.groupBox1.Location = new System.Drawing.Point(10, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 480);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Rat";
            // 
            // killDeleteToolStripMenuItem
            // 
            this.killDeleteToolStripMenuItem.Name = "killDeleteToolStripMenuItem";
            this.killDeleteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.killDeleteToolStripMenuItem.Text = "Kill and Delete";
            this.killDeleteToolStripMenuItem.Click += new System.EventHandler(this.killDeleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Sa);
            this.Controls.Add(this.Wa);
            this.Controls.Add(this.Da);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Process Rat v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ListView PrList;
        private System.Windows.Forms.ColumnHeader PrID;
        private System.Windows.Forms.ColumnHeader PrName;
        private System.Windows.Forms.ColumnHeader PrPath;
        private System.Windows.Forms.Label Da;
        private System.Windows.Forms.Label Wa;
        private System.Windows.Forms.Label Sa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem killDeleteToolStripMenuItem;
    }
}

