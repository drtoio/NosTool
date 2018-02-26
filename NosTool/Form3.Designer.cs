namespace NosTool
{
    partial class orateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orateur));
            this.orateurText = new System.Windows.Forms.TextBox();
            this.generalText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.copierOrateur = new System.Windows.Forms.Button();
            this.copierGeneral = new System.Windows.Forms.Button();
            this.copierOrateur2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.orateurText2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // orateurText
            // 
            this.orateurText.Location = new System.Drawing.Point(90, 42);
            this.orateurText.MaxLength = 120;
            this.orateurText.Name = "orateurText";
            this.orateurText.Size = new System.Drawing.Size(356, 20);
            this.orateurText.TabIndex = 0;
            this.orateurText.Text = "Text à copier";
            // 
            // generalText
            // 
            this.generalText.Location = new System.Drawing.Point(90, 261);
            this.generalText.MaxLength = 60;
            this.generalText.Name = "generalText";
            this.generalText.Size = new System.Drawing.Size(356, 20);
            this.generalText.TabIndex = 1;
            this.generalText.Text = "Text à copier";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NosTool.Properties.Resources.ora;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 25);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::NosTool.Properties.Resources.ora_gen;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(12, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 25);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // copierOrateur
            // 
            this.copierOrateur.Location = new System.Drawing.Point(230, 68);
            this.copierOrateur.Name = "copierOrateur";
            this.copierOrateur.Size = new System.Drawing.Size(75, 23);
            this.copierOrateur.TabIndex = 4;
            this.copierOrateur.Text = "Copier";
            this.copierOrateur.UseVisualStyleBackColor = true;
            this.copierOrateur.Click += new System.EventHandler(this.copierOrateur_Click);
            // 
            // copierGeneral
            // 
            this.copierGeneral.Location = new System.Drawing.Point(229, 288);
            this.copierGeneral.Name = "copierGeneral";
            this.copierGeneral.Size = new System.Drawing.Size(75, 23);
            this.copierGeneral.TabIndex = 5;
            this.copierGeneral.Text = "Copier";
            this.copierGeneral.UseVisualStyleBackColor = true;
            this.copierGeneral.Click += new System.EventHandler(this.copierGeneral_Click);
            // 
            // copierOrateur2
            // 
            this.copierOrateur2.Location = new System.Drawing.Point(230, 178);
            this.copierOrateur2.Name = "copierOrateur2";
            this.copierOrateur2.Size = new System.Drawing.Size(75, 23);
            this.copierOrateur2.TabIndex = 8;
            this.copierOrateur2.Text = "Copier";
            this.copierOrateur2.UseVisualStyleBackColor = true;
            this.copierOrateur2.Click += new System.EventHandler(this.copierOrateur2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::NosTool.Properties.Resources.ora;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(12, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 25);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // orateurText2
            // 
            this.orateurText2.Location = new System.Drawing.Point(90, 152);
            this.orateurText2.MaxLength = 120;
            this.orateurText2.Name = "orateurText2";
            this.orateurText2.Size = new System.Drawing.Size(356, 20);
            this.orateurText2.TabIndex = 6;
            this.orateurText2.Text = "Text à copier";
            // 
            // orateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NosTool.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 325);
            this.Controls.Add(this.copierOrateur2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.orateurText2);
            this.Controls.Add(this.copierGeneral);
            this.Controls.Add(this.copierOrateur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generalText);
            this.Controls.Add(this.orateurText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "orateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copier / Coller";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orateurText;
        private System.Windows.Forms.TextBox generalText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button copierOrateur;
        private System.Windows.Forms.Button copierGeneral;
        private System.Windows.Forms.Button copierOrateur2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox orateurText2;
    }
}