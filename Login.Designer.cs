namespace Gricd_project
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lpass = new System.Windows.Forms.TextBox();
            this.luser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rmobile = new System.Windows.Forms.TextBox();
            this.rcpass = new System.Windows.Forms.TextBox();
            this.rpass = new System.Windows.Forms.TextBox();
            this.remail = new System.Windows.Forms.TextBox();
            this.ruser = new System.Windows.Forms.TextBox();
            this.rsurname = new System.Windows.Forms.TextBox();
            this.rfirst = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.cancel1 = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.cancel2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(218, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRICD INTEGRATED SERVICES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lpass);
            this.groupBox1.Controls.Add(this.luser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(35, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOG IN DETAILS:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lpass
            // 
            this.lpass.Location = new System.Drawing.Point(109, 90);
            this.lpass.Name = "lpass";
            this.lpass.PasswordChar = '*';
            this.lpass.Size = new System.Drawing.Size(100, 20);
            this.lpass.TabIndex = 13;
            // 
            // luser
            // 
            this.luser.ForeColor = System.Drawing.Color.Gray;
            this.luser.Location = new System.Drawing.Point(109, 39);
            this.luser.Name = "luser";
            this.luser.Size = new System.Drawing.Size(100, 20);
            this.luser.TabIndex = 7;
            this.luser.Text = "Email or Username";
            this.luser.TextChanged += new System.EventHandler(this.luser_TextChanged);
            this.luser.Enter += new System.EventHandler(this.luser_Enter);
            this.luser.Leave += new System.EventHandler(this.luser_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSWORD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.rmobile);
            this.groupBox2.Controls.Add(this.rcpass);
            this.groupBox2.Controls.Add(this.rpass);
            this.groupBox2.Controls.Add(this.remail);
            this.groupBox2.Controls.Add(this.ruser);
            this.groupBox2.Controls.Add(this.rsurname);
            this.groupBox2.Controls.Add(this.rfirst);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(419, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 314);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REGISTRATION DETAILS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(17, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "MOBILE NUMBER:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // rmobile
            // 
            this.rmobile.ForeColor = System.Drawing.Color.Gray;
            this.rmobile.Location = new System.Drawing.Point(150, 275);
            this.rmobile.Name = "rmobile";
            this.rmobile.Size = new System.Drawing.Size(162, 20);
            this.rmobile.TabIndex = 14;
            this.rmobile.Text = "+234";
            this.rmobile.Enter += new System.EventHandler(this.rmobile_Enter);
            this.rmobile.Leave += new System.EventHandler(this.rmobile_Leave);
            // 
            // rcpass
            // 
            this.rcpass.Location = new System.Drawing.Point(150, 234);
            this.rcpass.Name = "rcpass";
            this.rcpass.PasswordChar = '*';
            this.rcpass.Size = new System.Drawing.Size(162, 20);
            this.rcpass.TabIndex = 13;
            // 
            // rpass
            // 
            this.rpass.Location = new System.Drawing.Point(150, 192);
            this.rpass.Name = "rpass";
            this.rpass.PasswordChar = '*';
            this.rpass.Size = new System.Drawing.Size(162, 20);
            this.rpass.TabIndex = 12;
            this.rpass.Tag = "";
            this.rpass.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // remail
            // 
            this.remail.ForeColor = System.Drawing.Color.Gray;
            this.remail.Location = new System.Drawing.Point(150, 154);
            this.remail.Name = "remail";
            this.remail.Size = new System.Drawing.Size(162, 20);
            this.remail.TabIndex = 11;
            this.remail.Text = "someone@example.com";
            this.remail.Enter += new System.EventHandler(this.remail_Enter);
            this.remail.Leave += new System.EventHandler(this.remail_Leave);
            // 
            // ruser
            // 
            this.ruser.Location = new System.Drawing.Point(150, 117);
            this.ruser.Name = "ruser";
            this.ruser.Size = new System.Drawing.Size(162, 20);
            this.ruser.TabIndex = 10;
            // 
            // rsurname
            // 
            this.rsurname.Location = new System.Drawing.Point(150, 79);
            this.rsurname.Name = "rsurname";
            this.rsurname.Size = new System.Drawing.Size(162, 20);
            this.rsurname.TabIndex = 9;
            // 
            // rfirst
            // 
            this.rfirst.Location = new System.Drawing.Point(150, 46);
            this.rfirst.Name = "rfirst";
            this.rfirst.Size = new System.Drawing.Size(162, 20);
            this.rfirst.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "CONFIRM PASSWORD:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "PASSWORD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "EMAIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "USERNAME:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "SURNAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "FIRST NAME";
            // 
            // login
            // 
            this.login.ForeColor = System.Drawing.Color.Blue;
            this.login.Location = new System.Drawing.Point(56, 293);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 10;
            this.login.Text = "LOG IN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancel1
            // 
            this.cancel1.Location = new System.Drawing.Point(169, 293);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(75, 23);
            this.cancel1.TabIndex = 11;
            this.cancel1.Text = "CANCEL";
            this.cancel1.UseVisualStyleBackColor = true;
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // register
            // 
            this.register.ForeColor = System.Drawing.Color.Blue;
            this.register.Location = new System.Drawing.Point(486, 405);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 12;
            this.register.Text = "REGISTER";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // cancel2
            // 
            this.cancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel2.ForeColor = System.Drawing.Color.Red;
            this.cancel2.Location = new System.Drawing.Point(623, 405);
            this.cancel2.Name = "cancel2";
            this.cancel2.Size = new System.Drawing.Size(75, 23);
            this.cancel2.TabIndex = 13;
            this.cancel2.Text = "Clear";
            this.cancel2.UseVisualStyleBackColor = true;
            this.cancel2.Click += new System.EventHandler(this.cancel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel2);
            this.Controls.Add(this.register);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lpass;
        private System.Windows.Forms.TextBox luser;
        private System.Windows.Forms.TextBox rcpass;
        private System.Windows.Forms.TextBox rpass;
        private System.Windows.Forms.TextBox remail;
        private System.Windows.Forms.TextBox ruser;
        private System.Windows.Forms.TextBox rsurname;
        private System.Windows.Forms.TextBox rfirst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancel1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button cancel2;
        private System.Windows.Forms.TextBox rmobile;
    }
}

