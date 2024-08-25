namespace Bank
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menupanel = new System.Windows.Forms.Panel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.na = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.Button();
            this.ts = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.Button();
            this.rc = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.ed = new System.Windows.Forms.Button();
            this.displaypanel = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.menupanel.SuspendLayout();
            this.displaypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.SlateGray;
            this.menupanel.Controls.Add(this.dtp);
            this.menupanel.Controls.Add(this.na);
            this.menupanel.Controls.Add(this.ad);
            this.menupanel.Controls.Add(this.ts);
            this.menupanel.Controls.Add(this.cb);
            this.menupanel.Controls.Add(this.rc);
            this.menupanel.Controls.Add(this.cl);
            this.menupanel.Controls.Add(this.ed);
            this.menupanel.Location = new System.Drawing.Point(2, 1);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(250, 791);
            this.menupanel.TabIndex = 1;
            this.menupanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menupanel_Paint);
            // 
            // dtp
            // 
            this.dtp.AllowDrop = true;
            this.dtp.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtp.CustomFormat = " ";
            this.dtp.Location = new System.Drawing.Point(0, 3);
            this.dtp.Name = "dtp";
            this.dtp.RightToLeftLayout = true;
            this.dtp.Size = new System.Drawing.Size(250, 20);
            this.dtp.TabIndex = 8;
            this.dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // na
            // 
            this.na.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na.Location = new System.Drawing.Point(0, 254);
            this.na.Name = "na";
            this.na.Size = new System.Drawing.Size(250, 44);
            this.na.TabIndex = 1;
            this.na.Text = "New Account";
            this.na.UseVisualStyleBackColor = true;
            this.na.Click += new System.EventHandler(this.na_Click);
            // 
            // ad
            // 
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.Location = new System.Drawing.Point(0, 327);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(250, 44);
            this.ad.TabIndex = 2;
            this.ad.Text = "Account Detail";
            this.ad.UseVisualStyleBackColor = true;
            this.ad.Click += new System.EventHandler(this.ad_Click);
            // 
            // ts
            // 
            this.ts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts.Location = new System.Drawing.Point(0, 396);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(250, 45);
            this.ts.TabIndex = 3;
            this.ts.Text = "Transaction";
            this.ts.UseVisualStyleBackColor = true;
            this.ts.Click += new System.EventHandler(this.ts_Click);
            // 
            // cb
            // 
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.Location = new System.Drawing.Point(0, 467);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(250, 38);
            this.cb.TabIndex = 4;
            this.cb.Text = "Check Balance";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.Click += new System.EventHandler(this.cb_Click);
            // 
            // rc
            // 
            this.rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rc.Location = new System.Drawing.Point(0, 527);
            this.rc.Name = "rc";
            this.rc.Size = new System.Drawing.Size(250, 39);
            this.rc.TabIndex = 5;
            this.rc.Text = "Records";
            this.rc.UseVisualStyleBackColor = true;
            this.rc.Click += new System.EventHandler(this.rc_Click);
            // 
            // cl
            // 
            this.cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl.Location = new System.Drawing.Point(0, 591);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(250, 43);
            this.cl.TabIndex = 6;
            this.cl.Text = "Customer List";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // ed
            // 
            this.ed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed.Location = new System.Drawing.Point(-3, 655);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(250, 42);
            this.ed.TabIndex = 7;
            this.ed.Text = "Employee Detail";
            this.ed.UseVisualStyleBackColor = true;
            this.ed.Click += new System.EventHandler(this.ed_Click);
            // 
            // displaypanel
            // 
            this.displaypanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.displaypanel.Controls.Add(this.btnlogout);
            this.displaypanel.Location = new System.Drawing.Point(258, 1);
            this.displaypanel.Name = "displaypanel";
            this.displaypanel.Size = new System.Drawing.Size(1091, 772);
            this.displaypanel.TabIndex = 9;
            this.displaypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displaypanel_Paint);
            // 
            // btnlogout
            // 
            this.btnlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogout.BackgroundImage")));
            this.btnlogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Location = new System.Drawing.Point(1005, 11);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(66, 65);
            this.btnlogout.TabIndex = 10;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.displaypanel);
            this.Controls.Add(this.menupanel);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menupanel.ResumeLayout(false);
            this.displaypanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button na;
        private System.Windows.Forms.Button ad;
        private System.Windows.Forms.Button ts;
        private System.Windows.Forms.Button cb;
        private System.Windows.Forms.Button rc;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button ed;
        private System.Windows.Forms.Panel displaypanel;
        private System.Windows.Forms.Button btnlogout;
    }
}