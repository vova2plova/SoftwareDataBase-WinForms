namespace Software.Forms
{
    partial class SellSoft
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SoftView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьНовогоКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SumPrice = new System.Windows.Forms.Label();
            this.StaffBox = new System.Windows.Forms.ComboBox();
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchByName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SoftView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Общая стоимость =";
            // 
            // SoftView
            // 
            this.SoftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftView.Location = new System.Drawing.Point(12, 181);
            this.SoftView.Name = "SoftView";
            this.SoftView.RowTemplate.Height = 25;
            this.SoftView.Size = new System.Drawing.Size(776, 257);
            this.SoftView.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовогоКлиентаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьНовогоКлиентаToolStripMenuItem
            // 
            this.добавитьНовогоКлиентаToolStripMenuItem.Name = "добавитьНовогоКлиентаToolStripMenuItem";
            this.добавитьНовогоКлиентаToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.добавитьНовогоКлиентаToolStripMenuItem.Text = "Клиенты";
            this.добавитьНовогоКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовогоКлиентаToolStripMenuItem_Click);
            // 
            // SumPrice
            // 
            this.SumPrice.AutoSize = true;
            this.SumPrice.Location = new System.Drawing.Point(637, 163);
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.Size = new System.Drawing.Size(0, 15);
            this.SumPrice.TabIndex = 5;
            // 
            // StaffBox
            // 
            this.StaffBox.FormattingEnabled = true;
            this.StaffBox.Location = new System.Drawing.Point(84, 58);
            this.StaffBox.Name = "StaffBox";
            this.StaffBox.Size = new System.Drawing.Size(159, 23);
            this.StaffBox.TabIndex = 6;
            // 
            // ClientBox
            // 
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(84, 87);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(159, 23);
            this.ClientBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поиск по названию ПО";
            // 
            // SearchByName
            // 
            this.SearchByName.Location = new System.Drawing.Point(155, 155);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(236, 23);
            this.SearchByName.TabIndex = 9;
            this.SearchByName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // SellSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.StaffBox);
            this.Controls.Add(this.SumPrice);
            this.Controls.Add(this.SoftView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SellSoft";
            this.Text = "SellSoft";
            this.Load += new System.EventHandler(this.SellSoft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoftView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView SoftView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьНовогоКлиентаToolStripMenuItem;
        private Label SumPrice;
        private ComboBox StaffBox;
        private ComboBox ClientBox;
        private Label label4;
        private TextBox SearchByName;
    }
}