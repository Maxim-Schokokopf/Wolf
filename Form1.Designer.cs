namespace Fahrzeug_Verwaltung_Wolf
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Hertseller = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.Typ = new System.Windows.Forms.TextBox();
            this.Kennzeichen = new System.Windows.Forms.TextBox();
            this.Preis = new System.Windows.Forms.TextBox();
            this.Hinzufügen = new System.Windows.Forms.Button();
            this.Entfernen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bestand = new System.Windows.Forms.Label();
            this.Speichern = new System.Windows.Forms.Button();
            this.Löschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 238);
            this.listBox1.TabIndex = 0;
            // 
            // Hertseller
            // 
            this.Hertseller.Location = new System.Drawing.Point(285, 109);
            this.Hertseller.Name = "Hertseller";
            this.Hertseller.Size = new System.Drawing.Size(102, 20);
            this.Hertseller.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(285, 135);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(102, 20);
            this.textBoxModel.TabIndex = 2;
            // 
            // Typ
            // 
            this.Typ.Location = new System.Drawing.Point(285, 161);
            this.Typ.Name = "Typ";
            this.Typ.Size = new System.Drawing.Size(102, 20);
            this.Typ.TabIndex = 3;
            // 
            // Kennzeichen
            // 
            this.Kennzeichen.Location = new System.Drawing.Point(285, 187);
            this.Kennzeichen.Name = "Kennzeichen";
            this.Kennzeichen.Size = new System.Drawing.Size(102, 20);
            this.Kennzeichen.TabIndex = 4;
            // 
            // Preis
            // 
            this.Preis.Location = new System.Drawing.Point(285, 213);
            this.Preis.Name = "Preis";
            this.Preis.Size = new System.Drawing.Size(102, 20);
            this.Preis.TabIndex = 5;
            // 
            // Hinzufügen
            // 
            this.Hinzufügen.Location = new System.Drawing.Point(53, 353);
            this.Hinzufügen.Name = "Hinzufügen";
            this.Hinzufügen.Size = new System.Drawing.Size(89, 31);
            this.Hinzufügen.TabIndex = 6;
            this.Hinzufügen.Text = "Hinzufügen";
            this.Hinzufügen.UseVisualStyleBackColor = true;
            this.Hinzufügen.Click += new System.EventHandler(this.Hinzufügen_Click);
            // 
            // Entfernen
            // 
            this.Entfernen.Location = new System.Drawing.Point(163, 353);
            this.Entfernen.Name = "Entfernen";
            this.Entfernen.Size = new System.Drawing.Size(91, 31);
            this.Entfernen.TabIndex = 7;
            this.Entfernen.Text = "Entfernen";
            this.Entfernen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autovermietung GmbH";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hersteller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Typ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kennzeichen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Preis";
            // 
            // Bestand
            // 
            this.Bestand.AutoSize = true;
            this.Bestand.Cursor = System.Windows.Forms.Cursors.No;
            this.Bestand.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bestand.ForeColor = System.Drawing.Color.Coral;
            this.Bestand.Location = new System.Drawing.Point(114, 89);
            this.Bestand.Name = "Bestand";
            this.Bestand.Size = new System.Drawing.Size(69, 17);
            this.Bestand.TabIndex = 14;
            this.Bestand.Text = "Bestand ";
            this.Bestand.Click += new System.EventHandler(this.label7_Click);
            // 
            // Speichern
            // 
            this.Speichern.Location = new System.Drawing.Point(285, 240);
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(102, 31);
            this.Speichern.TabIndex = 15;
            this.Speichern.Text = "Speichern";
            this.Speichern.UseVisualStyleBackColor = true;
            this.Speichern.Click += new System.EventHandler(this.Speichern_Click);
            // 
            // Löschen
            // 
            this.Löschen.ForeColor = System.Drawing.Color.DarkRed;
            this.Löschen.Location = new System.Drawing.Point(406, 244);
            this.Löschen.Name = "Löschen";
            this.Löschen.Size = new System.Drawing.Size(27, 27);
            this.Löschen.TabIndex = 16;
            this.Löschen.Text = "X";
            this.Löschen.UseVisualStyleBackColor = true;
            this.Löschen.Click += new System.EventHandler(this.Löschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 405);
            this.Controls.Add(this.Löschen);
            this.Controls.Add(this.Speichern);
            this.Controls.Add(this.Bestand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entfernen);
            this.Controls.Add(this.Hinzufügen);
            this.Controls.Add(this.Preis);
            this.Controls.Add(this.Kennzeichen);
            this.Controls.Add(this.Typ);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.Hertseller);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Hertseller;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox Typ;
        private System.Windows.Forms.TextBox Kennzeichen;
        private System.Windows.Forms.TextBox Preis;
        private System.Windows.Forms.Button Hinzufügen;
        private System.Windows.Forms.Button Entfernen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Bestand;
        private System.Windows.Forms.Button Speichern;
        private System.Windows.Forms.Button Löschen;
    }
}

