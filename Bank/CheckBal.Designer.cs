namespace Bank
{
    partial class CheckBal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBal));
            this.namelbl = new System.Windows.Forms.Label();
            this.showbtn = new System.Windows.Forms.Button();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.Accnolbl = new System.Windows.Forms.Label();
            this.chkballbl = new System.Windows.Forms.Label();
            this.dgv_checkbal = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.lblcustname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkbal)).BeginInit();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(253, 145);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(90, 29);
            this.namelbl.TabIndex = 13;
            this.namelbl.Text = "Name :";
            // 
            // showbtn
            // 
            this.showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.Location = new System.Drawing.Point(383, 201);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(85, 32);
            this.showbtn.TabIndex = 12;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // txtacc
            // 
            this.txtacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacc.Location = new System.Drawing.Point(352, 108);
            this.txtacc.Multiline = true;
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(204, 25);
            this.txtacc.TabIndex = 11;
            // 
            // Accnolbl
            // 
            this.Accnolbl.AutoSize = true;
            this.Accnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accnolbl.Location = new System.Drawing.Point(192, 104);
            this.Accnolbl.Name = "Accnolbl";
            this.Accnolbl.Size = new System.Drawing.Size(154, 29);
            this.Accnolbl.TabIndex = 10;
            this.Accnolbl.Text = "Account No. :";
            // 
            // chkballbl
            // 
            this.chkballbl.AutoSize = true;
            this.chkballbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkballbl.Location = new System.Drawing.Point(406, 32);
            this.chkballbl.Name = "chkballbl";
            this.chkballbl.Size = new System.Drawing.Size(244, 37);
            this.chkballbl.TabIndex = 9;
            this.chkballbl.Text = "Check Balance";
            // 
            // dgv_checkbal
            // 
            this.dgv_checkbal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_checkbal.Location = new System.Drawing.Point(29, 325);
            this.dgv_checkbal.Name = "dgv_checkbal";
            this.dgv_checkbal.Size = new System.Drawing.Size(999, 224);
            this.dgv_checkbal.TabIndex = 15;
            this.dgv_checkbal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backbtn
            // 
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(975, 22);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 47);
            this.backbtn.TabIndex = 16;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.Location = new System.Drawing.Point(349, 145);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(34, 20);
            this.lblcustname.TabIndex = 17;
            this.lblcustname.Text = "-----";
            // 
            // CheckBal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1091, 772);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dgv_checkbal);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.Accnolbl);
            this.Controls.Add(this.chkballbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckBal";
            this.Text = "CheckBal";
            this.Load += new System.EventHandler(this.CheckBal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkbal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.Label Accnolbl;
        private System.Windows.Forms.Label chkballbl;
        private System.Windows.Forms.DataGridView dgv_checkbal;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label lblcustname;
    }
}