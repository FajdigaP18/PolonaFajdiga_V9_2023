namespace Filmisql
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.vnesiLeto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vnesiOceno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.leto = new System.Windows.Forms.TextBox();
            this.ocena = new System.Windows.Forms.TextBox();
            this.poisci = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.rezultati = new System.Windows.Forms.Label();
            this.naslov = new System.Windows.Forms.Label();
            this.pocisti = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackgroundImage = global::Filmisql.Properties.Resources.movie1;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Moccasin;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(99, 154);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(378, 296);
            this.listBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Moccasin;
            this.flowLayoutPanel1.Controls.Add(this.vnesiLeto);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.vnesiOceno);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(483, 154);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 80);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // vnesiLeto
            // 
            this.vnesiLeto.AutoSize = true;
            this.vnesiLeto.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vnesiLeto.Location = new System.Drawing.Point(40, 0);
            this.vnesiLeto.Name = "vnesiLeto";
            this.vnesiLeto.Size = new System.Drawing.Size(169, 40);
            this.vnesiLeto.TabIndex = 0;
            this.vnesiLeto.Text = "Vnesi leto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // vnesiOceno
            // 
            this.vnesiOceno.AutoSize = true;
            this.vnesiOceno.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vnesiOceno.Location = new System.Drawing.Point(9, 40);
            this.vnesiOceno.Name = "vnesiOceno";
            this.vnesiOceno.Size = new System.Drawing.Size(200, 40);
            this.vnesiOceno.TabIndex = 2;
            this.vnesiOceno.Text = "Vnesi oceno: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Moccasin;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel2.Controls.Add(this.leto);
            this.flowLayoutPanel2.Controls.Add(this.ocena);
            this.flowLayoutPanel2.Controls.Add(this.poisci);
            this.flowLayoutPanel2.Controls.Add(this.pocisti);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(723, 154);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(157, 242);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // leto
            // 
            this.leto.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leto.Location = new System.Drawing.Point(3, 3);
            this.leto.Name = "leto";
            this.leto.Size = new System.Drawing.Size(151, 48);
            this.leto.TabIndex = 0;
            // 
            // ocena
            // 
            this.ocena.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ocena.Location = new System.Drawing.Point(3, 57);
            this.ocena.Name = "ocena";
            this.ocena.Size = new System.Drawing.Size(151, 48);
            this.ocena.TabIndex = 1;
            // 
            // poisci
            // 
            this.poisci.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poisci.Location = new System.Drawing.Point(3, 111);
            this.poisci.Name = "poisci";
            this.poisci.Size = new System.Drawing.Size(151, 61);
            this.poisci.TabIndex = 2;
            this.poisci.Text = "Poišči";
            this.poisci.UseVisualStyleBackColor = true;
            this.poisci.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Moccasin;
            this.flowLayoutPanel3.Controls.Add(this.rezultati);
            this.flowLayoutPanel3.Controls.Add(this.naslov);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(99, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(378, 145);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // rezultati
            // 
            this.rezultati.AutoSize = true;
            this.rezultati.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezultati.Location = new System.Drawing.Point(3, 117);
            this.rezultati.Name = "rezultati";
            this.rezultati.Size = new System.Drawing.Size(102, 28);
            this.rezultati.TabIndex = 0;
            this.rezultati.Text = "Rezultati:";
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.Location = new System.Drawing.Point(3, 27);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(284, 90);
            this.naslov.TabIndex = 1;
            this.naslov.Text = "Iskanje filmov za določeno leto:";
            // 
            // pocisti
            // 
            this.pocisti.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocisti.Location = new System.Drawing.Point(3, 178);
            this.pocisti.Name = "pocisti";
            this.pocisti.Size = new System.Drawing.Size(151, 61);
            this.pocisti.TabIndex = 4;
            this.pocisti.Text = "Počisti";
            this.pocisti.UseVisualStyleBackColor = true;
            this.pocisti.Click += new System.EventHandler(this.pocisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label vnesiLeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox leto;
        private System.Windows.Forms.TextBox ocena;
        private System.Windows.Forms.Label vnesiOceno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button poisci;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label rezultati;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button pocisti;
    }
}

