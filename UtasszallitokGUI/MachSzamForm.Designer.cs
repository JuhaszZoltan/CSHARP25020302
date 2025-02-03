namespace UtasszallitokGUI
{
    partial class MachSzamForm
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
            tbxTorlo = new TextBox();
            btnSzamol = new Button();
            lsbEredmenyek = new ListBox();
            lblUI02 = new Label();
            lblUI03 = new Label();
            tbxStatikus = new TextBox();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 14F);
            lblUI01.Location = new Point(42, 15);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(123, 25);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Torlónyomás:";
            // 
            // tbxTorlo
            // 
            tbxTorlo.Font = new Font("Segoe UI", 14F);
            tbxTorlo.Location = new Point(171, 12);
            tbxTorlo.Name = "tbxTorlo";
            tbxTorlo.Size = new Size(159, 32);
            tbxTorlo.TabIndex = 0;
            // 
            // btnSzamol
            // 
            btnSzamol.Font = new Font("Segoe UI", 14F);
            btnSzamol.Location = new Point(353, 12);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(119, 80);
            btnSzamol.TabIndex = 2;
            btnSzamol.Text = "Számol";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // lsbEredmenyek
            // 
            lsbEredmenyek.BorderStyle = BorderStyle.None;
            lsbEredmenyek.Font = new Font("Segoe UI", 14F);
            lsbEredmenyek.FormattingEnabled = true;
            lsbEredmenyek.ItemHeight = 25;
            lsbEredmenyek.Location = new Point(12, 149);
            lsbEredmenyek.Name = "lsbEredmenyek";
            lsbEredmenyek.Size = new Size(460, 300);
            lsbEredmenyek.TabIndex = 0;
            lsbEredmenyek.TabStop = false;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 14F);
            lblUI02.Location = new Point(15, 63);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(150, 25);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Statikus nyomás:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Font = new Font("Segoe UI", 14F);
            lblUI03.Location = new Point(12, 109);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(119, 25);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "Eredmények:";
            // 
            // tbxStatikus
            // 
            tbxStatikus.Font = new Font("Segoe UI", 14F);
            tbxStatikus.Location = new Point(171, 60);
            tbxStatikus.Name = "tbxStatikus";
            tbxStatikus.Size = new Size(159, 32);
            tbxStatikus.TabIndex = 1;
            // 
            // MachSzamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(lsbEredmenyek);
            Controls.Add(btnSzamol);
            Controls.Add(tbxStatikus);
            Controls.Add(tbxTorlo);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Name = "MachSzamForm";
            Text = "Mach-szám Kalkulátor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxTorlo;
        private Button btnSzamol;
        private ListBox lsbEredmenyek;
        private Label lblUI02;
        private Label lblUI03;
        private TextBox tbxStatikus;
    }
}
