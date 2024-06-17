namespace Proby
{
    partial class register
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.regSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regPass = new System.Windows.Forms.TextBox();
            this.regLogin = new System.Windows.Forms.TextBox();
            this.buttoRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Proby.Properties.Resources.reading_concept_with_pile_books;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(513, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(37, 32);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.regSurname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.regPass);
            this.panel2.Controls.Add(this.regLogin);
            this.panel2.Controls.Add(this.buttoRegister);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.regName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Uighur", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(50, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(12);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(450, 340);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proby.Properties.Resources._299105_lock_icon;
            this.pictureBox3.InitialImage = global::Proby.Properties.Resources._299105_lock_icon;
            this.pictureBox3.Location = new System.Drawing.Point(245, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // regSurname
            // 
            this.regSurname.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regSurname.Location = new System.Drawing.Point(249, 127);
            this.regSurname.Name = "regSurname";
            this.regSurname.Size = new System.Drawing.Size(169, 30);
            this.regSurname.TabIndex = 14;
            this.regSurname.TextChanged += new System.EventHandler(this.regSurname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(157, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Already have an account";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(85, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Login";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(253, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter Surname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // regPass
            // 
            this.regPass.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regPass.Location = new System.Drawing.Point(249, 224);
            this.regPass.Name = "regPass";
            this.regPass.Size = new System.Drawing.Size(169, 30);
            this.regPass.TabIndex = 10;
            this.regPass.UseSystemPasswordChar = true;
            this.regPass.TextChanged += new System.EventHandler(this.regPass_TextChanged);
            // 
            // regLogin
            // 
            this.regLogin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regLogin.Location = new System.Drawing.Point(47, 224);
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(169, 30);
            this.regLogin.TabIndex = 8;
            this.regLogin.TextChanged += new System.EventHandler(this.regLogin_TextChanged);
            // 
            // buttoRegister
            // 
            this.buttoRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttoRegister.Font = new System.Drawing.Font("Microsoft Uighur", 10F, System.Drawing.FontStyle.Bold);
            this.buttoRegister.Location = new System.Drawing.Point(177, 268);
            this.buttoRegister.Name = "buttoRegister";
            this.buttoRegister.Size = new System.Drawing.Size(111, 35);
            this.buttoRegister.TabIndex = 7;
            this.buttoRegister.Text = "Register";
            this.buttoRegister.UseVisualStyleBackColor = false;
            this.buttoRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(281, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(61, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // regName
            // 
            this.regName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regName.Location = new System.Drawing.Point(47, 127);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(169, 30);
            this.regName.TabIndex = 2;
            this.regName.TextChanged += new System.EventHandler(this.regName_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proby.Properties.Resources._6132_user_icon;
            this.pictureBox1.InitialImage = global::Proby.Properties.Resources._299105_lock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(47, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proby.Properties.Resources.R__1_1;
            this.pictureBox2.InitialImage = global::Proby.Properties.Resources._299105_lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 700);
            this.MinimumSize = new System.Drawing.Size(550, 700);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox regLogin;
        private System.Windows.Forms.Button buttoRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox regPass;
        private System.Windows.Forms.TextBox regpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regSurname;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}