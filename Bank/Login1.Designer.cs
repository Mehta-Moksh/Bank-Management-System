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
            this.button1 = new System.Windows.Forms.Button();
            this.designlbl = new System.Windows.Forms.Label();
            this.cmb_desig = new System.Windows.Forms.ComboBox();
            this.logbtn = new System.Windows.Forms.Button();
            this.passlbl = new System.Windows.Forms.Label();
            this.passtb = new System.Windows.Forms.TextBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.bmslbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usertb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(534, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // designlbl
            // 
            this.designlbl.AutoSize = true;
            this.designlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designlbl.ForeColor = System.Drawing.Color.Black;
            this.designlbl.Location = new System.Drawing.Point(285, 89);
            this.designlbl.Name = "designlbl";
            this.designlbl.Size = new System.Drawing.Size(127, 26);
            this.designlbl.TabIndex = 17;
            this.designlbl.Text = "Designation";
            // 
            // cmb_desig
            // 
            this.cmb_desig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_desig.FormattingEnabled = true;
            this.cmb_desig.Items.AddRange(new object[] {
            "-- Select Designation --",
            "ADMIN",
            "MANAGER",
            "CASHIER",
            "SUB CASHIER"});
            this.cmb_desig.Location = new System.Drawing.Point(451, 92);
            this.cmb_desig.Name = "cmb_desig";
            this.cmb_desig.Size = new System.Drawing.Size(196, 28);
            this.cmb_desig.TabIndex = 16;
            this.cmb_desig.Tag = "";
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.ForeColor = System.Drawing.Color.White;
            this.logbtn.Location = new System.Drawing.Point(420, 282);
            this.logbtn.Margin = new System.Windows.Forms.Padding(2);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(78, 32);
            this.logbtn.TabIndex = 15;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click_1);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passlbl.Location = new System.Drawing.Point(306, 213);
            this.passlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(108, 26);
            this.passlbl.TabIndex = 14;
            this.passlbl.Text = "Password";
            // 
            // passtb
            // 
            this.passtb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtb.Location = new System.Drawing.Point(451, 213);
            this.passtb.Margin = new System.Windows.Forms.Padding(2);
            this.passtb.Multiline = true;
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(196, 27);
            this.passtb.TabIndex = 13;
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.userlbl.Location = new System.Drawing.Point(300, 148);
            this.userlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(113, 26);
            this.userlbl.TabIndex = 12;
            this.userlbl.Text = "Username";
            // 
            // bmslbl
            // 
            this.bmslbl.AutoSize = true;
            this.bmslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmslbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bmslbl.Location = new System.Drawing.Point(278, 9);
            this.bmslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmslbl.Name = "bmslbl";
            this.bmslbl.Size = new System.Drawing.Size(424, 39);
            this.bmslbl.TabIndex = 9;
            this.bmslbl.Text = "Bank Management System";
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
            this.panel1.Size = new System.Drawing.Size(262, 332);
            this.panel1.TabIndex = 11;
            // 
            // usertb
            // 
            this.usertb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertb.Location = new System.Drawing.Point(451, 148);
            this.usertb.Margin = new System.Windows.Forms.Padding(2);
            this.usertb.Multiline = true;
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(196, 27);
            this.usertb.TabIndex = 10;
            this.usertb.TextChanged += new System.EventHandler(this.usertb_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.designlbl);
            this.Controls.Add(this.cmb_desig);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.bmslbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usertb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(728, 371);
            this.MinimumSize = new System.Drawing.Size(728, 371);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label designlbl;
        private System.Windows.Forms.ComboBox cmb_desig;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label bmslbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usertb;
    }
}