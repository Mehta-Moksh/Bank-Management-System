namespace Bank
{
    partial class AccountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetails));
            this.dgv_accdetail = new System.Windows.Forms.DataGridView();
            this.accdetaillbl = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.typelbl = new System.Windows.Forms.Label();
            this.accnotxt = new System.Windows.Forms.TextBox();
            this.accnolbl = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_accdetail
            // 
            this.dgv_accdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_accdetail.Location = new System.Drawing.Point(38, 277);
            this.dgv_accdetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_accdetail.Name = "dgv_accdetail";
            this.dgv_accdetail.RowTemplate.Height = 24;
            this.dgv_accdetail.Size = new System.Drawing.Size(987, 256);
            this.dgv_accdetail.TabIndex = 1;
            // 
            // accdetaillbl
            // 
            this.accdetaillbl.AutoSize = true;
            this.accdetaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accdetaillbl.Location = new System.Drawing.Point(445, 16);
            this.accdetaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accdetaillbl.Name = "accdetaillbl";
            this.accdetaillbl.Size = new System.Drawing.Size(255, 37);
            this.accdetaillbl.TabIndex = 6;
            this.accdetaillbl.Text = "Account Details";
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(339, 204);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(110, 36);
            this.searchbtn.TabIndex = 11;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // typecb
            // 
            this.typecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecb.FormattingEnabled = true;
            this.typecb.Items.AddRange(new object[] {
            "--Select Type of Account--",
            "Savings",
            "Current",
            "Salary",
            "Jan Dhan Account",
            "Mahila Mitra Account",
            "Noor"});
            this.typecb.Location = new System.Drawing.Point(388, 133);
            this.typecb.Margin = new System.Windows.Forms.Padding(2);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(207, 32);
            this.typecb.TabIndex = 10;
            this.typecb.SelectedIndexChanged += new System.EventHandler(this.typecb_SelectedIndexChanged);
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelbl.Location = new System.Drawing.Point(197, 133);
            this.typelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(185, 26);
            this.typelbl.TabIndex = 9;
            this.typelbl.Text = "Type Of Account :";
            // 
            // accnotxt
            // 
            this.accnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnotxt.Location = new System.Drawing.Point(388, 82);
            this.accnotxt.Margin = new System.Windows.Forms.Padding(2);
            this.accnotxt.Multiline = true;
            this.accnotxt.Name = "accnotxt";
            this.accnotxt.Size = new System.Drawing.Size(207, 35);
            this.accnotxt.TabIndex = 8;
            // 
            // accnolbl
            // 
            this.accnolbl.AutoSize = true;
            this.accnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnolbl.Location = new System.Drawing.Point(197, 83);
            this.accnolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accnolbl.Name = "accnolbl";
            this.accnolbl.Size = new System.Drawing.Size(187, 26);
            this.accnolbl.TabIndex = 7;
            this.accnolbl.Text = "Account Number :";
            // 
            // btnback
            // 
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(992, 6);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(77, 47);
            this.btnback.TabIndex = 12;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1091, 772);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.accdetaillbl);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.typecb);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.accnotxt);
            this.Controls.Add(this.accnolbl);
            this.Controls.Add(this.dgv_accdetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountDetails";
            this.Text = "AccountDetails";
            this.Load += new System.EventHandler(this.AccountDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_accdetail;
        private System.Windows.Forms.Label accdetaillbl;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.TextBox accnotxt;
        private System.Windows.Forms.Label accnolbl;
        private System.Windows.Forms.Button btnback;
    }
}