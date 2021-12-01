namespace Software.Forms
{
    partial class ContractForm
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
            this.ContractView = new System.Windows.Forms.DataGridView();
            this.SoftView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программноеОбеспечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продатьПрограммноеОбеспечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ContractView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContractView
            // 
            this.ContractView.AllowUserToAddRows = false;
            this.ContractView.AllowUserToDeleteRows = false;
            this.ContractView.AllowUserToResizeColumns = false;
            this.ContractView.AllowUserToResizeRows = false;
            this.ContractView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractView.Location = new System.Drawing.Point(12, 68);
            this.ContractView.Name = "ContractView";
            this.ContractView.ReadOnly = true;
            this.ContractView.RowTemplate.Height = 25;
            this.ContractView.Size = new System.Drawing.Size(780, 487);
            this.ContractView.TabIndex = 0;
            this.ContractView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContractView_CellClick);
            // 
            // SoftView
            // 
            this.SoftView.AllowUserToAddRows = false;
            this.SoftView.AllowUserToDeleteRows = false;
            this.SoftView.AllowUserToResizeColumns = false;
            this.SoftView.AllowUserToResizeRows = false;
            this.SoftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftView.Location = new System.Drawing.Point(798, 68);
            this.SoftView.Name = "SoftView";
            this.SoftView.ReadOnly = true;
            this.SoftView.RowTemplate.Height = 25;
            this.SoftView.Size = new System.Drawing.Size(518, 487);
            this.SoftView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программноеОбеспечениеToolStripMenuItem,
            this.продатьПрограммноеОбеспечениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программноеОбеспечениеToolStripMenuItem
            // 
            this.программноеОбеспечениеToolStripMenuItem.Name = "программноеОбеспечениеToolStripMenuItem";
            this.программноеОбеспечениеToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.программноеОбеспечениеToolStripMenuItem.Text = "Программное обеспечение";
            this.программноеОбеспечениеToolStripMenuItem.Click += new System.EventHandler(this.программноеОбеспечениеToolStripMenuItem_Click);
            // 
            // продатьПрограммноеОбеспечениеToolStripMenuItem
            // 
            this.продатьПрограммноеОбеспечениеToolStripMenuItem.Name = "продатьПрограммноеОбеспечениеToolStripMenuItem";
            this.продатьПрограммноеОбеспечениеToolStripMenuItem.Size = new System.Drawing.Size(222, 20);
            this.продатьПрограммноеОбеспечениеToolStripMenuItem.Text = "Продать Программное обеспечение";
            this.продатьПрограммноеОбеспечениеToolStripMenuItem.Click += new System.EventHandler(this.продатьПрограммноеОбеспечениеToolStripMenuItem_Click);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 567);
            this.Controls.Add(this.SoftView);
            this.Controls.Add(this.ContractView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContractForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SoftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContractView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ContractView;
        private DataGridView SoftView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem программноеОбеспечениеToolStripMenuItem;
        private ToolStripMenuItem продатьПрограммноеОбеспечениеToolStripMenuItem;
    }
}