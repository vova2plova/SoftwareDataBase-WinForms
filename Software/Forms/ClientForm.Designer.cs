namespace Software.Forms
{
    partial class ClientForm
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
            this.ClientView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientView
            // 
            this.ClientView.AllowUserToAddRows = false;
            this.ClientView.AllowUserToDeleteRows = false;
            this.ClientView.AllowUserToResizeColumns = false;
            this.ClientView.AllowUserToResizeRows = false;
            this.ClientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientView.Location = new System.Drawing.Point(12, 57);
            this.ClientView.MultiSelect = false;
            this.ClientView.Name = "ClientView";
            this.ClientView.ReadOnly = true;
            this.ClientView.RowTemplate.Height = 25;
            this.ClientView.Size = new System.Drawing.Size(776, 381);
            this.ClientView.TabIndex = 0;
            this.ClientView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКлиентаToolStripMenuItem,
            this.удалитьКлиентаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьКлиентаToolStripMenuItem
            // 
            this.добавитьКлиентаToolStripMenuItem.Name = "добавитьКлиентаToolStripMenuItem";
            this.добавитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.добавитьКлиентаToolStripMenuItem.Text = "Добавить клиента";
            this.добавитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлиентаToolStripMenuItem_Click);
            // 
            // удалитьКлиентаToolStripMenuItem
            // 
            this.удалитьКлиентаToolStripMenuItem.Name = "удалитьКлиентаToolStripMenuItem";
            this.удалитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.удалитьКлиентаToolStripMenuItem.Text = "Удалить выбранного клиента";
            this.удалитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьКлиентаToolStripMenuItem_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ClientView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьКлиентаToolStripMenuItem;
        private ToolStripMenuItem удалитьКлиентаToolStripMenuItem;
    }
}