namespace Bank
{
    partial class Records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.recordlbl = new System.Windows.Forms.Label();
            this.dgv_records = new System.Windows.Forms.DataGridView();
            this.Col_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backbtn = new System.Windows.Forms.Button();
            this.lbl_Rs_50 = new System.Windows.Forms.Label();
            this.lbl_Rs_20 = new System.Windows.Forms.Label();
            this.lbl_Rs_10 = new System.Windows.Forms.Label();
            this.lbl_Rs_5 = new System.Windows.Forms.Label();
            this.lbl_Rs_2 = new System.Windows.Forms.Label();
            this.x2000lbl = new System.Windows.Forms.Label();
            this.x1000lbl = new System.Windows.Forms.Label();
            this.x500lbl = new System.Windows.Forms.Label();
            this.x200lbl = new System.Windows.Forms.Label();
            this.x100lbl = new System.Windows.Forms.Label();
            this.x50lbl = new System.Windows.Forms.Label();
            this.x20lbl = new System.Windows.Forms.Label();
            this.x10lbl = new System.Windows.Forms.Label();
            this.x5lbl = new System.Windows.Forms.Label();
            this.x2lbl = new System.Windows.Forms.Label();
            this.lbl_Rs_1 = new System.Windows.Forms.Label();
            this.x1lbl = new System.Windows.Forms.Label();
            this.lbl_Rs_2000 = new System.Windows.Forms.Label();
            this.lbl_Rs_1000 = new System.Windows.Forms.Label();
            this.lbl_Rs_500 = new System.Windows.Forms.Label();
            this.lbl_Rs_200 = new System.Windows.Forms.Label();
            this.lbl_Rs_100 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_records)).BeginInit();
            this.SuspendLayout();
            // 
            // recordlbl
            // 
            this.recordlbl.AutoSize = true;
            this.recordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordlbl.Location = new System.Drawing.Point(752, 20);
            this.recordlbl.Name = "recordlbl";
            this.recordlbl.Size = new System.Drawing.Size(142, 37);
            this.recordlbl.TabIndex = 0;
            this.recordlbl.Text = "Records";
            // 
            // dgv_records
            // 
            this.dgv_records.AllowUserToAddRows = false;
            this.dgv_records.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_records.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_records.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_1,
            this.Col_2,
            this.Col_4,
            this.Col_3});
            this.dgv_records.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_records.Location = new System.Drawing.Point(0, 0);
            this.dgv_records.Name = "dgv_records";
            this.dgv_records.ReadOnly = true;
            this.dgv_records.RowHeadersVisible = false;
            this.dgv_records.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_records.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_records.Size = new System.Drawing.Size(543, 734);
            this.dgv_records.TabIndex = 3;
            this.dgv_records.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_records_CellClick);
            this.dgv_records.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Col_1
            // 
            this.Col_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_1.DataPropertyName = "Transaction_id";
            this.Col_1.HeaderText = "ID";
            this.Col_1.Name = "Col_1";
            this.Col_1.ReadOnly = true;
            this.Col_1.Width = 48;
            // 
            // Col_2
            // 
            this.Col_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_2.DataPropertyName = "Transaction_Date";
            this.Col_2.HeaderText = "Date";
            this.Col_2.Name = "Col_2";
            this.Col_2.ReadOnly = true;
            this.Col_2.Width = 66;
            // 
            // Col_4
            // 
            this.Col_4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_4.DataPropertyName = "Is_Debit";
            this.Col_4.HeaderText = "Credit / Debit";
            this.Col_4.Name = "Col_4";
            this.Col_4.ReadOnly = true;
            this.Col_4.Width = 80;
            // 
            // Col_3
            // 
            this.Col_3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_3.DataPropertyName = "Transaction_Amt";
            this.Col_3.HeaderText = "Total Amount";
            this.Col_3.Name = "Col_3";
            this.Col_3.ReadOnly = true;
            // 
            // backbtn
            // 
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(988, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 45);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = " ";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // lbl_Rs_50
            // 
            this.lbl_Rs_50.AutoSize = true;
            this.lbl_Rs_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_50.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_50.Location = new System.Drawing.Point(998, 309);
            this.lbl_Rs_50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_50.Name = "lbl_Rs_50";
            this.lbl_Rs_50.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_50.TabIndex = 169;
            this.lbl_Rs_50.Text = "0";
            this.lbl_Rs_50.Click += new System.EventHandler(this.lbl_Rs_50_Click);
            // 
            // lbl_Rs_20
            // 
            this.lbl_Rs_20.AutoSize = true;
            this.lbl_Rs_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_20.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_20.Location = new System.Drawing.Point(726, 309);
            this.lbl_Rs_20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_20.Name = "lbl_Rs_20";
            this.lbl_Rs_20.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_20.TabIndex = 168;
            this.lbl_Rs_20.Text = "0";
            // 
            // lbl_Rs_10
            // 
            this.lbl_Rs_10.AutoSize = true;
            this.lbl_Rs_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_10.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_10.Location = new System.Drawing.Point(998, 222);
            this.lbl_Rs_10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_10.Name = "lbl_Rs_10";
            this.lbl_Rs_10.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_10.TabIndex = 167;
            this.lbl_Rs_10.Text = "0";
            // 
            // lbl_Rs_5
            // 
            this.lbl_Rs_5.AutoSize = true;
            this.lbl_Rs_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_5.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_5.Location = new System.Drawing.Point(726, 223);
            this.lbl_Rs_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_5.Name = "lbl_Rs_5";
            this.lbl_Rs_5.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_5.TabIndex = 166;
            this.lbl_Rs_5.Text = "0";
            // 
            // lbl_Rs_2
            // 
            this.lbl_Rs_2.AutoSize = true;
            this.lbl_Rs_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_2.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_2.Location = new System.Drawing.Point(998, 139);
            this.lbl_Rs_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_2.Name = "lbl_Rs_2";
            this.lbl_Rs_2.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_2.TabIndex = 165;
            this.lbl_Rs_2.Text = "0";
            // 
            // x2000lbl
            // 
            this.x2000lbl.AutoSize = true;
            this.x2000lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2000lbl.ForeColor = System.Drawing.Color.Black;
            this.x2000lbl.Location = new System.Drawing.Point(765, 585);
            this.x2000lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x2000lbl.Name = "x2000lbl";
            this.x2000lbl.Size = new System.Drawing.Size(91, 25);
            this.x2000lbl.TabIndex = 163;
            this.x2000lbl.Text = "₹2000 :";
            // 
            // x1000lbl
            // 
            this.x1000lbl.AutoSize = true;
            this.x1000lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1000lbl.ForeColor = System.Drawing.Color.Black;
            this.x1000lbl.Location = new System.Drawing.Point(903, 497);
            this.x1000lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x1000lbl.Name = "x1000lbl";
            this.x1000lbl.Size = new System.Drawing.Size(91, 25);
            this.x1000lbl.TabIndex = 161;
            this.x1000lbl.Text = "₹1000 :";
            // 
            // x500lbl
            // 
            this.x500lbl.AutoSize = true;
            this.x500lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x500lbl.ForeColor = System.Drawing.Color.Black;
            this.x500lbl.Location = new System.Drawing.Point(638, 497);
            this.x500lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x500lbl.Name = "x500lbl";
            this.x500lbl.Size = new System.Drawing.Size(78, 25);
            this.x500lbl.TabIndex = 159;
            this.x500lbl.Text = "₹500 :";
            // 
            // x200lbl
            // 
            this.x200lbl.AutoSize = true;
            this.x200lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x200lbl.ForeColor = System.Drawing.Color.Black;
            this.x200lbl.Location = new System.Drawing.Point(916, 402);
            this.x200lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x200lbl.Name = "x200lbl";
            this.x200lbl.Size = new System.Drawing.Size(78, 25);
            this.x200lbl.TabIndex = 157;
            this.x200lbl.Text = "₹200 :";
            // 
            // x100lbl
            // 
            this.x100lbl.AutoSize = true;
            this.x100lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x100lbl.ForeColor = System.Drawing.Color.Black;
            this.x100lbl.Location = new System.Drawing.Point(638, 402);
            this.x100lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x100lbl.Name = "x100lbl";
            this.x100lbl.Size = new System.Drawing.Size(78, 25);
            this.x100lbl.TabIndex = 155;
            this.x100lbl.Text = "₹100 :";
            // 
            // x50lbl
            // 
            this.x50lbl.AutoSize = true;
            this.x50lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x50lbl.ForeColor = System.Drawing.Color.Black;
            this.x50lbl.Location = new System.Drawing.Point(929, 309);
            this.x50lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x50lbl.Name = "x50lbl";
            this.x50lbl.Size = new System.Drawing.Size(65, 25);
            this.x50lbl.TabIndex = 153;
            this.x50lbl.Text = "₹50 :";
            // 
            // x20lbl
            // 
            this.x20lbl.AutoSize = true;
            this.x20lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x20lbl.ForeColor = System.Drawing.Color.Black;
            this.x20lbl.Location = new System.Drawing.Point(651, 309);
            this.x20lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x20lbl.Name = "x20lbl";
            this.x20lbl.Size = new System.Drawing.Size(65, 25);
            this.x20lbl.TabIndex = 151;
            this.x20lbl.Text = "₹20 :";
            // 
            // x10lbl
            // 
            this.x10lbl.AutoSize = true;
            this.x10lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x10lbl.ForeColor = System.Drawing.Color.Black;
            this.x10lbl.Location = new System.Drawing.Point(929, 223);
            this.x10lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x10lbl.Name = "x10lbl";
            this.x10lbl.Size = new System.Drawing.Size(65, 25);
            this.x10lbl.TabIndex = 149;
            this.x10lbl.Text = "₹10 :";
            // 
            // x5lbl
            // 
            this.x5lbl.AutoSize = true;
            this.x5lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x5lbl.ForeColor = System.Drawing.Color.Black;
            this.x5lbl.Location = new System.Drawing.Point(664, 221);
            this.x5lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x5lbl.Name = "x5lbl";
            this.x5lbl.Size = new System.Drawing.Size(52, 25);
            this.x5lbl.TabIndex = 147;
            this.x5lbl.Text = "₹5 :";
            // 
            // x2lbl
            // 
            this.x2lbl.AutoSize = true;
            this.x2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2lbl.ForeColor = System.Drawing.Color.Black;
            this.x2lbl.Location = new System.Drawing.Point(942, 139);
            this.x2lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x2lbl.Name = "x2lbl";
            this.x2lbl.Size = new System.Drawing.Size(52, 25);
            this.x2lbl.TabIndex = 145;
            this.x2lbl.Text = "₹2 :";
            // 
            // lbl_Rs_1
            // 
            this.lbl_Rs_1.AutoSize = true;
            this.lbl_Rs_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_1.Location = new System.Drawing.Point(726, 139);
            this.lbl_Rs_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_1.Name = "lbl_Rs_1";
            this.lbl_Rs_1.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_1.TabIndex = 144;
            this.lbl_Rs_1.Text = "0";
            // 
            // x1lbl
            // 
            this.x1lbl.AutoSize = true;
            this.x1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1lbl.ForeColor = System.Drawing.Color.Black;
            this.x1lbl.Location = new System.Drawing.Point(664, 139);
            this.x1lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x1lbl.Name = "x1lbl";
            this.x1lbl.Size = new System.Drawing.Size(52, 25);
            this.x1lbl.TabIndex = 142;
            this.x1lbl.Text = "₹1 :";
            // 
            // lbl_Rs_2000
            // 
            this.lbl_Rs_2000.AutoSize = true;
            this.lbl_Rs_2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_2000.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_2000.Location = new System.Drawing.Point(860, 585);
            this.lbl_Rs_2000.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_2000.Name = "lbl_Rs_2000";
            this.lbl_Rs_2000.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_2000.TabIndex = 174;
            this.lbl_Rs_2000.Text = "0";
            // 
            // lbl_Rs_1000
            // 
            this.lbl_Rs_1000.AutoSize = true;
            this.lbl_Rs_1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_1000.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_1000.Location = new System.Drawing.Point(998, 497);
            this.lbl_Rs_1000.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_1000.Name = "lbl_Rs_1000";
            this.lbl_Rs_1000.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_1000.TabIndex = 173;
            this.lbl_Rs_1000.Text = "0";
            this.lbl_Rs_1000.Click += new System.EventHandler(this.lbl_Rs_1000_Click);
            // 
            // lbl_Rs_500
            // 
            this.lbl_Rs_500.AutoSize = true;
            this.lbl_Rs_500.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_500.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_500.Location = new System.Drawing.Point(726, 497);
            this.lbl_Rs_500.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_500.Name = "lbl_Rs_500";
            this.lbl_Rs_500.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_500.TabIndex = 172;
            this.lbl_Rs_500.Text = "0";
            // 
            // lbl_Rs_200
            // 
            this.lbl_Rs_200.AutoSize = true;
            this.lbl_Rs_200.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_200.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_200.Location = new System.Drawing.Point(998, 402);
            this.lbl_Rs_200.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_200.Name = "lbl_Rs_200";
            this.lbl_Rs_200.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_200.TabIndex = 171;
            this.lbl_Rs_200.Text = "0";
            // 
            // lbl_Rs_100
            // 
            this.lbl_Rs_100.AutoSize = true;
            this.lbl_Rs_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_100.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_100.Location = new System.Drawing.Point(726, 402);
            this.lbl_Rs_100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_100.Name = "lbl_Rs_100";
            this.lbl_Rs_100.Size = new System.Drawing.Size(25, 25);
            this.lbl_Rs_100.TabIndex = 170;
            this.lbl_Rs_100.Text = "0";
            this.lbl_Rs_100.Click += new System.EventHandler(this.lbl_Rs_100_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1075, 734);
            this.Controls.Add(this.lbl_Rs_2000);
            this.Controls.Add(this.lbl_Rs_1000);
            this.Controls.Add(this.lbl_Rs_500);
            this.Controls.Add(this.lbl_Rs_200);
            this.Controls.Add(this.lbl_Rs_100);
            this.Controls.Add(this.lbl_Rs_50);
            this.Controls.Add(this.lbl_Rs_20);
            this.Controls.Add(this.lbl_Rs_10);
            this.Controls.Add(this.lbl_Rs_5);
            this.Controls.Add(this.lbl_Rs_2);
            this.Controls.Add(this.x2000lbl);
            this.Controls.Add(this.x1000lbl);
            this.Controls.Add(this.x500lbl);
            this.Controls.Add(this.x200lbl);
            this.Controls.Add(this.x100lbl);
            this.Controls.Add(this.x50lbl);
            this.Controls.Add(this.x20lbl);
            this.Controls.Add(this.x10lbl);
            this.Controls.Add(this.x5lbl);
            this.Controls.Add(this.x2lbl);
            this.Controls.Add(this.lbl_Rs_1);
            this.Controls.Add(this.x1lbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dgv_records);
            this.Controls.Add(this.recordlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.Load += new System.EventHandler(this.Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_records)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recordlbl;
        private System.Windows.Forms.DataGridView dgv_records;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label lbl_Rs_50;
        private System.Windows.Forms.Label lbl_Rs_20;
        private System.Windows.Forms.Label lbl_Rs_10;
        private System.Windows.Forms.Label lbl_Rs_5;
        private System.Windows.Forms.Label lbl_Rs_2;
        private System.Windows.Forms.Label x2000lbl;
        private System.Windows.Forms.Label x1000lbl;
        private System.Windows.Forms.Label x500lbl;
        private System.Windows.Forms.Label x200lbl;
        private System.Windows.Forms.Label x100lbl;
        private System.Windows.Forms.Label x50lbl;
        private System.Windows.Forms.Label x20lbl;
        private System.Windows.Forms.Label x10lbl;
        private System.Windows.Forms.Label x5lbl;
        private System.Windows.Forms.Label x2lbl;
        private System.Windows.Forms.Label lbl_Rs_1;
        private System.Windows.Forms.Label x1lbl;
        private System.Windows.Forms.Label lbl_Rs_2000;
        private System.Windows.Forms.Label lbl_Rs_1000;
        private System.Windows.Forms.Label lbl_Rs_500;
        private System.Windows.Forms.Label lbl_Rs_200;
        private System.Windows.Forms.Label lbl_Rs_100;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_3;
    }
}