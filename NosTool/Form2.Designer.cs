namespace NosTool
{
    partial class parfum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parfum));
            this.rare_parfum = new System.Windows.Forms.ComboBox();
            this.lvl_parfum = new System.Windows.Forms.ComboBox();
            this.nb_parfum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rare_parfum
            // 
            this.rare_parfum.BackColor = System.Drawing.SystemColors.Window;
            this.rare_parfum.Cursor = System.Windows.Forms.Cursors.Default;
            this.rare_parfum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rare_parfum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rare_parfum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rare_parfum.FormattingEnabled = true;
            this.rare_parfum.Items.AddRange(new object[] {
            "R1",
            "R2",
            "R3",
            "R4",
            "R5",
            "R6",
            "R7",
            "R8"});
            this.rare_parfum.Location = new System.Drawing.Point(76, 12);
            this.rare_parfum.Name = "rare_parfum";
            this.rare_parfum.Size = new System.Drawing.Size(121, 28);
            this.rare_parfum.TabIndex = 0;
            this.rare_parfum.SelectedIndexChanged += new System.EventHandler(this.rare_parfum_SelectedIndexChanged);
            // 
            // lvl_parfum
            // 
            this.lvl_parfum.BackColor = System.Drawing.SystemColors.Window;
            this.lvl_parfum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lvl_parfum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_parfum.FormattingEnabled = true;
            this.lvl_parfum.Items.AddRange(new object[] {
            "1 - 24",
            "25 - 39",
            "40 - 49",
            "50 - 59",
            "60 - 69",
            "70 - 79",
            "80 - 89",
            "90 - 99",
            "+25",
            "+28",
            "+45",
            "+48"});
            this.lvl_parfum.Location = new System.Drawing.Point(76, 55);
            this.lvl_parfum.Name = "lvl_parfum";
            this.lvl_parfum.Size = new System.Drawing.Size(121, 28);
            this.lvl_parfum.TabIndex = 1;
            this.lvl_parfum.SelectedIndexChanged += new System.EventHandler(this.lvl_parfum_SelectedIndexChanged);
            // 
            // nb_parfum
            // 
            this.nb_parfum.BackColor = System.Drawing.Color.CornflowerBlue;
            this.nb_parfum.Cursor = System.Windows.Forms.Cursors.Default;
            this.nb_parfum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_parfum.Location = new System.Drawing.Point(76, 113);
            this.nb_parfum.Name = "nb_parfum";
            this.nb_parfum.ReadOnly = true;
            this.nb_parfum.Size = new System.Drawing.Size(121, 29);
            this.nb_parfum.TabIndex = 2;
            this.nb_parfum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nb_parfum.TextChanged += new System.EventHandler(this.nb_parfum_TextChanged);
            // 
            // parfum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::NosTool.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nb_parfum);
            this.Controls.Add(this.lvl_parfum);
            this.Controls.Add(this.rare_parfum);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "parfum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculateur de parfum";
            this.Load += new System.EventHandler(this.parfum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rare_parfum;
        private System.Windows.Forms.ComboBox lvl_parfum;
        private System.Windows.Forms.TextBox nb_parfum;
    }
}