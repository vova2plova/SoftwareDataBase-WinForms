namespace Software.Forms
{
    partial class SoftForm
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
            this.SoftView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SoftView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoftView
            // 
            this.SoftView.AllowUserToAddRows = false;
            this.SoftView.AllowUserToDeleteRows = false;
            this.SoftView.AllowUserToResizeColumns = false;
            this.SoftView.AllowUserToResizeRows = false;
            this.SoftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftView.Location = new System.Drawing.Point(12, 50);
            this.SoftView.MultiSelect = false;
            this.SoftView.Name = "SoftView";
            this.SoftView.ReadOnly = true;
            this.SoftView.RowTemplate.Height = 25;
            this.SoftView.Size = new System.Drawing.Size(776, 388);
            this.SoftView.TabIndex = 0;
            this.SoftView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SoftView_CellClick);
            this.SoftView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SoftView_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПОToolStripMenuItem,
            this.удалитьПОToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьПОToolStripMenuItem
            // 
            this.добавитьПОToolStripMenuItem.Name = "добавитьПОToolStripMenuItem";
            this.добавитьПОToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.добавитьПОToolStripMenuItem.Text = "Добавить ПО";
            this.добавитьПОToolStripMenuItem.Click += new System.EventHandler(this.добавитьПОToolStripMenuItem_Click);
            // 
            // удалитьПОToolStripMenuItem
            // 
            this.удалитьПОToolStripMenuItem.Name = "удалитьПОToolStripMenuItem";
            this.удалитьПОToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.удалитьПОToolStripMenuItem.Text = "Удалить ПО";
            this.удалитьПОToolStripMenuItem.Click += new System.EventHandler(this.удалитьПОToolStripMenuItem_Click);
            // 
            // SoftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SoftView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SoftForm";
            this.Text = "SoftForm";
            this.Load += new System.EventHandler(this.SoftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoftView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView SoftView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьПОToolStripMenuItem;
        private ToolStripMenuItem удалитьПОToolStripMenuItem;
    }
}