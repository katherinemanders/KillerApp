namespace KillerApp_KatherineManders
{
    partial class KillerApp
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
            this.Film = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.btnZoekTags = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFotograaf = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblKleur = new System.Windows.Forms.Label();
            this.lblASA = new System.Windows.Forms.Label();
            this.tbFotograaf = new System.Windows.Forms.TextBox();
            this.btnZoekFotograaf = new System.Windows.Forms.Button();
            this.lblSluiter = new System.Windows.Forms.Label();
            this.lblDiafragma = new System.Windows.Forms.Label();
            this.lblFlits = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandpunt = new System.Windows.Forms.Label();
            this.lblfotos = new System.Windows.Forms.Label();
            this.lblAantalFotos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(362, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fotograaf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(362, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Website";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(362, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Locatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(362, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum";
            // 
            // Film
            // 
            this.Film.AutoSize = true;
            this.Film.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Film.Location = new System.Drawing.Point(362, 307);
            this.Film.Name = "Film";
            this.Film.Size = new System.Drawing.Size(25, 13);
            this.Film.TabIndex = 4;
            this.Film.Text = "Film";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(28, 179);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(307, 373);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 5;
            this.pbPhoto.TabStop = false;
            // 
            // clbTags
            // 
            this.clbTags.FormattingEnabled = true;
            this.clbTags.Location = new System.Drawing.Point(28, 22);
            this.clbTags.Name = "clbTags";
            this.clbTags.Size = new System.Drawing.Size(83, 109);
            this.clbTags.TabIndex = 6;
            // 
            // btnZoekTags
            // 
            this.btnZoekTags.Location = new System.Drawing.Point(28, 137);
            this.btnZoekTags.Name = "btnZoekTags";
            this.btnZoekTags.Size = new System.Drawing.Size(83, 23);
            this.btnZoekTags.TabIndex = 7;
            this.btnZoekTags.Text = "Zoek op Tags";
            this.btnZoekTags.UseVisualStyleBackColor = true;
            this.btnZoekTags.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(414, 518);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(75, 23);
            this.btnVolgende.TabIndex = 8;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLocatie.Location = new System.Drawing.Point(448, 243);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(35, 13);
            this.lblLocatie.TabIndex = 10;
            this.lblLocatie.Text = "label6";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWebsite.Location = new System.Drawing.Point(448, 220);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(35, 13);
            this.lblWebsite.TabIndex = 11;
            this.lblWebsite.Text = "label7";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDatum.Location = new System.Drawing.Point(448, 265);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(35, 13);
            this.lblDatum.TabIndex = 12;
            this.lblDatum.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(362, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Kleur";
            // 
            // lblFotograaf
            // 
            this.lblFotograaf.AutoSize = true;
            this.lblFotograaf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFotograaf.Location = new System.Drawing.Point(448, 179);
            this.lblFotograaf.Name = "lblFotograaf";
            this.lblFotograaf.Size = new System.Drawing.Size(41, 13);
            this.lblFotograaf.TabIndex = 14;
            this.lblFotograaf.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(362, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Flits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(362, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Diafragma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(362, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sluitertijd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(362, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ASA";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFilm.Location = new System.Drawing.Point(448, 307);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(41, 13);
            this.lblFilm.TabIndex = 19;
            this.lblFilm.Text = "label10";
            // 
            // lblKleur
            // 
            this.lblKleur.AutoSize = true;
            this.lblKleur.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKleur.Location = new System.Drawing.Point(448, 330);
            this.lblKleur.Name = "lblKleur";
            this.lblKleur.Size = new System.Drawing.Size(41, 13);
            this.lblKleur.TabIndex = 20;
            this.lblKleur.Text = "label10";
            // 
            // lblASA
            // 
            this.lblASA.AutoSize = true;
            this.lblASA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblASA.Location = new System.Drawing.Point(448, 354);
            this.lblASA.Name = "lblASA";
            this.lblASA.Size = new System.Drawing.Size(41, 13);
            this.lblASA.TabIndex = 21;
            this.lblASA.Text = "label10";
            // 
            // tbFotograaf
            // 
            this.tbFotograaf.Location = new System.Drawing.Point(139, 111);
            this.tbFotograaf.Name = "tbFotograaf";
            this.tbFotograaf.Size = new System.Drawing.Size(133, 20);
            this.tbFotograaf.TabIndex = 22;
            // 
            // btnZoekFotograaf
            // 
            this.btnZoekFotograaf.Location = new System.Drawing.Point(139, 137);
            this.btnZoekFotograaf.Name = "btnZoekFotograaf";
            this.btnZoekFotograaf.Size = new System.Drawing.Size(133, 23);
            this.btnZoekFotograaf.TabIndex = 23;
            this.btnZoekFotograaf.Text = "Zoek op Fotograaf";
            this.btnZoekFotograaf.UseVisualStyleBackColor = true;
            this.btnZoekFotograaf.Click += new System.EventHandler(this.btnZoekFotograaf_Click);
            // 
            // lblSluiter
            // 
            this.lblSluiter.AutoSize = true;
            this.lblSluiter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSluiter.Location = new System.Drawing.Point(448, 376);
            this.lblSluiter.Name = "lblSluiter";
            this.lblSluiter.Size = new System.Drawing.Size(41, 13);
            this.lblSluiter.TabIndex = 24;
            this.lblSluiter.Text = "label10";
            // 
            // lblDiafragma
            // 
            this.lblDiafragma.AutoSize = true;
            this.lblDiafragma.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDiafragma.Location = new System.Drawing.Point(448, 400);
            this.lblDiafragma.Name = "lblDiafragma";
            this.lblDiafragma.Size = new System.Drawing.Size(41, 13);
            this.lblDiafragma.TabIndex = 25;
            this.lblDiafragma.Text = "label10";
            // 
            // lblFlits
            // 
            this.lblFlits.AutoSize = true;
            this.lblFlits.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFlits.Location = new System.Drawing.Point(448, 424);
            this.lblFlits.Name = "lblFlits";
            this.lblFlits.Size = new System.Drawing.Size(41, 13);
            this.lblFlits.TabIndex = 26;
            this.lblFlits.Text = "label10";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBrand.Location = new System.Drawing.Point(448, 447);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(41, 13);
            this.lblBrand.TabIndex = 28;
            this.lblBrand.Text = "label10";
            // 
            // lblBrandpunt
            // 
            this.lblBrandpunt.AutoSize = true;
            this.lblBrandpunt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBrandpunt.Location = new System.Drawing.Point(362, 447);
            this.lblBrandpunt.Name = "lblBrandpunt";
            this.lblBrandpunt.Size = new System.Drawing.Size(56, 13);
            this.lblBrandpunt.TabIndex = 27;
            this.lblBrandpunt.Text = "Brandpunt";
            // 
            // lblfotos
            // 
            this.lblfotos.AutoSize = true;
            this.lblfotos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblfotos.Location = new System.Drawing.Point(362, 199);
            this.lblfotos.Name = "lblfotos";
            this.lblfotos.Size = new System.Drawing.Size(65, 13);
            this.lblfotos.TabIndex = 29;
            this.lblfotos.Text = "Aantal foto\'s";
            // 
            // lblAantalFotos
            // 
            this.lblAantalFotos.AutoSize = true;
            this.lblAantalFotos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAantalFotos.Location = new System.Drawing.Point(448, 199);
            this.lblAantalFotos.Name = "lblAantalFotos";
            this.lblAantalFotos.Size = new System.Drawing.Size(0, 13);
            this.lblAantalFotos.TabIndex = 30;
            // 
            // KillerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(649, 585);
            this.Controls.Add(this.lblAantalFotos);
            this.Controls.Add(this.lblfotos);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblBrandpunt);
            this.Controls.Add(this.lblFlits);
            this.Controls.Add(this.lblDiafragma);
            this.Controls.Add(this.lblSluiter);
            this.Controls.Add(this.btnZoekFotograaf);
            this.Controls.Add(this.tbFotograaf);
            this.Controls.Add(this.lblASA);
            this.Controls.Add(this.lblKleur);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFotograaf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.btnZoekTags);
            this.Controls.Add(this.clbTags);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.Film);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KillerApp";
            this.Text = "KillerApp";
            this.Load += new System.EventHandler(this.KillerApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Film;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.CheckedListBox clbTags;
        private System.Windows.Forms.Button btnZoekTags;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFotograaf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblKleur;
        private System.Windows.Forms.Label lblASA;
        private System.Windows.Forms.TextBox tbFotograaf;
        private System.Windows.Forms.Button btnZoekFotograaf;
        private System.Windows.Forms.Label lblSluiter;
        private System.Windows.Forms.Label lblDiafragma;
        private System.Windows.Forms.Label lblFlits;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandpunt;
        private System.Windows.Forms.Label lblfotos;
        private System.Windows.Forms.Label lblAantalFotos;
    }
}

