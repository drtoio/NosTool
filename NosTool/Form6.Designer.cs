namespace NosTool
{
    partial class upsp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(upsp2));
            this.lvlSp = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.plusSp = new System.Windows.Forms.TextBox();
            this.pointsAttaque = new System.Windows.Forms.TextBox();
            this.pointsDefense = new System.Windows.Forms.TextBox();
            this.pointsElement = new System.Windows.Forms.TextBox();
            this.pointsHPMP = new System.Windows.Forms.TextBox();
            this.slAttaque = new System.Windows.Forms.TextBox();
            this.slDefense = new System.Windows.Forms.TextBox();
            this.slEelement = new System.Windows.Forms.TextBox();
            this.slHPMP = new System.Windows.Forms.TextBox();
            this.slGenerale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsRestants = new System.Windows.Forms.TextBox();
            this.timerSp = new System.Windows.Forms.Timer(this.components);
            this.totalAttaque = new System.Windows.Forms.TextBox();
            this.totalDefense = new System.Windows.Forms.TextBox();
            this.totalElement = new System.Windows.Forms.TextBox();
            this.totalHPMP = new System.Windows.Forms.TextBox();
            this.bonusAttaque = new System.Windows.Forms.TextBox();
            this.bonusDefense = new System.Windows.Forms.TextBox();
            this.bonusElement = new System.Windows.Forms.TextBox();
            this.bonusHPMP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvlSp
            // 
            this.lvlSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSp.Location = new System.Drawing.Point(148, 28);
            this.lvlSp.MaxLength = 2;
            this.lvlSp.Name = "lvlSp";
            this.lvlSp.Size = new System.Drawing.Size(30, 29);
            this.lvlSp.TabIndex = 0;
            this.lvlSp.Text = "1";
            this.lvlSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvlSp.TextChanged += new System.EventHandler(this.lvlSp_TextChanged);
            this.lvlSp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvlSp_KeyPress);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.BackColor = System.Drawing.Color.Transparent;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.White;
            this.plus.Location = new System.Drawing.Point(184, 31);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(22, 24);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // plusSp
            // 
            this.plusSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSp.Location = new System.Drawing.Point(212, 28);
            this.plusSp.MaxLength = 2;
            this.plusSp.Name = "plusSp";
            this.plusSp.Size = new System.Drawing.Size(30, 29);
            this.plusSp.TabIndex = 2;
            this.plusSp.Text = "0";
            this.plusSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointsAttaque
            // 
            this.pointsAttaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsAttaque.Location = new System.Drawing.Point(78, 73);
            this.pointsAttaque.MaxLength = 3;
            this.pointsAttaque.Name = "pointsAttaque";
            this.pointsAttaque.Size = new System.Drawing.Size(30, 29);
            this.pointsAttaque.TabIndex = 3;
            this.pointsAttaque.Text = "0";
            this.pointsAttaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointsAttaque.TextChanged += new System.EventHandler(this.pointsAttaque_TextChanged);
            this.pointsAttaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pointsAttaque_KeyPress);
            // 
            // pointsDefense
            // 
            this.pointsDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsDefense.Location = new System.Drawing.Point(78, 121);
            this.pointsDefense.MaxLength = 3;
            this.pointsDefense.Name = "pointsDefense";
            this.pointsDefense.Size = new System.Drawing.Size(30, 29);
            this.pointsDefense.TabIndex = 4;
            this.pointsDefense.Text = "0";
            this.pointsDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointsDefense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pointsDefense_KeyPress);
            // 
            // pointsElement
            // 
            this.pointsElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsElement.Location = new System.Drawing.Point(78, 175);
            this.pointsElement.MaxLength = 3;
            this.pointsElement.Name = "pointsElement";
            this.pointsElement.Size = new System.Drawing.Size(30, 29);
            this.pointsElement.TabIndex = 5;
            this.pointsElement.Text = "0";
            this.pointsElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointsElement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pointsElement_KeyPress);
            // 
            // pointsHPMP
            // 
            this.pointsHPMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsHPMP.Location = new System.Drawing.Point(78, 223);
            this.pointsHPMP.MaxLength = 3;
            this.pointsHPMP.Name = "pointsHPMP";
            this.pointsHPMP.Size = new System.Drawing.Size(30, 29);
            this.pointsHPMP.TabIndex = 6;
            this.pointsHPMP.Text = "0";
            this.pointsHPMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointsHPMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pointsHPMP_KeyPress);
            // 
            // slAttaque
            // 
            this.slAttaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slAttaque.Location = new System.Drawing.Point(323, 121);
            this.slAttaque.MaxLength = 3;
            this.slAttaque.Name = "slAttaque";
            this.slAttaque.Size = new System.Drawing.Size(30, 26);
            this.slAttaque.TabIndex = 7;
            this.slAttaque.Text = "0";
            this.slAttaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slAttaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.slAttaque_KeyPress);
            // 
            // slDefense
            // 
            this.slDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slDefense.Location = new System.Drawing.Point(323, 153);
            this.slDefense.MaxLength = 3;
            this.slDefense.Name = "slDefense";
            this.slDefense.Size = new System.Drawing.Size(30, 26);
            this.slDefense.TabIndex = 8;
            this.slDefense.Text = "0";
            this.slDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slDefense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.slDefense_KeyPress);
            // 
            // slEelement
            // 
            this.slEelement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slEelement.Location = new System.Drawing.Point(323, 185);
            this.slEelement.MaxLength = 3;
            this.slEelement.Name = "slEelement";
            this.slEelement.Size = new System.Drawing.Size(30, 26);
            this.slEelement.TabIndex = 9;
            this.slEelement.Text = "0";
            this.slEelement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slEelement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.slEelement_KeyPress);
            // 
            // slHPMP
            // 
            this.slHPMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slHPMP.Location = new System.Drawing.Point(323, 217);
            this.slHPMP.MaxLength = 3;
            this.slHPMP.Name = "slHPMP";
            this.slHPMP.Size = new System.Drawing.Size(30, 26);
            this.slHPMP.TabIndex = 10;
            this.slHPMP.Text = "0";
            this.slHPMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slHPMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.slHPMP_KeyPress);
            // 
            // slGenerale
            // 
            this.slGenerale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slGenerale.Location = new System.Drawing.Point(323, 249);
            this.slGenerale.MaxLength = 3;
            this.slGenerale.Name = "slGenerale";
            this.slGenerale.Size = new System.Drawing.Size(30, 26);
            this.slGenerale.TabIndex = 11;
            this.slGenerale.Text = "0";
            this.slGenerale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slGenerale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.slGenerale_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Développé par Illmatar / DrToio";
            // 
            // pointsRestants
            // 
            this.pointsRestants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsRestants.Location = new System.Drawing.Point(641, 19);
            this.pointsRestants.MaxLength = 3;
            this.pointsRestants.Name = "pointsRestants";
            this.pointsRestants.ReadOnly = true;
            this.pointsRestants.Size = new System.Drawing.Size(40, 26);
            this.pointsRestants.TabIndex = 13;
            this.pointsRestants.Text = "0";
            this.pointsRestants.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerSp
            // 
            this.timerSp.Enabled = true;
            this.timerSp.Tick += new System.EventHandler(this.timerSp_Tick);
            // 
            // totalAttaque
            // 
            this.totalAttaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAttaque.Location = new System.Drawing.Point(510, 121);
            this.totalAttaque.MaxLength = 3;
            this.totalAttaque.Name = "totalAttaque";
            this.totalAttaque.ReadOnly = true;
            this.totalAttaque.Size = new System.Drawing.Size(40, 26);
            this.totalAttaque.TabIndex = 14;
            this.totalAttaque.Text = "0";
            this.totalAttaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalDefense
            // 
            this.totalDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDefense.Location = new System.Drawing.Point(510, 153);
            this.totalDefense.MaxLength = 3;
            this.totalDefense.Name = "totalDefense";
            this.totalDefense.ReadOnly = true;
            this.totalDefense.Size = new System.Drawing.Size(40, 26);
            this.totalDefense.TabIndex = 15;
            this.totalDefense.Text = "0";
            this.totalDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalElement
            // 
            this.totalElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalElement.Location = new System.Drawing.Point(510, 185);
            this.totalElement.MaxLength = 3;
            this.totalElement.Name = "totalElement";
            this.totalElement.ReadOnly = true;
            this.totalElement.Size = new System.Drawing.Size(40, 26);
            this.totalElement.TabIndex = 16;
            this.totalElement.Text = "0";
            this.totalElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalHPMP
            // 
            this.totalHPMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHPMP.Location = new System.Drawing.Point(510, 217);
            this.totalHPMP.MaxLength = 3;
            this.totalHPMP.Name = "totalHPMP";
            this.totalHPMP.ReadOnly = true;
            this.totalHPMP.Size = new System.Drawing.Size(40, 26);
            this.totalHPMP.TabIndex = 17;
            this.totalHPMP.Text = "0";
            this.totalHPMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bonusAttaque
            // 
            this.bonusAttaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusAttaque.Location = new System.Drawing.Point(651, 121);
            this.bonusAttaque.MaxLength = 3;
            this.bonusAttaque.Name = "bonusAttaque";
            this.bonusAttaque.ReadOnly = true;
            this.bonusAttaque.Size = new System.Drawing.Size(40, 26);
            this.bonusAttaque.TabIndex = 18;
            this.bonusAttaque.Text = "0";
            this.bonusAttaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bonusDefense
            // 
            this.bonusDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusDefense.Location = new System.Drawing.Point(651, 153);
            this.bonusDefense.MaxLength = 3;
            this.bonusDefense.Name = "bonusDefense";
            this.bonusDefense.ReadOnly = true;
            this.bonusDefense.Size = new System.Drawing.Size(40, 26);
            this.bonusDefense.TabIndex = 19;
            this.bonusDefense.Text = "0";
            this.bonusDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bonusElement
            // 
            this.bonusElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusElement.Location = new System.Drawing.Point(651, 185);
            this.bonusElement.MaxLength = 3;
            this.bonusElement.Name = "bonusElement";
            this.bonusElement.ReadOnly = true;
            this.bonusElement.Size = new System.Drawing.Size(40, 26);
            this.bonusElement.TabIndex = 20;
            this.bonusElement.Text = "0";
            this.bonusElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bonusHPMP
            // 
            this.bonusHPMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusHPMP.Location = new System.Drawing.Point(651, 217);
            this.bonusHPMP.MaxLength = 3;
            this.bonusHPMP.Name = "bonusHPMP";
            this.bonusHPMP.ReadOnly = true;
            this.bonusHPMP.Size = new System.Drawing.Size(40, 26);
            this.bonusHPMP.TabIndex = 21;
            this.bonusHPMP.Text = "0";
            this.bonusHPMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upsp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NosTool.Properties.Resources.upspfond2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 408);
            this.Controls.Add(this.bonusHPMP);
            this.Controls.Add(this.bonusElement);
            this.Controls.Add(this.bonusDefense);
            this.Controls.Add(this.bonusAttaque);
            this.Controls.Add(this.totalHPMP);
            this.Controls.Add(this.totalElement);
            this.Controls.Add(this.totalDefense);
            this.Controls.Add(this.totalAttaque);
            this.Controls.Add(this.pointsRestants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slGenerale);
            this.Controls.Add(this.slHPMP);
            this.Controls.Add(this.slEelement);
            this.Controls.Add(this.slDefense);
            this.Controls.Add(this.slAttaque);
            this.Controls.Add(this.pointsHPMP);
            this.Controls.Add(this.pointsElement);
            this.Controls.Add(this.pointsDefense);
            this.Controls.Add(this.pointsAttaque);
            this.Controls.Add(this.plusSp);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.lvlSp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "upsp2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulateur SP";
            this.Load += new System.EventHandler(this.upsp2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lvlSp;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.TextBox plusSp;
        private System.Windows.Forms.TextBox pointsAttaque;
        private System.Windows.Forms.TextBox pointsDefense;
        private System.Windows.Forms.TextBox pointsElement;
        private System.Windows.Forms.TextBox pointsHPMP;
        private System.Windows.Forms.TextBox slAttaque;
        private System.Windows.Forms.TextBox slDefense;
        private System.Windows.Forms.TextBox slEelement;
        private System.Windows.Forms.TextBox slHPMP;
        private System.Windows.Forms.TextBox slGenerale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pointsRestants;
        private System.Windows.Forms.Timer timerSp;
        private System.Windows.Forms.TextBox totalAttaque;
        private System.Windows.Forms.TextBox totalDefense;
        private System.Windows.Forms.TextBox totalElement;
        private System.Windows.Forms.TextBox totalHPMP;
        private System.Windows.Forms.TextBox bonusAttaque;
        private System.Windows.Forms.TextBox bonusDefense;
        private System.Windows.Forms.TextBox bonusElement;
        private System.Windows.Forms.TextBox bonusHPMP;
    }
}