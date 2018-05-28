namespace Kapitel02_01
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
            this.lbxBibliotek = new System.Windows.Forms.ListBox();
            this.rdbBok = new System.Windows.Forms.RadioButton();
            this.rdbLjud = new System.Windows.Forms.RadioButton();
            this.rdbFilm = new System.Windows.Forms.RadioButton();
            this.lblBibliotek = new System.Windows.Forms.Label();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.tbxTitel = new System.Windows.Forms.TextBox();
            this.lblSidor = new System.Windows.Forms.Label();
            this.tbxSidor = new System.Windows.Forms.TextBox();
            this.lblSpeltid = new System.Windows.Forms.Label();
            this.tbxSpeltid = new System.Windows.Forms.TextBox();
            this.lblUpplosning = new System.Windows.Forms.Label();
            this.tbxUpplosning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxBibliotek
            // 
            this.lbxBibliotek.FormattingEnabled = true;
            this.lbxBibliotek.Location = new System.Drawing.Point(12, 153);
            this.lbxBibliotek.Name = "lbxBibliotek";
            this.lbxBibliotek.ScrollAlwaysVisible = true;
            this.lbxBibliotek.Size = new System.Drawing.Size(440, 225);
            this.lbxBibliotek.TabIndex = 0;
            // 
            // rdbBok
            // 
            this.rdbBok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbBok.AutoSize = true;
            this.rdbBok.Checked = true;
            this.rdbBok.Location = new System.Drawing.Point(342, 12);
            this.rdbBok.Name = "rdbBok";
            this.rdbBok.Size = new System.Drawing.Size(44, 17);
            this.rdbBok.TabIndex = 1;
            this.rdbBok.TabStop = true;
            this.rdbBok.Text = "Bok";
            this.rdbBok.UseVisualStyleBackColor = true;
            this.rdbBok.CheckedChanged += new System.EventHandler(this.rdbBok_CheckedChanged);
            // 
            // rdbLjud
            // 
            this.rdbLjud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbLjud.AutoSize = true;
            this.rdbLjud.Location = new System.Drawing.Point(342, 35);
            this.rdbLjud.Name = "rdbLjud";
            this.rdbLjud.Size = new System.Drawing.Size(65, 17);
            this.rdbLjud.TabIndex = 2;
            this.rdbLjud.Text = "Ljudspår";
            this.rdbLjud.UseVisualStyleBackColor = true;
            this.rdbLjud.CheckedChanged += new System.EventHandler(this.rdbLjud_CheckedChanged);
            // 
            // rdbFilm
            // 
            this.rdbFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFilm.AutoSize = true;
            this.rdbFilm.Location = new System.Drawing.Point(342, 58);
            this.rdbFilm.Name = "rdbFilm";
            this.rdbFilm.Size = new System.Drawing.Size(43, 17);
            this.rdbFilm.TabIndex = 3;
            this.rdbFilm.Text = "Film";
            this.rdbFilm.UseVisualStyleBackColor = true;
            this.rdbFilm.CheckedChanged += new System.EventHandler(this.rdbFilm_CheckedChanged);
            // 
            // lblBibliotek
            // 
            this.lblBibliotek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotek.Location = new System.Drawing.Point(12, 123);
            this.lblBibliotek.Name = "lblBibliotek";
            this.lblBibliotek.Size = new System.Drawing.Size(440, 28);
            this.lblBibliotek.TabIndex = 4;
            this.lblBibliotek.Text = "BIBLIOTEK";
            this.lblBibliotek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(338, 89);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(114, 23);
            this.btnRegistrera.TabIndex = 5;
            this.btnRegistrera.Text = "Registrera bok";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(13, 15);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(27, 13);
            this.lblTitel.TabIndex = 6;
            this.lblTitel.Text = "Titel";
            // 
            // tbxTitel
            // 
            this.tbxTitel.Location = new System.Drawing.Point(79, 12);
            this.tbxTitel.Name = "tbxTitel";
            this.tbxTitel.Size = new System.Drawing.Size(253, 20);
            this.tbxTitel.TabIndex = 7;
            // 
            // lblSidor
            // 
            this.lblSidor.AutoSize = true;
            this.lblSidor.Location = new System.Drawing.Point(13, 41);
            this.lblSidor.Name = "lblSidor";
            this.lblSidor.Size = new System.Drawing.Size(56, 13);
            this.lblSidor.TabIndex = 6;
            this.lblSidor.Text = "Antal sidor";
            // 
            // tbxSidor
            // 
            this.tbxSidor.Location = new System.Drawing.Point(79, 38);
            this.tbxSidor.Name = "tbxSidor";
            this.tbxSidor.Size = new System.Drawing.Size(253, 20);
            this.tbxSidor.TabIndex = 7;
            // 
            // lblSpeltid
            // 
            this.lblSpeltid.AutoSize = true;
            this.lblSpeltid.Location = new System.Drawing.Point(13, 67);
            this.lblSpeltid.Name = "lblSpeltid";
            this.lblSpeltid.Size = new System.Drawing.Size(55, 13);
            this.lblSpeltid.TabIndex = 6;
            this.lblSpeltid.Text = "Speltid i m";
            // 
            // tbxSpeltid
            // 
            this.tbxSpeltid.Enabled = false;
            this.tbxSpeltid.Location = new System.Drawing.Point(79, 64);
            this.tbxSpeltid.Name = "tbxSpeltid";
            this.tbxSpeltid.Size = new System.Drawing.Size(253, 20);
            this.tbxSpeltid.TabIndex = 7;
            // 
            // lblUpplosning
            // 
            this.lblUpplosning.AutoSize = true;
            this.lblUpplosning.Location = new System.Drawing.Point(13, 93);
            this.lblUpplosning.Name = "lblUpplosning";
            this.lblUpplosning.Size = new System.Drawing.Size(60, 13);
            this.lblUpplosning.TabIndex = 6;
            this.lblUpplosning.Text = "Upplösning";
            // 
            // tbxUpplosning
            // 
            this.tbxUpplosning.Enabled = false;
            this.tbxUpplosning.Location = new System.Drawing.Point(79, 90);
            this.tbxUpplosning.Name = "tbxUpplosning";
            this.tbxUpplosning.Size = new System.Drawing.Size(253, 20);
            this.tbxUpplosning.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 390);
            this.Controls.Add(this.tbxUpplosning);
            this.Controls.Add(this.tbxSpeltid);
            this.Controls.Add(this.lblUpplosning);
            this.Controls.Add(this.tbxSidor);
            this.Controls.Add(this.lblSpeltid);
            this.Controls.Add(this.tbxTitel);
            this.Controls.Add(this.lblSidor);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.lblBibliotek);
            this.Controls.Add(this.rdbFilm);
            this.Controls.Add(this.rdbLjud);
            this.Controls.Add(this.rdbBok);
            this.Controls.Add(this.lbxBibliotek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBibliotek;
        private System.Windows.Forms.RadioButton rdbBok;
        private System.Windows.Forms.RadioButton rdbLjud;
        private System.Windows.Forms.RadioButton rdbFilm;
        private System.Windows.Forms.Label lblBibliotek;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox tbxTitel;
        private System.Windows.Forms.Label lblSidor;
        private System.Windows.Forms.TextBox tbxSidor;
        private System.Windows.Forms.Label lblSpeltid;
        private System.Windows.Forms.TextBox tbxSpeltid;
        private System.Windows.Forms.Label lblUpplosning;
        private System.Windows.Forms.TextBox tbxUpplosning;
    }
}

