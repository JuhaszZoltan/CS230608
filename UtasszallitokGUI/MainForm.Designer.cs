namespace UtasszallitokGUI
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
            lblUI01 = new Label();
            txtTorloNyomas = new TextBox();
            btnSzamol = new Button();
            lsbEredmenyek = new ListBox();
            lblUI02 = new Label();
            lblUI03 = new Label();
            txtStatikusNyomas = new TextBox();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 34);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(78, 15);
            lblUI01.TabIndex = 99;
            lblUI01.Text = "Torlónyomás:";
            // 
            // txtTorloNyomas
            // 
            txtTorloNyomas.Location = new Point(114, 31);
            txtTorloNyomas.Name = "txtTorloNyomas";
            txtTorloNyomas.Size = new Size(112, 23);
            txtTorloNyomas.TabIndex = 0;
            // 
            // btnSzamol
            // 
            btnSzamol.Location = new Point(246, 31);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(98, 59);
            btnSzamol.TabIndex = 2;
            btnSzamol.Text = "Számol";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // lsbEredmenyek
            // 
            lsbEredmenyek.FormattingEnabled = true;
            lsbEredmenyek.ItemHeight = 15;
            lsbEredmenyek.Location = new Point(12, 131);
            lsbEredmenyek.Name = "lsbEredmenyek";
            lsbEredmenyek.Size = new Size(332, 289);
            lsbEredmenyek.TabIndex = 3;
            lsbEredmenyek.TabStop = false;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(12, 70);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(96, 15);
            lblUI02.TabIndex = 99;
            lblUI02.Text = "Statikus nyomás:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(12, 113);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(75, 15);
            lblUI03.TabIndex = 99;
            lblUI03.Text = "Eredmények:";
            // 
            // txtStatikusNyomas
            // 
            txtStatikusNyomas.Location = new Point(114, 67);
            txtStatikusNyomas.Name = "txtStatikusNyomas";
            txtStatikusNyomas.Size = new Size(112, 23);
            txtStatikusNyomas.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 434);
            Controls.Add(lsbEredmenyek);
            Controls.Add(btnSzamol);
            Controls.Add(txtStatikusNyomas);
            Controls.Add(txtTorloNyomas);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Name = "MainForm";
            Text = "Mach-szám kalkulátor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox txtTorloNyomas;
        private Button btnSzamol;
        private ListBox lsbEredmenyek;
        private Label lblUI02;
        private Label lblUI03;
        private TextBox txtStatikusNyomas;
    }
}