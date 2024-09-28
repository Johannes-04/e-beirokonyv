namespace e_beirokonyv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nevtb = new System.Windows.Forms.TextBox();
            this.jelszotb = new System.Windows.Forms.TextBox();
            this.tokaji = new System.Windows.Forms.Button();
            this.zselickislaki = new System.Windows.Forms.Button();
            this.szennai = new System.Windows.Forms.Button();
            this.vt_icon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vt_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Egyéni vadászatinapló";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.Location = new System.Drawing.Point(576, 73);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(141, 34);
            this.login.TabIndex = 2;
            this.login.Text = "Bejelentkezés";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(229, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Felhasználó név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(299, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jelszó:";
            // 
            // nevtb
            // 
            this.nevtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nevtb.Location = new System.Drawing.Point(363, 53);
            this.nevtb.Name = "nevtb";
            this.nevtb.Size = new System.Drawing.Size(190, 23);
            this.nevtb.TabIndex = 5;
            // 
            // jelszotb
            // 
            this.jelszotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jelszotb.Location = new System.Drawing.Point(363, 96);
            this.jelszotb.Name = "jelszotb";
            this.jelszotb.PasswordChar = '*';
            this.jelszotb.Size = new System.Drawing.Size(190, 22);
            this.jelszotb.TabIndex = 6;
            // 
            // tokaji
            // 
            this.tokaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tokaji.Location = new System.Drawing.Point(373, 163);
            this.tokaji.Name = "tokaji";
            this.tokaji.Size = new System.Drawing.Size(75, 23);
            this.tokaji.TabIndex = 7;
            this.tokaji.Text = "Tókaji";
            this.tokaji.UseVisualStyleBackColor = true;
            this.tokaji.Visible = false;
            this.tokaji.Click += new System.EventHandler(this.tokaji_Click);
            // 
            // zselickislaki
            // 
            this.zselickislaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zselickislaki.Location = new System.Drawing.Point(550, 163);
            this.zselickislaki.Name = "zselickislaki";
            this.zselickislaki.Size = new System.Drawing.Size(96, 23);
            this.zselickislaki.TabIndex = 8;
            this.zselickislaki.Text = "Zselickislaki";
            this.zselickislaki.UseVisualStyleBackColor = true;
            this.zselickislaki.Visible = false;
            this.zselickislaki.Click += new System.EventHandler(this.zselickislaki_Click);
            // 
            // szennai
            // 
            this.szennai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szennai.Location = new System.Drawing.Point(464, 163);
            this.szennai.Name = "szennai";
            this.szennai.Size = new System.Drawing.Size(70, 23);
            this.szennai.TabIndex = 9;
            this.szennai.Text = "Szennai";
            this.szennai.UseVisualStyleBackColor = true;
            this.szennai.Visible = false;
            this.szennai.Click += new System.EventHandler(this.szennai_Click);
            // 
            // vt_icon
            // 
            this.vt_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vt_icon.BackgroundImage")));
            this.vt_icon.InitialImage = null;
            this.vt_icon.Location = new System.Drawing.Point(12, 9);
            this.vt_icon.Name = "vt_icon";
            this.vt_icon.Size = new System.Drawing.Size(201, 201);
            this.vt_icon.TabIndex = 0;
            this.vt_icon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(219, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Biztonságikörzetek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(729, 216);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.szennai);
            this.Controls.Add(this.zselickislaki);
            this.Controls.Add(this.tokaji);
            this.Controls.Add(this.jelszotb);
            this.Controls.Add(this.nevtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vt_icon);
            this.Name = "Form1";
            this.Text = "E-beiroköny";
            ((System.ComponentModel.ISupportInitialize)(this.vt_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vt_icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nevtb;
        private System.Windows.Forms.TextBox jelszotb;
        private System.Windows.Forms.Button tokaji;
        private System.Windows.Forms.Button zselickislaki;
        private System.Windows.Forms.Button szennai;
        private System.Windows.Forms.Label label4;
    }
}

