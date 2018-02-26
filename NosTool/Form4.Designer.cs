namespace NosTool
{
    partial class benefCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(benefCalc));
            this.benefFinal = new System.Windows.Forms.TextBox();
            this.prixGeante = new System.Windows.Forms.TextBox();
            this.prixFlacon = new System.Windows.Forms.TextBox();
            this.prixPotion = new System.Windows.Forms.TextBox();
            this.prixMaquereau = new System.Windows.Forms.TextBox();
            this.fullDepart = new System.Windows.Forms.TextBox();
            this.maquereau = new System.Windows.Forms.PictureBox();
            this.geante = new System.Windows.Forms.PictureBox();
            this.potionMagique = new System.Windows.Forms.PictureBox();
            this.flacon = new System.Windows.Forms.PictureBox();
            this.fullPotion = new System.Windows.Forms.PictureBox();
            this.quantiteProd = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.calcul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maquereau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionMagique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flacon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullPotion)).BeginInit();
            this.SuspendLayout();
            // 
            // benefFinal
            // 
            this.benefFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benefFinal.Location = new System.Drawing.Point(334, 339);
            this.benefFinal.Name = "benefFinal";
            this.benefFinal.ReadOnly = true;
            this.benefFinal.Size = new System.Drawing.Size(100, 29);
            this.benefFinal.TabIndex = 0;
            // 
            // prixGeante
            // 
            this.prixGeante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixGeante.Location = new System.Drawing.Point(90, 103);
            this.prixGeante.Name = "prixGeante";
            this.prixGeante.Size = new System.Drawing.Size(115, 29);
            this.prixGeante.TabIndex = 1;
            this.prixGeante.Text = "0";
            this.prixGeante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prixGeante.TextChanged += new System.EventHandler(this.full1_TextChanged);
            // 
            // prixFlacon
            // 
            this.prixFlacon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prixFlacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixFlacon.Location = new System.Drawing.Point(90, 158);
            this.prixFlacon.Name = "prixFlacon";
            this.prixFlacon.ReadOnly = true;
            this.prixFlacon.Size = new System.Drawing.Size(115, 29);
            this.prixFlacon.TabIndex = 2;
            this.prixFlacon.Text = "500";
            this.prixFlacon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prixFlacon.TextChanged += new System.EventHandler(this.full2_TextChanged);
            // 
            // prixPotion
            // 
            this.prixPotion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prixPotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixPotion.Location = new System.Drawing.Point(90, 214);
            this.prixPotion.Name = "prixPotion";
            this.prixPotion.ReadOnly = true;
            this.prixPotion.Size = new System.Drawing.Size(115, 29);
            this.prixPotion.TabIndex = 3;
            this.prixPotion.Text = "100";
            this.prixPotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prixPotion.TextChanged += new System.EventHandler(this.full3_TextChanged);
            // 
            // prixMaquereau
            // 
            this.prixMaquereau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixMaquereau.Location = new System.Drawing.Point(90, 271);
            this.prixMaquereau.Name = "prixMaquereau";
            this.prixMaquereau.Size = new System.Drawing.Size(115, 29);
            this.prixMaquereau.TabIndex = 4;
            this.prixMaquereau.Text = "0";
            this.prixMaquereau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prixMaquereau.TextChanged += new System.EventHandler(this.full4_TextChanged);
            // 
            // fullDepart
            // 
            this.fullDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullDepart.Location = new System.Drawing.Point(90, 34);
            this.fullDepart.Name = "fullDepart";
            this.fullDepart.Size = new System.Drawing.Size(115, 29);
            this.fullDepart.TabIndex = 5;
            this.fullDepart.Text = "0";
            this.fullDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maquereau
            // 
            this.maquereau.BackColor = System.Drawing.Color.Transparent;
            this.maquereau.Image = global::NosTool.Properties.Resources.maquereau;
            this.maquereau.Location = new System.Drawing.Point(34, 260);
            this.maquereau.Name = "maquereau";
            this.maquereau.Size = new System.Drawing.Size(50, 50);
            this.maquereau.TabIndex = 10;
            this.maquereau.TabStop = false;
            // 
            // geante
            // 
            this.geante.BackColor = System.Drawing.Color.Transparent;
            this.geante.Image = global::NosTool.Properties.Resources.geante;
            this.geante.Location = new System.Drawing.Point(34, 92);
            this.geante.Name = "geante";
            this.geante.Size = new System.Drawing.Size(50, 50);
            this.geante.TabIndex = 9;
            this.geante.TabStop = false;
            // 
            // potionMagique
            // 
            this.potionMagique.BackColor = System.Drawing.Color.Transparent;
            this.potionMagique.Image = global::NosTool.Properties.Resources.potion;
            this.potionMagique.Location = new System.Drawing.Point(34, 204);
            this.potionMagique.Name = "potionMagique";
            this.potionMagique.Size = new System.Drawing.Size(50, 50);
            this.potionMagique.TabIndex = 8;
            this.potionMagique.TabStop = false;
            // 
            // flacon
            // 
            this.flacon.BackColor = System.Drawing.Color.Transparent;
            this.flacon.Image = global::NosTool.Properties.Resources.flacon;
            this.flacon.Location = new System.Drawing.Point(34, 148);
            this.flacon.Name = "flacon";
            this.flacon.Size = new System.Drawing.Size(50, 50);
            this.flacon.TabIndex = 7;
            this.flacon.TabStop = false;
            // 
            // fullPotion
            // 
            this.fullPotion.BackColor = System.Drawing.Color.Transparent;
            this.fullPotion.Image = global::NosTool.Properties.Resources.fullPotion;
            this.fullPotion.Location = new System.Drawing.Point(34, 23);
            this.fullPotion.Name = "fullPotion";
            this.fullPotion.Size = new System.Drawing.Size(50, 50);
            this.fullPotion.TabIndex = 6;
            this.fullPotion.TabStop = false;
            // 
            // quantiteProd
            // 
            this.quantiteProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteProd.Location = new System.Drawing.Point(227, 34);
            this.quantiteProd.Name = "quantiteProd";
            this.quantiteProd.Size = new System.Drawing.Size(39, 29);
            this.quantiteProd.TabIndex = 11;
            this.quantiteProd.Text = "1";
            this.quantiteProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(227, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(39, 29);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "30";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(227, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(39, 29);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "20";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(227, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(39, 29);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "20";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(227, 271);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(39, 29);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "3";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcul
            // 
            this.calcul.Location = new System.Drawing.Point(334, 374);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(100, 23);
            this.calcul.TabIndex = 16;
            this.calcul.Text = "Calculer";
            this.calcul.UseVisualStyleBackColor = true;
            this.calcul.Click += new System.EventHandler(this.calcul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bénéfice sur 10 potions :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Il faut indiquer les prix à l\'unité au NosBazar.";
            // 
            // benefCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NosTool.Properties.Resources.fond2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(778, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcul);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.quantiteProd);
            this.Controls.Add(this.maquereau);
            this.Controls.Add(this.geante);
            this.Controls.Add(this.potionMagique);
            this.Controls.Add(this.flacon);
            this.Controls.Add(this.fullPotion);
            this.Controls.Add(this.fullDepart);
            this.Controls.Add(this.prixMaquereau);
            this.Controls.Add(this.prixPotion);
            this.Controls.Add(this.prixFlacon);
            this.Controls.Add(this.prixGeante);
            this.Controls.Add(this.benefFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "benefCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcultateur bénéfice";
            ((System.ComponentModel.ISupportInitialize)(this.maquereau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionMagique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flacon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullPotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox benefFinal;
        private System.Windows.Forms.TextBox prixGeante;
        private System.Windows.Forms.TextBox prixFlacon;
        private System.Windows.Forms.TextBox prixPotion;
        private System.Windows.Forms.TextBox prixMaquereau;
        private System.Windows.Forms.TextBox fullDepart;
        private System.Windows.Forms.PictureBox fullPotion;
        private System.Windows.Forms.PictureBox flacon;
        private System.Windows.Forms.PictureBox potionMagique;
        private System.Windows.Forms.PictureBox geante;
        private System.Windows.Forms.PictureBox maquereau;
        private System.Windows.Forms.TextBox quantiteProd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}