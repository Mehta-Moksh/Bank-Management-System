namespace Bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usertb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bmslbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.passtb = new System.Windows.Forms.TextBox();
            this.logbtn = new System.Windows.Forms.Button();
            this.design = new System.Windows.Forms.ComboBox();
            this.designlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usertb
            // 
            this.usertb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertb.Location = new System.Drawing.Point(440, 148);
            this.usertb.Margin = new System.Windows.Forms.Padding(2);
            this.usertb.Multiline = true;
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(196, 27);
            this.usertb.TabIndex = 0;
            this.usertb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 360);
            this.panel1.TabIndex = 1;
            // 
            // bmslbl
            // 
            this.bmslbl.AutoSize = true;
            this.bmslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmslbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bmslbl.Location = new System.Drawing.Point(267, 9);
            this.bmslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmslbl.Name = "bmslbl";
            this.bmslbl.Size = new System.Drawing.Size(424, 39);
            this.bmslbl.TabIndex = 0;
            this.bmslbl.Text = "Bank Management System";
            this.bmslbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.userlbl.Location = new System.Drawing.Point(289, 148);
            this.userlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(113, 26);
            this.userlbl.TabIndex = 2;
            this.userlbl.Text = "Username";
            this.userlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passlbl.Location = new System.Drawing.Point(295, 213);
            this.passlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(108, 26);
            this.passlbl.TabIndex = 4;
            this.passlbl.Text = "Password";
            // 
            // passtb
            // 
            this.passtb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtb.Location = new System.Drawing.Point(440, 213);
            this.passtb.Margin = new System.Windows.Forms.Padding(2);
            this.passtb.Multiline = true;
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(196, 27);
            this.passtb.TabIndex = 3;
            this.passtb.TextChanged += new System.EventHandler(this.passtb_TextChanged);
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logbtn.FlatAppearance.BorderSize = 0;
            this.logbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.logbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.logbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.logbtn.Location = new System.Drawing.Point(409, 282);
            this.logbtn.Margin = new System.Windows.Forms.Padding(2);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(78, 32);
            this.logbtn.TabIndex = 5;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // design
            // 
            this.design.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design.FormattingEnabled = true;
            this.design.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.design.Location = new System.Drawing.Point(440, 96);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(140, 28);
            this.design.TabIndex = 6;
            this.design.Tag = "";
            this.design.SelectedIndexChanged += new System.EventHandler(this.desigcmd_SelectedIndexChanged);
            // 
            // designlbl
            // 
            this.designlbl.AutoSize = true;
            this.designlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designlbl.ForeColor = System.Drawing.Color.Black;
            this.designlbl.Location = new System.Drawing.Point(267, 93);
            this.designlbl.Name = "designlbl";
            this.designlbl.Size = new System.Drawing.Size(127, 26);
            this.designlbl.TabIndex = 7;
            this.designlbl.Text = "Designation";
            this.designlbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(523, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(786, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.designlbl);
            this.Controls.Add(this.design);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.bmslbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usertb);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(802, 399);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(802, 399);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usertb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bmslbl;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.ComboBox design;
        private System.Windows.Forms.Label designlbl;
        private System.Windows.Forms.Button button1;

    }
}

