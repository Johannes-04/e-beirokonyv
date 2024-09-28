namespace e_beirokonyv
{
    partial class TokajiForm
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
            this.bebt = new System.Windows.Forms.Button();
            this.adatLisbox = new System.Windows.Forms.ListBox();
            this.kezdesido = new System.Windows.Forms.DateTimePicker();
            this.befejezido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nevl = new System.Windows.Forms.Label();
            this.kisereotb = new System.Windows.Forms.TextBox();
            this.korzetszam = new System.Windows.Forms.ComboBox();
            this.zsakmany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tókai biztonságikörzetek:";
            // 
            // bebt
            // 
            this.bebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bebt.Location = new System.Drawing.Point(83, 142);
            this.bebt.Name = "bebt";
            this.bebt.Size = new System.Drawing.Size(80, 29);
            this.bebt.TabIndex = 1;
            this.bebt.Text = "Beírás";
            this.bebt.UseVisualStyleBackColor = true;
            this.bebt.Click += new System.EventHandler(this.bebt_Click);
            // 
            // adatLisbox
            // 
            this.adatLisbox.BackColor = System.Drawing.SystemColors.Info;
            this.adatLisbox.FormattingEnabled = true;
            this.adatLisbox.Location = new System.Drawing.Point(354, 37);
            this.adatLisbox.Name = "adatLisbox";
            this.adatLisbox.Size = new System.Drawing.Size(602, 134);
            this.adatLisbox.TabIndex = 2;
            // 
            // kezdesido
            // 
            this.kezdesido.CustomFormat = "MM.dd HH:mm";
            this.kezdesido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kezdesido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kezdesido.Location = new System.Drawing.Point(83, 105);
            this.kezdesido.Name = "kezdesido";
            this.kezdesido.Size = new System.Drawing.Size(80, 20);
            this.kezdesido.TabIndex = 6;
            // 
            // befejezido
            // 
            this.befejezido.CustomFormat = "MM.dd HH:mm";
            this.befejezido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.befejezido.Location = new System.Drawing.Point(268, 105);
            this.befejezido.Name = "befejezido";
            this.befejezido.Size = new System.Drawing.Size(80, 20);
            this.befejezido.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(79, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kisérő:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kezdés:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(185, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Befejezés:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Biztonságikörzet:";
            // 
            // nevl
            // 
            this.nevl.AutoSize = true;
            this.nevl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevl.Location = new System.Drawing.Point(627, 10);
            this.nevl.Name = "nevl";
            this.nevl.Size = new System.Drawing.Size(0, 24);
            this.nevl.TabIndex = 15;
            // 
            // kisereotb
            // 
            this.kisereotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kisereotb.Location = new System.Drawing.Point(142, 77);
            this.kisereotb.Name = "kisereotb";
            this.kisereotb.Size = new System.Drawing.Size(200, 22);
            this.kisereotb.TabIndex = 17;
            // 
            // korzetszam
            // 
            this.korzetszam.FormattingEnabled = true;
            this.korzetszam.Location = new System.Drawing.Point(142, 49);
            this.korzetszam.Name = "korzetszam";
            this.korzetszam.Size = new System.Drawing.Size(121, 21);
            this.korzetszam.TabIndex = 33;
            // 
            // zsakmany
            // 
            this.zsakmany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zsakmany.Location = new System.Drawing.Point(221, 142);
            this.zsakmany.Name = "zsakmany";
            this.zsakmany.Size = new System.Drawing.Size(94, 30);
            this.zsakmany.TabIndex = 34;
            this.zsakmany.Text = "Zsákmány";
            this.zsakmany.UseVisualStyleBackColor = true;
            this.zsakmany.Click += new System.EventHandler(this.zsakmany_Click);
            // 
            // TokajiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(964, 179);
            this.Controls.Add(this.zsakmany);
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
            this.Name = "TokajiForm";
            this.Text = "Tókaji Csoport";
            this.Load += new System.EventHandler(this.TokajiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bebt;
        private System.Windows.Forms.ListBox adatLisbox;
        private System.Windows.Forms.TextBox kisero;
        private System.Windows.Forms.DateTimePicker kezdesido;
        private System.Windows.Forms.DateTimePicker befejezido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox korzet;
        private System.Windows.Forms.Label nevl;
        private System.Windows.Forms.TextBox kisereotb;
        private System.Windows.Forms.ComboBox korzetszam;
        private System.Windows.Forms.Button zsakmany;
    }
}