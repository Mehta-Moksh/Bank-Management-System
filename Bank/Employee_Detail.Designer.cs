namespace Bank
{
    partial class Employee_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Detail));
            this.label1 = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblui = new System.Windows.Forms.Label();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.dgv_empdetail = new System.Windows.Forms.DataGridView();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.cmb_desig = new System.Windows.Forms.ComboBox();
            this.lblmob = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmob = new System.Windows.Forms.TextBox();
            this.lblgen = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbldesig = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(9, 170);
            this.lblempname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(308, 39);
            this.lblempname.TabIndex = 1;
            this.lblempname.Text = "Employee Name :";
            this.lblempname.Click += new System.EventHandler(this.lblempname_Click);
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(134, 287);
            this.lbladd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(183, 39);
            this.lbladd.TabIndex = 5;
            this.lbladd.Text = " Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee Detail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(168, 382);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 32);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(340, 382);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 32);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(543, 382);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 32);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblui
            // 
            this.lblui.AutoSize = true;
            this.lblui.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblui.Location = new System.Drawing.Point(161, 111);
            this.lblui.Name = "lblui";
            this.lblui.Size = new System.Drawing.Size(156, 39);
            this.lblui.TabIndex = 15;
            this.lblui.Text = "User Id :";
            // 
            // txtempname
            // 
            this.txtempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.Location = new System.Drawing.Point(321, 176);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(186, 30);
            this.txtempname.TabIndex = 17;
            // 
            // txtadd
            // 
            this.txtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(321, 296);
            this.txtadd.Margin = new System.Windows.Forms.Padding(2);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(186, 30);
            this.txtadd.TabIndex = 6;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(716, 382);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 32);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password :";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(321, 238);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(186, 30);
            this.txtpass.TabIndex = 21;
            // 
            // backbtn
            // 
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(997, 21);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 45);
            this.backbtn.TabIndex = 22;
            this.backbtn.Text = " ";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // txt_userid
            // 
            this.txt_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.Location = new System.Drawing.Point(321, 120);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(186, 30);
            this.txt_userid.TabIndex = 26;
            // 
            // dgv_empdetail
            // 
            this.dgv_empdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empdetail.Location = new System.Drawing.Point(124, 429);
            this.dgv_empdetail.Name = "dgv_empdetail";
            this.dgv_empdetail.Size = new System.Drawing.Size(844, 215);
            this.dgv_empdetail.TabIndex = 27;
            this.dgv_empdetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_empdetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empdetail_CellContentClick);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.Location = new System.Drawing.Point(911, 297);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(101, 29);
            this.rb_female.TabIndex = 36;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(828, 297);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(77, 29);
            this.rb_male.TabIndex = 35;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // cmb_desig
            // 
            this.cmb_desig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_desig.FormattingEnabled = true;
            this.cmb_desig.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "CASHIER",
            "SUB CASHIER"});
            this.cmb_desig.Location = new System.Drawing.Point(820, 166);
            this.cmb_desig.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_desig.Name = "cmb_desig";
            this.cmb_desig.Size = new System.Drawing.Size(186, 33);
            this.cmb_desig.TabIndex = 34;
            // 
            // lblmob
            // 
            this.lblmob.AutoSize = true;
            this.lblmob.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmob.Location = new System.Drawing.Point(556, 114);
            this.lblmob.Name = "lblmob";
            this.lblmob.Size = new System.Drawing.Size(267, 37);
            this.lblmob.TabIndex = 33;
            this.lblmob.Text = "Mobile Number :";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(820, 225);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(186, 30);
            this.txtemail.TabIndex = 32;
            // 
            // txtmob
            // 
            this.txtmob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmob.Location = new System.Drawing.Point(820, 120);
            this.txtmob.Margin = new System.Windows.Forms.Padding(2);
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(186, 30);
            this.txtmob.TabIndex = 31;
            // 
            // lblgen
            // 
            this.lblgen.AutoSize = true;
            this.lblgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgen.Location = new System.Drawing.Point(674, 289);
            this.lblgen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(149, 37);
            this.lblgen.TabIndex = 30;
            this.lblgen.Text = "Gender :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(690, 225);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(133, 37);
            this.lblemail.TabIndex = 29;
            this.lblemail.Text = "E-mail :";
            // 
            // lbldesig
            // 
            this.lbldesig.AutoSize = true;
            this.lbldesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesig.Location = new System.Drawing.Point(606, 166);
            this.lbldesig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldesig.Name = "lbldesig";
            this.lbldesig.Size = new System.Drawing.Size(217, 37);
            this.lbldesig.TabIndex = 28;
            this.lbldesig.Text = "Designation :";
            // 
            // View
            // 
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.Location = new System.Drawing.Point(893, 382);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 32);
            this.View.TabIndex = 37;
            this.View.Text = "VIEW";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Employee_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1105, 640);
            this.Controls.Add(this.View);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.cmb_desig);
            this.Controls.Add(this.lblmob);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtmob);
            this.Controls.Add(this.lblgen);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbldesig);
            this.Controls.Add(this.dgv_empdetail);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.lblui);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee_Detail";
            this.Text = "Employee_Detail";
            this.Load += new System.EventHandler(this.Employee_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblui;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.DataGridView dgv_empdetail;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.ComboBox cmb_desig;
        private System.Windows.Forms.Label lblmob;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmob;
        private System.Windows.Forms.Label lblgen;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbldesig;
        private System.Windows.Forms.Button View;
    }
}