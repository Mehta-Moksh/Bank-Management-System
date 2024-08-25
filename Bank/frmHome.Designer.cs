namespace Bank
{
    partial class frmHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.na = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.Button();
            this.ts = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.Button();
            this.rc = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.ed = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.na);
            this.panel1.Controls.Add(this.ad);
            this.panel1.Controls.Add(this.ts);
            this.panel1.Controls.Add(this.cb);
            this.panel1.Controls.Add(this.rc);
            this.panel1.Controls.Add(this.cl);
            this.panel1.Controls.Add(this.ed);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 589);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // na
            // 
            this.na.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na.Location = new System.Drawing.Point(0, 85);
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
            this.ad.Location = new System.Drawing.Point(0, 150);
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
            this.ts.Location = new System.Drawing.Point(0, 221);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(250, 45);
            this.ts.TabIndex = 3;
            this.ts.Text = "Transaction";
            this.ts.UseVisualStyleBackColor = true;
            // 
            // cb
            // 
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.Location = new System.Drawing.Point(0, 292);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(250, 38);
            this.cb.TabIndex = 4;
            this.cb.Text = "Check Balance";
            this.cb.UseVisualStyleBackColor = true;
            // 
            // rc
            // 
            this.rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rc.Location = new System.Drawing.Point(0, 351);
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
            this.cl.Location = new System.Drawing.Point(0, 410);
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
            this.ed.Location = new System.Drawing.Point(0, 470);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(250, 42);
            this.ed.TabIndex = 7;
            this.ed.Text = "Employee Detail";
            this.ed.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(257, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 682);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHome";
            this.Text = "home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cb;
        private System.Windows.Forms.Button rc;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button ed;
        private System.Windows.Forms.Button na;
        private System.Windows.Forms.Button ad;
        private System.Windows.Forms.Button ts;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
    }
}