namespace e_beirokonyv
{
    partial class SzennaiForm
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
            this.kisereotb = new System.Windows.Forms.TextBox();
            this.nevl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.befejezido = new System.Windows.Forms.DateTimePicker();
            this.kezdesido = new System.Windows.Forms.DateTimePicker();
            this.adatLisbox = new System.Windows.Forms.ListBox();
            this.bebt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.korzetszam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // kisereotb
            // 
            this.kisereotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kisereotb.Location = new System.Drawing.Point(143, 76);
            this.kisereotb.Name = "kisereotb";
            this.kisereotb.Size = new System.Drawing.Size(200, 22);
            this.kisereotb.TabIndex = 30;
            // 
            // nevl
            // 
            this.nevl.AutoSize = true;
            this.nevl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevl.Location = new System.Drawing.Point(621, 8);
            this.nevl.Name = "nevl";
            this.nevl.Size = new System.Drawing.Size(0, 24);
            this.nevl.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Biztonságikörzet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(180, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Befejezés:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kezdés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(80, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kisérő:";
            // 
            // befejezido
            // 
            this.befejezido.CustomFormat = "MM.dd HH:mm";
            this.befejezido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.befejezido.Location = new System.Drawing.Point(263, 115);
            this.befejezido.Name = "befejezido";
            this.befejezido.Size = new System.Drawing.Size(80, 20);
            this.befejezido.TabIndex = 23;
            // 
            // kezdesido
            // 
            this.kezdesido.CustomFormat = "MM.dd HH:mm";
            this.kezdesido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kezdesido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kezdesido.Location = new System.Drawing.Point(78, 114);
            this.kezdesido.Name = "kezdesido";
            this.kezdesido.Size = new System.Drawing.Size(80, 20);
            this.kezdesido.TabIndex = 22;
            // 
            // adatLisbox
            // 
            this.adatLisbox.BackColor = System.Drawing.SystemColors.Info;
            this.adatLisbox.FormattingEnabled = true;
            this.adatLisbox.Location = new System.Drawing.Point(383, 35);
            this.adatLisbox.Name = "adatLisbox";
            this.adatLisbox.Size = new System.Drawing.Size(694, 108);
            this.adatLisbox.TabIndex = 21;
            // 
            // bebt
            // 
            this.bebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bebt.Location = new System.Drawing.Point(280, 42);
            this.bebt.Name = "bebt";
            this.bebt.Size = new System.Drawing.Size(75, 29);
            this.bebt.TabIndex = 20;
            this.bebt.Text = "Beírás";
            this.bebt.UseVisualStyleBackColor = true;
            this.bebt.Click += new System.EventHandler(this.bebt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Szennai biztonságikörzetek:";
            // 
            // korzetszam
            // 
            this.korzetszam.FormattingEnabled = true;
            this.korzetszam.Location = new System.Drawing.Point(143, 46);
            this.korzetszam.Name = "korzetszam";
            this.korzetszam.Size = new System.Drawing.Size(121, 21);
            this.korzetszam.TabIndex = 34;
            // 
            // SzennaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1089, 151);
            this.Controls.Add(this.korzetszam);
            this.Controls.Add(this.kisereotb);
            this.Controls.Add(this.nevl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.befejezido);
            this.Controls.Add(this.kezdesido);
            this.Controls.Add(this.adatLisbox);
            this.Controls.Add(this.bebt);
            this.Controls.Add(this.label1);
            this.Name = "SzennaiForm";
            this.Text = "Szennai Csoport";
            this.Load += new System.EventHandler(this.SzennaiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox kisereotb;
        private System.Windows.Forms.Label nevl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker befejezido;
        private System.Windows.Forms.DateTimePicker kezdesido;
        private System.Windows.Forms.ListBox adatLisbox;
        private System.Windows.Forms.Button bebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox korzetszam;
    }
}