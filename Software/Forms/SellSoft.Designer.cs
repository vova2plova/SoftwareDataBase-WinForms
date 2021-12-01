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
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SumPrice = new System.Windows.Forms.Label();
            this.StaffBox = new System.Windows.Forms.ComboBox();
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchByName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CartView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SoftView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartView)).BeginInit();
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(794, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Общая стоимость =";
            // 
            // SoftView
            // 
            this.SoftView.AllowUserToAddRows = false;
            this.SoftView.AllowUserToDeleteRows = false;
            this.SoftView.AllowUserToResizeColumns = false;
            this.SoftView.AllowUserToResizeRows = false;
            this.SoftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftView.Location = new System.Drawing.Point(12, 181);
            this.SoftView.Name = "SoftView";
            this.SoftView.ReadOnly = true;
            this.SoftView.RowTemplate.Height = 25;
            this.SoftView.Size = new System.Drawing.Size(710, 257);
            this.SoftView.TabIndex = 3;
            this.SoftView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SoftView_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовогоКлиентаToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
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
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // SumPrice
            // 
            this.SumPrice.AutoSize = true;
            this.SumPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumPrice.Location = new System.Drawing.Point(988, 59);
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.Size = new System.Drawing.Size(23, 28);
            this.SumPrice.TabIndex = 5;
            this.SumPrice.Text = "0";
            // 
            // StaffBox
            // 
            this.StaffBox.FormattingEnabled = true;
            this.StaffBox.Location = new System.Drawing.Point(84, 58);
            this.StaffBox.Name = "StaffBox";
            this.StaffBox.Size = new System.Drawing.Size(159, 23);
            this.StaffBox.TabIndex = 6;
            this.StaffBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StaffBox_KeyPress);
            // 
            // ClientBox
            // 
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(84, 87);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(159, 23);
            this.ClientBox.TabIndex = 7;
            this.ClientBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StaffBox_KeyPress);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 257);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить в корзину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CartView
            // 
            this.CartView.AllowUserToAddRows = false;
            this.CartView.AllowUserToDeleteRows = false;
            this.CartView.AllowUserToResizeColumns = false;
            this.CartView.AllowUserToResizeRows = false;
            this.CartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartView.Location = new System.Drawing.Point(794, 90);
            this.CartView.Name = "CartView";
            this.CartView.ReadOnly = true;
            this.CartView.RowTemplate.Height = 25;
            this.CartView.Size = new System.Drawing.Size(347, 348);
            this.CartView.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Выдать чек";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(794, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Корзина";
            // 
            // SellSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CartView);
            this.Controls.Add(this.button1);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellSoft_FormClosing);
            this.Load += new System.EventHandler(this.SellSoft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoftView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartView)).EndInit();
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
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private Button button1;
        private DataGridView CartView;
        private Button button2;
        private Label label5;
    }
}