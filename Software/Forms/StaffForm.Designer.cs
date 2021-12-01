namespace Software.Forms
{
    partial class StaffForm
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
            this.StaffView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранногоСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffView
            // 
            this.StaffView.AllowUserToAddRows = false;
            this.StaffView.AllowUserToDeleteRows = false;
            this.StaffView.AllowUserToResizeColumns = false;
            this.StaffView.AllowUserToResizeRows = false;
            this.StaffView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffView.Location = new System.Drawing.Point(12, 27);
            this.StaffView.MultiSelect = false;
            this.StaffView.Name = "StaffView";
            this.StaffView.ReadOnly = true;
            this.StaffView.RowTemplate.Height = 25;
            this.StaffView.Size = new System.Drawing.Size(776, 411);
            this.StaffView.TabIndex = 0;
            this.StaffView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffView_CellClick);
            this.StaffView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffView_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem,
            this.удалитьВыбранногоСотрудникаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Добавить сотрудника";
            this.добавитьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСотрудникаToolStripMenuItem_Click);
            // 
            // удалитьВыбранногоСотрудникаToolStripMenuItem
            // 
            this.удалитьВыбранногоСотрудникаToolStripMenuItem.Name = "удалитьВыбранногоСотрудникаToolStripMenuItem";
            this.удалитьВыбранногоСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(200, 20);
            this.удалитьВыбранногоСотрудникаToolStripMenuItem.Text = "Удалить выбранного сотрудника";
            this.удалитьВыбранногоСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранногоСотрудникаToolStripMenuItem_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaffView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView StaffView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьСотрудникаToolStripMenuItem;
        private ToolStripMenuItem удалитьВыбранногоСотрудникаToolStripMenuItem;
    }
}