namespace Bank
{
    partial class Customer_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_List));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcustlist = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer List";
            // 
            // dgvcustlist
            // 
            this.dgvcustlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustlist.Location = new System.Drawing.Point(74, 192);
            this.dgvcustlist.Name = "dgvcustlist";
            this.dgvcustlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcustlist.Size = new System.Drawing.Size(949, 272);
            this.dgvcustlist.TabIndex = 1;
            this.dgvcustlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustlist_CellClick);
            this.dgvcustlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustlist_CellContentClick);
            // 
            // backbtn
            // 
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(959, 31);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 46);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = " ";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Customer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1091, 772);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dgvcustlist);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer_List";
            this.Text = ".";
            this.Load += new System.EventHandler(this.Customer_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcustlist;
        private System.Windows.Forms.Button backbtn;
    }
}