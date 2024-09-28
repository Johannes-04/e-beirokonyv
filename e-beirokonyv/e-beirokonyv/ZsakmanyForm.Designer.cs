namespace e_beirokonyv
{
    partial class ZsakmanyForm
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
            this.adatLisbox = new System.Windows.Forms.ListBox();
            this.bebt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vadfaj = new System.Windows.Forms.ComboBox();
            this.ivar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.megjegyzes = new System.Windows.Forms.TextBox();
            this.valaszt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // adatLisbox
            // 
            this.adatLisbox.BackColor = System.Drawing.SystemColors.Info;
            this.adatLisbox.FormattingEnabled = true;
            this.adatLisbox.Location = new System.Drawing.Point(218, 15);
            this.adatLisbox.Name = "adatLisbox";
            this.adatLisbox.Size = new System.Drawing.Size(614, 108);
            this.adatLisbox.TabIndex = 22;
            // 
            // bebt
            // 
            this.bebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bebt.Location = new System.Drawing.Point(838, 61);
            this.bebt.Name = "bebt";
            this.bebt.Size = new System.Drawing.Size(80, 29);
            this.bebt.TabIndex = 23;
            this.bebt.Text = "Beírás";
            this.bebt.UseVisualStyleBackColor = true;
            this.bebt.Click += new System.EventHandler(this.bebt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vadfaj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ivar:";
            // 
            // vadfaj
            // 
            this.vadfaj.FormattingEnabled = true;
            this.vadfaj.Location = new System.Drawing.Point(91, 17);
            this.vadfaj.Name = "vadfaj";
            this.vadfaj.Size = new System.Drawing.Size(121, 21);
            this.vadfaj.TabIndex = 34;
            this.vadfaj.SelectedIndexChanged += new System.EventHandler(this.vadfaj_SelectedIndexChanged);
            // 
            // ivar
            // 
            this.ivar.FormattingEnabled = true;
            this.ivar.Location = new System.Drawing.Point(91, 44);
            this.ivar.Name = "ivar";
            this.ivar.Size = new System.Drawing.Size(121, 21);
            this.ivar.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Megjegyzés:";
            // 
            // megjegyzes
            // 
            this.megjegyzes.Location = new System.Drawing.Point(109, 71);
            this.megjegyzes.Name = "megjegyzes";
            this.megjegyzes.Size = new System.Drawing.Size(103, 20);
            this.megjegyzes.TabIndex = 37;
            // 
            // valaszt
            // 
            this.valaszt.FormattingEnabled = true;
            this.valaszt.Location = new System.Drawing.Point(16, 102);
            this.valaszt.Name = "valaszt";
            this.valaszt.Size = new System.Drawing.Size(196, 21);
            this.valaszt.TabIndex = 38;
            // 
            // ZsakmanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(926, 131);
            this.Controls.Add(this.valaszt);
            this.Controls.Add(this.megjegyzes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ivar);
            this.Controls.Add(this.vadfaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bebt);
            this.Controls.Add(this.adatLisbox);
            this.Name = "ZsakmanyForm";
            this.Text = "Zsákmány";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox adatLisbox;
        private System.Windows.Forms.Button bebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vadfaj;
        private System.Windows.Forms.ComboBox ivar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox megjegyzes;
        private System.Windows.Forms.ComboBox valaszt;
    }
}