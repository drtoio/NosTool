namespace NosTool
{
    partial class main_window
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            this.parfum = new System.Windows.Forms.PictureBox();
            this.timer_ci = new System.Windows.Forms.Timer(this.components);
            this.orateur = new System.Windows.Forms.PictureBox();
            this.check_rappelCI = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upsp = new System.Windows.Forms.PictureBox();
            this.rappelCali = new System.Windows.Forms.CheckBox();
            this.upsp2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.parfum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upsp2)).BeginInit();
            this.SuspendLayout();
            // 
            // parfum
            // 
            this.parfum.BackColor = System.Drawing.Color.Transparent;
            this.parfum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parfum.Image = global::NosTool.Properties.Resources.parfum1;
            this.parfum.Location = new System.Drawing.Point(32, 43);
            this.parfum.Name = "parfum";
            this.parfum.Size = new System.Drawing.Size(104, 104);
            this.parfum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.parfum.TabIndex = 0;
            this.parfum.TabStop = false;
            this.parfum.Click += new System.EventHandler(this.parfum_Click);
            // 
            // timer_ci
            // 
            this.timer_ci.Enabled = true;
            this.timer_ci.Interval = 1000;
            this.timer_ci.Tick += new System.EventHandler(this.timer_ci_Tick_1);
            // 
            // orateur
            // 
            this.orateur.BackColor = System.Drawing.Color.Transparent;
            this.orateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.orateur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orateur.Image = global::NosTool.Properties.Resources.ora1;
            this.orateur.Location = new System.Drawing.Point(188, 43);
            this.orateur.Name = "orateur";
            this.orateur.Size = new System.Drawing.Size(100, 104);
            this.orateur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orateur.TabIndex = 2;
            this.orateur.TabStop = false;
            this.orateur.Click += new System.EventHandler(this.orateur_Click);
            // 
            // check_rappelCI
            // 
            this.check_rappelCI.AutoSize = true;
            this.check_rappelCI.BackColor = System.Drawing.Color.Gainsboro;
            this.check_rappelCI.BackgroundImage = global::NosTool.Properties.Resources.fondbouton1;
            this.check_rappelCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_rappelCI.Location = new System.Drawing.Point(12, 421);
            this.check_rappelCI.Name = "check_rappelCI";
            this.check_rappelCI.Size = new System.Drawing.Size(111, 28);
            this.check_rappelCI.TabIndex = 3;
            this.check_rappelCI.Text = "Rappel CI";
            this.check_rappelCI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check_rappelCI.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::NosTool.Properties.Resources.or2;
            this.pictureBox1.Location = new System.Drawing.Point(337, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // upsp
            // 
            this.upsp.BackColor = System.Drawing.Color.Transparent;
            this.upsp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.upsp.Image = global::NosTool.Properties.Resources.SP;
            this.upsp.Location = new System.Drawing.Point(188, 153);
            this.upsp.Name = "upsp";
            this.upsp.Size = new System.Drawing.Size(100, 96);
            this.upsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upsp.TabIndex = 5;
            this.upsp.TabStop = false;
            this.upsp.Click += new System.EventHandler(this.bateau_Click);
            // 
            // rappelCali
            // 
            this.rappelCali.AutoSize = true;
            this.rappelCali.BackColor = System.Drawing.Color.Gainsboro;
            this.rappelCali.BackgroundImage = global::NosTool.Properties.Resources.fondbouton1;
            this.rappelCali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rappelCali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rappelCali.Location = new System.Drawing.Point(150, 421);
            this.rappelCali.Name = "rappelCali";
            this.rappelCali.Size = new System.Drawing.Size(153, 28);
            this.rappelCali.TabIndex = 6;
            this.rappelCali.Text = "Rappel Caligor";
            this.rappelCali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rappelCali.UseVisualStyleBackColor = false;
            this.rappelCali.CheckedChanged += new System.EventHandler(this.rappelCali_CheckedChanged);
            // 
            // upsp2
            // 
            this.upsp2.BackColor = System.Drawing.Color.Transparent;
            this.upsp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.upsp2.Image = global::NosTool.Properties.Resources.SP;
            this.upsp2.Location = new System.Drawing.Point(36, 153);
            this.upsp2.Name = "upsp2";
            this.upsp2.Size = new System.Drawing.Size(100, 96);
            this.upsp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upsp2.TabIndex = 7;
            this.upsp2.TabStop = false;
            this.upsp2.Click += new System.EventHandler(this.upsp2_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::NosTool.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.upsp2);
            this.Controls.Add(this.rappelCali);
            this.Controls.Add(this.upsp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check_rappelCI);
            this.Controls.Add(this.orateur);
            this.Controls.Add(this.parfum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NosTool";
            ((System.ComponentModel.ISupportInitialize)(this.parfum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upsp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox parfum;
        private System.Windows.Forms.Timer timer_ci;
        private System.Windows.Forms.PictureBox orateur;
        private System.Windows.Forms.CheckBox check_rappelCI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox upsp;
        private System.Windows.Forms.CheckBox rappelCali;
        private System.Windows.Forms.PictureBox upsp2;
    }
}

