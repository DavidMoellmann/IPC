namespace IP_Rechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ip = new System.Windows.Forms.TextBox();
            this.ipb = new System.Windows.Forms.TextBox();
            this.mskb = new System.Windows.Forms.TextBox();
            this.nab = new System.Windows.Forms.TextBox();
            this.nad = new System.Windows.Forms.TextBox();
            this.bab = new System.Windows.Forms.TextBox();
            this.bad = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msk = new System.Windows.Forms.TextBox();
            this.clr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(12, 25);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(387, 20);
            this.ip.TabIndex = 0;
            // 
            // ipb
            // 
            this.ipb.Location = new System.Drawing.Point(12, 64);
            this.ipb.Name = "ipb";
            this.ipb.Size = new System.Drawing.Size(650, 20);
            this.ipb.TabIndex = 1;
            // 
            // mskb
            // 
            this.mskb.Location = new System.Drawing.Point(12, 103);
            this.mskb.Name = "mskb";
            this.mskb.Size = new System.Drawing.Size(650, 20);
            this.mskb.TabIndex = 2;
            // 
            // nab
            // 
            this.nab.Location = new System.Drawing.Point(12, 146);
            this.nab.Name = "nab";
            this.nab.Size = new System.Drawing.Size(650, 20);
            this.nab.TabIndex = 3;
            // 
            // nad
            // 
            this.nad.Location = new System.Drawing.Point(12, 185);
            this.nad.Name = "nad";
            this.nad.Size = new System.Drawing.Size(650, 20);
            this.nad.TabIndex = 4;
            // 
            // bab
            // 
            this.bab.Location = new System.Drawing.Point(12, 228);
            this.bab.Name = "bab";
            this.bab.Size = new System.Drawing.Size(650, 20);
            this.bab.TabIndex = 5;
            // 
            // bad
            // 
            this.bad.Location = new System.Drawing.Point(12, 271);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(650, 20);
            this.bad.TabIndex = 6;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(587, 297);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 7;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP/Maske";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IP Binär";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Maske Binär";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Netz-Adr. Binär";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Netz-Adr. Dezimal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Broadcast-Adr. Binär";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Broadcast-Adr. Dezimal";
            // 
            // msk
            // 
            this.msk.Location = new System.Drawing.Point(405, 24);
            this.msk.Name = "msk";
            this.msk.Size = new System.Drawing.Size(257, 20);
            this.msk.TabIndex = 15;
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(506, 297);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 23);
            this.clr.TabIndex = 16;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 330);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.msk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.bab);
            this.Controls.Add(this.nad);
            this.Controls.Add(this.nab);
            this.Controls.Add(this.mskb);
            this.Controls.Add(this.ipb);
            this.Controls.Add(this.ip);
            this.Name = "Form1";
            this.Text = "IP-Rechner v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox ipb;
        private System.Windows.Forms.TextBox mskb;
        private System.Windows.Forms.TextBox nab;
        private System.Windows.Forms.TextBox nad;
        private System.Windows.Forms.TextBox bab;
        private System.Windows.Forms.TextBox bad;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox msk;
        private System.Windows.Forms.Button clr;
    }
}

