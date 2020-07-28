namespace selenuimmm
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
            this.start = new System.Windows.Forms.Button();
            this.tk = new System.Windows.Forms.TextBox();
            this.mk = new System.Windows.Forms.TextBox();
            this.ndpost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.postt = new System.Windows.Forms.Button();
            this.like = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.csvb = new System.Windows.Forms.Button();
            this.cs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbError = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.soluotComment = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.comm = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.solanLike = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tk1 = new System.Windows.Forms.TextBox();
            this.mk1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluotComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solanLike)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Lime;
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(246, 45);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(78, 46);
            this.start.TabIndex = 0;
            this.start.Text = "Login";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tk
            // 
            this.tk.Location = new System.Drawing.Point(89, 33);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(100, 20);
            this.tk.TabIndex = 1;
            this.tk.TextChanged += new System.EventHandler(this.tk_TextChanged);
            // 
            // mk
            // 
            this.mk.Location = new System.Drawing.Point(89, 59);
            this.mk.Name = "mk";
            this.mk.PasswordChar = '*';
            this.mk.Size = new System.Drawing.Size(100, 20);
            this.mk.TabIndex = 2;
            // 
            // ndpost
            // 
            this.ndpost.Location = new System.Drawing.Point(82, 36);
            this.ndpost.Multiline = true;
            this.ndpost.Name = "ndpost";
            this.ndpost.Size = new System.Drawing.Size(158, 80);
            this.ndpost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nội dung";
            // 
            // postt
            // 
            this.postt.BackColor = System.Drawing.Color.Lime;
            this.postt.ForeColor = System.Drawing.Color.Black;
            this.postt.Location = new System.Drawing.Point(246, 36);
            this.postt.Name = "postt";
            this.postt.Size = new System.Drawing.Size(61, 23);
            this.postt.TabIndex = 7;
            this.postt.Text = "Đăng bài";
            this.postt.UseVisualStyleBackColor = false;
            this.postt.Click += new System.EventHandler(this.postt_Click);
            // 
            // like
            // 
            this.like.BackColor = System.Drawing.Color.Lime;
            this.like.ForeColor = System.Drawing.Color.Black;
            this.like.Location = new System.Drawing.Point(82, 207);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(96, 33);
            this.like.TabIndex = 8;
            this.like.Text = "Like 1 cái";
            this.like.UseVisualStyleBackColor = false;
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(98, 32);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(93, 20);
            this.url.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Link bài viết";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(215, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Chia sẻ ngay";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // csvb
            // 
            this.csvb.BackColor = System.Drawing.Color.Lime;
            this.csvb.ForeColor = System.Drawing.Color.Black;
            this.csvb.Location = new System.Drawing.Point(215, 56);
            this.csvb.Name = "csvb";
            this.csvb.Size = new System.Drawing.Size(76, 22);
            this.csvb.TabIndex = 12;
            this.csvb.Text = "Chia sẻ";
            this.csvb.UseVisualStyleBackColor = false;
            this.csvb.Click += new System.EventHandler(this.csvb_Click);
            // 
            // cs
            // 
            this.cs.Location = new System.Drawing.Point(98, 58);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(93, 20);
            this.cs.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nội dung bài viết";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.csvb);
            this.groupBox1.Controls.Add(this.url);
            this.groupBox1.Controls.Add(this.cs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(35, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 126);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto share";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(58, 96);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(35, 13);
            this.lbError.TabIndex = 15;
            this.lbError.Text = "label6";
            this.lbError.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.mk1);
            this.groupBox2.Controls.Add(this.tk1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mk);
            this.groupBox2.Controls.Add(this.tk);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(35, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 142);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.soluotComment);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.comm);
            this.groupBox3.Controls.Add(this.lb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.solanLike);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.like);
            this.groupBox3.Controls.Add(this.postt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ndpost);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(425, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 297);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interactive";
            // 
            // soluotComment
            // 
            this.soluotComment.Location = new System.Drawing.Point(202, 148);
            this.soluotComment.Name = "soluotComment";
            this.soluotComment.Size = new System.Drawing.Size(38, 20);
            this.soluotComment.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.Location = new System.Drawing.Point(246, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 26);
            this.button3.TabIndex = 24;
            this.button3.Text = "Bình luận";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comm
            // 
            this.comm.Location = new System.Drawing.Point(84, 146);
            this.comm.Name = "comm";
            this.comm.Size = new System.Drawing.Size(112, 20);
            this.comm.TabIndex = 23;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(27, 149);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(51, 13);
            this.lb.TabIndex = 22;
            this.lb.Text = "Bình luận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Auto Like";
            // 
            // solanLike
            // 
            this.solanLike.Location = new System.Drawing.Point(82, 257);
            this.solanLike.Name = "solanLike";
            this.solanLike.Size = new System.Drawing.Size(96, 20);
            this.solanLike.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(195, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Bot like";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tài khoản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mật khẩu";
            // 
            // tk1
            // 
            this.tk1.Location = new System.Drawing.Point(89, 85);
            this.tk1.Name = "tk1";
            this.tk1.Size = new System.Drawing.Size(100, 20);
            this.tk1.TabIndex = 8;
            // 
            // mk1
            // 
            this.mk1.Location = new System.Drawing.Point(89, 108);
            this.mk1.Name = "mk1";
            this.mk1.PasswordChar = '*';
            this.mk1.Size = new System.Drawing.Size(100, 20);
            this.mk1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::selenuimmm.Properties.Resources._7382_01_duotone_gradients_powerpoint_templates_16x9_12_320x180;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluotComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solanLike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox tk;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.TextBox ndpost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button postt;
        private System.Windows.Forms.Button like;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button csvb;
        private System.Windows.Forms.TextBox cs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown solanLike;
        private System.Windows.Forms.TextBox comm;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown soluotComment;
        private System.Windows.Forms.TextBox mk1;
        private System.Windows.Forms.TextBox tk1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

