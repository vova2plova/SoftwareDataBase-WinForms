namespace Software.Forms
{
    partial class EditStaff
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
            this.label4 = new System.Windows.Forms.Label();
            this.SecEdit = new System.Windows.Forms.TextBox();
            this.NameEdit = new System.Windows.Forms.TextBox();
            this.PatrEdit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NumberEdit = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер телефона";
            // 
            // SecEdit
            // 
            this.SecEdit.Location = new System.Drawing.Point(124, 9);
            this.SecEdit.Name = "SecEdit";
            this.SecEdit.Size = new System.Drawing.Size(146, 23);
            this.SecEdit.TabIndex = 4;
            this.SecEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecEdit_KeyPress);
            // 
            // NameEdit
            // 
            this.NameEdit.Location = new System.Drawing.Point(124, 46);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(146, 23);
            this.NameEdit.TabIndex = 5;
            this.NameEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecEdit_KeyPress);
            // 
            // PatrEdit
            // 
            this.PatrEdit.Location = new System.Drawing.Point(124, 82);
            this.PatrEdit.Name = "PatrEdit";
            this.PatrEdit.Size = new System.Drawing.Size(146, 23);
            this.PatrEdit.TabIndex = 6;
            this.PatrEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecEdit_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberEdit
            // 
            this.NumberEdit.Location = new System.Drawing.Point(124, 123);
            this.NumberEdit.Mask = "(999) 000-0000";
            this.NumberEdit.Name = "NumberEdit";
            this.NumberEdit.Size = new System.Drawing.Size(146, 23);
            this.NumberEdit.TabIndex = 9;
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 187);
            this.Controls.Add(this.NumberEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatrEdit);
            this.Controls.Add(this.NameEdit);
            this.Controls.Add(this.SecEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditStaff";
            this.Text = "AddStaff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditStaff_FormClosing);
            this.Load += new System.EventHandler(this.EditStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SecEdit;
        private TextBox NameEdit;
        private TextBox PatrEdit;
        private Button button1;
        private MaskedTextBox NumberEdit;
    }
}