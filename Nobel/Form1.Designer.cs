namespace Nobel
{
    partial class Form1
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
            this.rezultati = new System.Windows.Forms.ListBox();
            this.podrocja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leto = new System.Windows.Forms.TextBox();
            this.letolabel = new System.Windows.Forms.Label();
            this.poisci = new System.Windows.Forms.Button();
            this.naslov = new System.Windows.Forms.Label();
            this.pocisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rezultati
            // 
            this.rezultati.FormattingEnabled = true;
            this.rezultati.ItemHeight = 16;
            this.rezultati.Location = new System.Drawing.Point(84, 151);
            this.rezultati.Name = "rezultati";
            this.rezultati.Size = new System.Drawing.Size(347, 244);
            this.rezultati.TabIndex = 0;
            // 
            // podrocja
            // 
            this.podrocja.FormattingEnabled = true;
            this.podrocja.Items.AddRange(new object[] {
            "Chemistry",
            "Economics",
            "Literature",
            "Medicine",
            "Peace",
            "Physics"});
            this.podrocja.Location = new System.Drawing.Point(582, 282);
            this.podrocja.Name = "podrocja";
            this.podrocja.Size = new System.Drawing.Size(121, 24);
            this.podrocja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(537, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izberi področje:";
            // 
            // leto
            // 
            this.leto.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leto.Location = new System.Drawing.Point(647, 151);
            this.leto.Name = "leto";
            this.leto.Size = new System.Drawing.Size(121, 40);
            this.leto.TabIndex = 3;
            // 
            // letolabel
            // 
            this.letolabel.AutoSize = true;
            this.letolabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letolabel.Location = new System.Drawing.Point(497, 151);
            this.letolabel.Name = "letolabel";
            this.letolabel.Size = new System.Drawing.Size(144, 35);
            this.letolabel.TabIndex = 4;
            this.letolabel.Text = "Vnesi leto :";
            // 
            // poisci
            // 
            this.poisci.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poisci.Location = new System.Drawing.Point(647, 347);
            this.poisci.Name = "poisci";
            this.poisci.Size = new System.Drawing.Size(121, 48);
            this.poisci.TabIndex = 5;
            this.poisci.Text = "Poišči";
            this.poisci.UseVisualStyleBackColor = true;
            this.poisci.Click += new System.EventHandler(this.poisci_Click);
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.ForeColor = System.Drawing.Color.Gold;
            this.naslov.Location = new System.Drawing.Point(77, 39);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(626, 73);
            this.naslov.TabIndex = 6;
            this.naslov.Text = "NOBELOVI NAGRAJENCI";
            this.naslov.Click += new System.EventHandler(this.label3_Click);
            // 
            // pocisti
            // 
            this.pocisti.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocisti.Location = new System.Drawing.Point(503, 347);
            this.pocisti.Name = "pocisti";
            this.pocisti.Size = new System.Drawing.Size(121, 48);
            this.pocisti.TabIndex = 7;
            this.pocisti.Text = "Počisti";
            this.pocisti.UseVisualStyleBackColor = true;
            this.pocisti.Click += new System.EventHandler(this.pocisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pocisti);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.poisci);
            this.Controls.Add(this.letolabel);
            this.Controls.Add(this.leto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.podrocja);
            this.Controls.Add(this.rezultati);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rezultati;
        private System.Windows.Forms.ComboBox podrocja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leto;
        private System.Windows.Forms.Label letolabel;
        private System.Windows.Forms.Button poisci;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button pocisti;
    }
}

