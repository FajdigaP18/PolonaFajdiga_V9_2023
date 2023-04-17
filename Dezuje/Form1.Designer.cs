namespace Dezuje
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
            this.components = new System.ComponentModel.Container();
            this.slika = new System.Windows.Forms.PictureBox();
            this.dogodek = new System.Windows.Forms.Timer(this.components);
            this.zacni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // slika
            // 
            this.slika.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.slika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slika.Location = new System.Drawing.Point(0, 0);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(800, 450);
            this.slika.TabIndex = 0;
            this.slika.TabStop = false;
            this.slika.Click += new System.EventHandler(this.slika_Click);
            this.slika.Paint += new System.Windows.Forms.PaintEventHandler(this.slika_Paint);
            // 
            // dogodek
            // 
            this.dogodek.Interval = 1;
            this.dogodek.Tick += new System.EventHandler(this.dogodek_Tick);
            // 
            // zacni
            // 
            this.zacni.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zacni.Location = new System.Drawing.Point(326, 150);
            this.zacni.Name = "zacni";
            this.zacni.Size = new System.Drawing.Size(150, 68);
            this.zacni.TabIndex = 1;
            this.zacni.Text = "Začni";
            this.zacni.UseVisualStyleBackColor = true;
            this.zacni.Click += new System.EventHandler(this.zacni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zacni);
            this.Controls.Add(this.slika);
            this.Name = "Form1";
            this.Text = "Dezuje :(";
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.Timer dogodek;
        private System.Windows.Forms.Button zacni;
    }
}

