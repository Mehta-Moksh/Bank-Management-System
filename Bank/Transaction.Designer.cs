namespace Bank
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.cmbTypeOfAcc = new System.Windows.Forms.ComboBox();
            this.typeacclbl = new System.Windows.Forms.Label();
            this.txtchqNo = new System.Windows.Forms.TextBox();
            this.Chequelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.Datelb = new System.Windows.Forms.Label();
            this.dtpTransDate = new System.Windows.Forms.DateTimePicker();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.accnolb = new System.Windows.Forms.Label();
            this.rb_credit = new System.Windows.Forms.RadioButton();
            this.rb_debit = new System.Windows.Forms.RadioButton();
            this.typetranslbl = new System.Windows.Forms.Label();
            this.cmbCashCheque = new System.Windows.Forms.ComboBox();
            this.translbl = new System.Windows.Forms.Label();
            this.txt_2000 = new System.Windows.Forms.TextBox();
            this.txt_1000 = new System.Windows.Forms.TextBox();
            this.txt_500 = new System.Windows.Forms.TextBox();
            this.x500lbl = new System.Windows.Forms.Label();
            this.txt_200 = new System.Windows.Forms.TextBox();
            this.x200lbl = new System.Windows.Forms.Label();
            this.txt_100 = new System.Windows.Forms.TextBox();
            this.x100lbl = new System.Windows.Forms.Label();
            this.txt_50 = new System.Windows.Forms.TextBox();
            this.x50lbl = new System.Windows.Forms.Label();
            this.txt_20 = new System.Windows.Forms.TextBox();
            this.x20lbl = new System.Windows.Forms.Label();
            this.txt_10 = new System.Windows.Forms.TextBox();
            this.x10lbl = new System.Windows.Forms.Label();
            this.txt_5 = new System.Windows.Forms.TextBox();
            this.x5lbl = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.x2lbl = new System.Windows.Forms.Label();
            this.lbl_Rs_1 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.x1lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCustName = new System.Windows.Forms.Label();
            this.x1000lbl = new System.Windows.Forms.Label();
            this.x2000lbl = new System.Windows.Forms.Label();
            this.lbl_Rs_2 = new System.Windows.Forms.Label();
            this.lbl_Rs_5 = new System.Windows.Forms.Label();
            this.lbl_Rs_10 = new System.Windows.Forms.Label();
            this.lbl_Rs_20 = new System.Windows.Forms.Label();
            this.lbl_Rs_50 = new System.Windows.Forms.Label();
            this.lbl_Rs_100 = new System.Windows.Forms.Label();
            this.lbl_Rs_200 = new System.Windows.Forms.Label();
            this.lbl_Rs_500 = new System.Windows.Forms.Label();
            this.lbl_Rs_1000 = new System.Windows.Forms.Label();
            this.lbl_Rs_2000 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTypeOfAcc
            // 
            this.cmbTypeOfAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeOfAcc.FormattingEnabled = true;
            this.cmbTypeOfAcc.Items.AddRange(new object[] {
            "-- Select Acc Type --",
            "Savings",
            "Current",
            "Salary",
            "Jan Dhan",
            "Mahila Mitra",
            "Noor"});
            this.cmbTypeOfAcc.Location = new System.Drawing.Point(455, 117);
            this.cmbTypeOfAcc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypeOfAcc.Name = "cmbTypeOfAcc";
            this.cmbTypeOfAcc.Size = new System.Drawing.Size(256, 28);
            this.cmbTypeOfAcc.TabIndex = 39;
            this.cmbTypeOfAcc.SelectedIndexChanged += new System.EventHandler(this.cmbTypeOfAcc_SelectedIndexChanged);
            // 
            // typeacclbl
            // 
            this.typeacclbl.AutoSize = true;
            this.typeacclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeacclbl.Location = new System.Drawing.Point(317, 121);
            this.typeacclbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeacclbl.Name = "typeacclbl";
            this.typeacclbl.Size = new System.Drawing.Size(135, 20);
            this.typeacclbl.TabIndex = 38;
            this.typeacclbl.Text = "Type Of Account :";
            // 
            // txtchqNo
            // 
            this.txtchqNo.Enabled = false;
            this.txtchqNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchqNo.Location = new System.Drawing.Point(451, 280);
            this.txtchqNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtchqNo.Name = "txtchqNo";
            this.txtchqNo.Size = new System.Drawing.Size(256, 26);
            this.txtchqNo.TabIndex = 37;
            // 
            // Chequelbl
            // 
            this.Chequelbl.AutoSize = true;
            this.Chequelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chequelbl.Location = new System.Drawing.Point(348, 283);
            this.Chequelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Chequelbl.Name = "Chequelbl";
            this.Chequelbl.Size = new System.Drawing.Size(101, 20);
            this.Chequelbl.TabIndex = 36;
            this.Chequelbl.Text = "Cheque No. :";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(388, 81);
            this.namelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(59, 20);
            this.namelbl.TabIndex = 34;
            this.namelbl.Text = "Name :";
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelb.Location = new System.Drawing.Point(397, 166);
            this.Datelb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(52, 20);
            this.Datelb.TabIndex = 33;
            this.Datelb.Text = "Date :";
            // 
            // dtpTransDate
            // 
            this.dtpTransDate.CustomFormat = "dd-MM-yyyy";
            this.dtpTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransDate.Location = new System.Drawing.Point(451, 164);
            this.dtpTransDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTransDate.Name = "dtpTransDate";
            this.dtpTransDate.Size = new System.Drawing.Size(236, 26);
            this.dtpTransDate.TabIndex = 32;
            this.dtpTransDate.ValueChanged += new System.EventHandler(this.dtpTransDate_ValueChanged);
            // 
            // txtAccNo
            // 
            this.txtAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNo.Location = new System.Drawing.Point(449, 45);
            this.txtAccNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(256, 26);
            this.txtAccNo.TabIndex = 31;
            // 
            // accnolb
            // 
            this.accnolb.AutoSize = true;
            this.accnolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnolb.Location = new System.Drawing.Point(343, 48);
            this.accnolb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accnolb.Name = "accnolb";
            this.accnolb.Size = new System.Drawing.Size(104, 20);
            this.accnolb.TabIndex = 30;
            this.accnolb.Text = "Account No. :";
            // 
            // rb_credit
            // 
            this.rb_credit.AutoSize = true;
            this.rb_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_credit.Location = new System.Drawing.Point(552, 244);
            this.rb_credit.Margin = new System.Windows.Forms.Padding(2);
            this.rb_credit.Name = "rb_credit";
            this.rb_credit.Size = new System.Drawing.Size(69, 24);
            this.rb_credit.TabIndex = 29;
            this.rb_credit.TabStop = true;
            this.rb_credit.Text = "Credit";
            this.rb_credit.UseVisualStyleBackColor = true;
            // 
            // rb_debit
            // 
            this.rb_debit.AutoSize = true;
            this.rb_debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_debit.Location = new System.Drawing.Point(455, 242);
            this.rb_debit.Margin = new System.Windows.Forms.Padding(2);
            this.rb_debit.Name = "rb_debit";
            this.rb_debit.Size = new System.Drawing.Size(65, 24);
            this.rb_debit.TabIndex = 28;
            this.rb_debit.TabStop = true;
            this.rb_debit.Text = "Debit";
            this.rb_debit.UseVisualStyleBackColor = true;
            // 
            // typetranslbl
            // 
            this.typetranslbl.AutoSize = true;
            this.typetranslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetranslbl.Location = new System.Drawing.Point(326, 205);
            this.typetranslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typetranslbl.Name = "typetranslbl";
            this.typetranslbl.Size = new System.Drawing.Size(122, 20);
            this.typetranslbl.TabIndex = 27;
            this.typetranslbl.Text = "Cash / Cheque :";
            // 
            // cmbCashCheque
            // 
            this.cmbCashCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCashCheque.FormattingEnabled = true;
            this.cmbCashCheque.Items.AddRange(new object[] {
            "-- Select --",
            "Cash",
            "Cheque"});
            this.cmbCashCheque.Location = new System.Drawing.Point(449, 202);
            this.cmbCashCheque.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCashCheque.Name = "cmbCashCheque";
            this.cmbCashCheque.Size = new System.Drawing.Size(256, 28);
            this.cmbCashCheque.TabIndex = 26;
            this.cmbCashCheque.Text = "-- Select --";
            this.cmbCashCheque.SelectedIndexChanged += new System.EventHandler(this.cmbCashCheque_SelectedIndexChanged);
            // 
            // translbl
            // 
            this.translbl.AutoSize = true;
            this.translbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translbl.Location = new System.Drawing.Point(453, 1);
            this.translbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.translbl.Name = "translbl";
            this.translbl.Size = new System.Drawing.Size(199, 39);
            this.translbl.TabIndex = 25;
            this.translbl.Text = "Transaction";
            // 
            // txt_2000
            // 
            this.txt_2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2000.Location = new System.Drawing.Point(749, 479);
            this.txt_2000.Margin = new System.Windows.Forms.Padding(2);
            this.txt_2000.MaxLength = 4;
            this.txt_2000.Name = "txt_2000";
            this.txt_2000.Size = new System.Drawing.Size(78, 29);
            this.txt_2000.TabIndex = 124;
            this.txt_2000.Tag = "2000";
            this.txt_2000.Text = "0";
            this.txt_2000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_2000.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // txt_1000
            // 
            this.txt_1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1000.Location = new System.Drawing.Point(613, 476);
            this.txt_1000.Margin = new System.Windows.Forms.Padding(2);
            this.txt_1000.MaxLength = 4;
            this.txt_1000.Name = "txt_1000";
            this.txt_1000.Size = new System.Drawing.Size(78, 29);
            this.txt_1000.TabIndex = 119;
            this.txt_1000.Tag = "1000";
            this.txt_1000.Text = "0";
            this.txt_1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1000.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // txt_500
            // 
            this.txt_500.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_500.Location = new System.Drawing.Point(468, 476);
            this.txt_500.Margin = new System.Windows.Forms.Padding(2);
            this.txt_500.MaxLength = 4;
            this.txt_500.Name = "txt_500";
            this.txt_500.Size = new System.Drawing.Size(78, 29);
            this.txt_500.TabIndex = 114;
            this.txt_500.Tag = "500";
            this.txt_500.Text = "0";
            this.txt_500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_500.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x500lbl
            // 
            this.x500lbl.AutoSize = true;
            this.x500lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x500lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x500lbl.Location = new System.Drawing.Point(487, 451);
            this.x500lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x500lbl.Name = "x500lbl";
            this.x500lbl.Size = new System.Drawing.Size(50, 24);
            this.x500lbl.TabIndex = 112;
            this.x500lbl.Text = "₹500";
            // 
            // txt_200
            // 
            this.txt_200.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_200.Location = new System.Drawing.Point(321, 479);
            this.txt_200.Margin = new System.Windows.Forms.Padding(2);
            this.txt_200.MaxLength = 4;
            this.txt_200.Name = "txt_200";
            this.txt_200.Size = new System.Drawing.Size(78, 29);
            this.txt_200.TabIndex = 109;
            this.txt_200.Tag = "200";
            this.txt_200.Text = "0";
            this.txt_200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_200.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x200lbl
            // 
            this.x200lbl.AutoSize = true;
            this.x200lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x200lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x200lbl.Location = new System.Drawing.Point(338, 454);
            this.x200lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x200lbl.Name = "x200lbl";
            this.x200lbl.Size = new System.Drawing.Size(50, 24);
            this.x200lbl.TabIndex = 107;
            this.x200lbl.Text = "₹200";
            // 
            // txt_100
            // 
            this.txt_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_100.Location = new System.Drawing.Point(182, 476);
            this.txt_100.Margin = new System.Windows.Forms.Padding(2);
            this.txt_100.MaxLength = 4;
            this.txt_100.Name = "txt_100";
            this.txt_100.Size = new System.Drawing.Size(78, 29);
            this.txt_100.TabIndex = 104;
            this.txt_100.Tag = "100";
            this.txt_100.Text = "0";
            this.txt_100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_100.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x100lbl
            // 
            this.x100lbl.AutoSize = true;
            this.x100lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x100lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x100lbl.Location = new System.Drawing.Point(198, 451);
            this.x100lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x100lbl.Name = "x100lbl";
            this.x100lbl.Size = new System.Drawing.Size(50, 24);
            this.x100lbl.TabIndex = 102;
            this.x100lbl.Text = "₹100";
            // 
            // txt_50
            // 
            this.txt_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_50.Location = new System.Drawing.Point(832, 372);
            this.txt_50.Margin = new System.Windows.Forms.Padding(2);
            this.txt_50.MaxLength = 4;
            this.txt_50.Name = "txt_50";
            this.txt_50.Size = new System.Drawing.Size(78, 29);
            this.txt_50.TabIndex = 99;
            this.txt_50.Tag = "50";
            this.txt_50.Text = "0";
            this.txt_50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_50.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x50lbl
            // 
            this.x50lbl.AutoSize = true;
            this.x50lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x50lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x50lbl.Location = new System.Drawing.Point(855, 345);
            this.x50lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x50lbl.Name = "x50lbl";
            this.x50lbl.Size = new System.Drawing.Size(40, 24);
            this.x50lbl.TabIndex = 97;
            this.x50lbl.Text = "₹50";
            // 
            // txt_20
            // 
            this.txt_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_20.Location = new System.Drawing.Point(694, 372);
            this.txt_20.Margin = new System.Windows.Forms.Padding(2);
            this.txt_20.MaxLength = 4;
            this.txt_20.Name = "txt_20";
            this.txt_20.Size = new System.Drawing.Size(78, 29);
            this.txt_20.TabIndex = 94;
            this.txt_20.Tag = "20";
            this.txt_20.Text = "0";
            this.txt_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_20.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x20lbl
            // 
            this.x20lbl.AutoSize = true;
            this.x20lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x20lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x20lbl.Location = new System.Drawing.Point(710, 345);
            this.x20lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x20lbl.Name = "x20lbl";
            this.x20lbl.Size = new System.Drawing.Size(55, 24);
            this.x20lbl.TabIndex = 92;
            this.x20lbl.Text = "₹20   ";
            // 
            // txt_10
            // 
            this.txt_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_10.Location = new System.Drawing.Point(561, 372);
            this.txt_10.Margin = new System.Windows.Forms.Padding(2);
            this.txt_10.MaxLength = 4;
            this.txt_10.Name = "txt_10";
            this.txt_10.Size = new System.Drawing.Size(78, 29);
            this.txt_10.TabIndex = 89;
            this.txt_10.Tag = "10";
            this.txt_10.Text = "0";
            this.txt_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_10.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x10lbl
            // 
            this.x10lbl.AutoSize = true;
            this.x10lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x10lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x10lbl.Location = new System.Drawing.Point(581, 345);
            this.x10lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x10lbl.Name = "x10lbl";
            this.x10lbl.Size = new System.Drawing.Size(40, 24);
            this.x10lbl.TabIndex = 87;
            this.x10lbl.Text = "₹10";
            // 
            // txt_5
            // 
            this.txt_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_5.Location = new System.Drawing.Point(416, 372);
            this.txt_5.Margin = new System.Windows.Forms.Padding(2);
            this.txt_5.MaxLength = 4;
            this.txt_5.Name = "txt_5";
            this.txt_5.Size = new System.Drawing.Size(78, 29);
            this.txt_5.TabIndex = 84;
            this.txt_5.Tag = "5";
            this.txt_5.Text = "0";
            this.txt_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_5.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x5lbl
            // 
            this.x5lbl.AutoSize = true;
            this.x5lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x5lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x5lbl.Location = new System.Drawing.Point(440, 345);
            this.x5lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x5lbl.Name = "x5lbl";
            this.x5lbl.Size = new System.Drawing.Size(30, 24);
            this.x5lbl.TabIndex = 82;
            this.x5lbl.Text = "₹5";
            // 
            // txt_2
            // 
            this.txt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2.Location = new System.Drawing.Point(269, 372);
            this.txt_2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_2.MaxLength = 4;
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(78, 29);
            this.txt_2.TabIndex = 79;
            this.txt_2.Tag = "2";
            this.txt_2.Text = "0";
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_2.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x2lbl
            // 
            this.x2lbl.AutoSize = true;
            this.x2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x2lbl.Location = new System.Drawing.Point(294, 345);
            this.x2lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x2lbl.Name = "x2lbl";
            this.x2lbl.Size = new System.Drawing.Size(30, 24);
            this.x2lbl.TabIndex = 77;
            this.x2lbl.Text = "₹2";
            // 
            // lbl_Rs_1
            // 
            this.lbl_Rs_1.AutoSize = true;
            this.lbl_Rs_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_1.Location = new System.Drawing.Point(157, 405);
            this.lbl_Rs_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_1.Name = "lbl_Rs_1";
            this.lbl_Rs_1.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_1.TabIndex = 75;
            this.lbl_Rs_1.Text = "0";
            // 
            // txt_1
            // 
            this.txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.Location = new System.Drawing.Point(142, 372);
            this.txt_1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_1.MaxLength = 4;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(78, 29);
            this.txt_1.TabIndex = 74;
            this.txt_1.Tag = "1";
            this.txt_1.Text = "0";
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1.Leave += new System.EventHandler(this.Calculate_Currency);
            // 
            // x1lbl
            // 
            this.x1lbl.AutoSize = true;
            this.x1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x1lbl.Location = new System.Drawing.Point(169, 345);
            this.x1lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x1lbl.Name = "x1lbl";
            this.x1lbl.Size = new System.Drawing.Size(45, 24);
            this.x1lbl.TabIndex = 72;
            this.x1lbl.Text = "₹1   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(427, 556);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 129;
            this.label1.Text = "Total :";
            // 
            // backbtn
            // 
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(946, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(53, 46);
            this.backbtn.TabIndex = 132;
            this.backbtn.Text = " ";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 133;
            this.label2.Text = "Type of Transaction :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(737, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSubmit.Location = new System.Drawing.Point(429, 621);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 55);
            this.btnSubmit.TabIndex = 135;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(449, 81);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(24, 20);
            this.lblCustName.TabIndex = 136;
            this.lblCustName.Text = "---";
            // 
            // x1000lbl
            // 
            this.x1000lbl.AutoSize = true;
            this.x1000lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1000lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x1000lbl.Location = new System.Drawing.Point(627, 453);
            this.x1000lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x1000lbl.Name = "x1000lbl";
            this.x1000lbl.Size = new System.Drawing.Size(60, 24);
            this.x1000lbl.TabIndex = 117;
            this.x1000lbl.Text = "₹1000";
            // 
            // x2000lbl
            // 
            this.x2000lbl.AutoSize = true;
            this.x2000lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2000lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.x2000lbl.Location = new System.Drawing.Point(764, 454);
            this.x2000lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x2000lbl.Name = "x2000lbl";
            this.x2000lbl.Size = new System.Drawing.Size(60, 24);
            this.x2000lbl.TabIndex = 122;
            this.x2000lbl.Text = "₹2000";
            // 
            // lbl_Rs_2
            // 
            this.lbl_Rs_2.AutoSize = true;
            this.lbl_Rs_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_2.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_2.Location = new System.Drawing.Point(282, 405);
            this.lbl_Rs_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_2.Name = "lbl_Rs_2";
            this.lbl_Rs_2.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_2.TabIndex = 137;
            this.lbl_Rs_2.Text = "0";
            // 
            // lbl_Rs_5
            // 
            this.lbl_Rs_5.AutoSize = true;
            this.lbl_Rs_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_5.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_5.Location = new System.Drawing.Point(437, 405);
            this.lbl_Rs_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_5.Name = "lbl_Rs_5";
            this.lbl_Rs_5.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_5.TabIndex = 138;
            this.lbl_Rs_5.Text = "0";
            // 
            // lbl_Rs_10
            // 
            this.lbl_Rs_10.AutoSize = true;
            this.lbl_Rs_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_10.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_10.Location = new System.Drawing.Point(580, 405);
            this.lbl_Rs_10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_10.Name = "lbl_Rs_10";
            this.lbl_Rs_10.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_10.TabIndex = 139;
            this.lbl_Rs_10.Text = "0";
            // 
            // lbl_Rs_20
            // 
            this.lbl_Rs_20.AutoSize = true;
            this.lbl_Rs_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_20.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_20.Location = new System.Drawing.Point(713, 405);
            this.lbl_Rs_20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_20.Name = "lbl_Rs_20";
            this.lbl_Rs_20.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_20.TabIndex = 140;
            this.lbl_Rs_20.Text = "0";
            // 
            // lbl_Rs_50
            // 
            this.lbl_Rs_50.AutoSize = true;
            this.lbl_Rs_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_50.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_50.Location = new System.Drawing.Point(852, 405);
            this.lbl_Rs_50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_50.Name = "lbl_Rs_50";
            this.lbl_Rs_50.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_50.TabIndex = 141;
            this.lbl_Rs_50.Text = "0";
            // 
            // lbl_Rs_100
            // 
            this.lbl_Rs_100.AutoSize = true;
            this.lbl_Rs_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_100.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_100.Location = new System.Drawing.Point(198, 509);
            this.lbl_Rs_100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_100.Name = "lbl_Rs_100";
            this.lbl_Rs_100.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_100.TabIndex = 142;
            this.lbl_Rs_100.Text = "0";
            // 
            // lbl_Rs_200
            // 
            this.lbl_Rs_200.AutoSize = true;
            this.lbl_Rs_200.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_200.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_200.Location = new System.Drawing.Point(338, 511);
            this.lbl_Rs_200.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_200.Name = "lbl_Rs_200";
            this.lbl_Rs_200.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_200.TabIndex = 143;
            this.lbl_Rs_200.Text = "0";
            // 
            // lbl_Rs_500
            // 
            this.lbl_Rs_500.AutoSize = true;
            this.lbl_Rs_500.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_500.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_500.Location = new System.Drawing.Point(489, 511);
            this.lbl_Rs_500.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_500.Name = "lbl_Rs_500";
            this.lbl_Rs_500.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_500.TabIndex = 144;
            this.lbl_Rs_500.Text = "0";
            // 
            // lbl_Rs_1000
            // 
            this.lbl_Rs_1000.AutoSize = true;
            this.lbl_Rs_1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_1000.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_1000.Location = new System.Drawing.Point(632, 509);
            this.lbl_Rs_1000.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_1000.Name = "lbl_Rs_1000";
            this.lbl_Rs_1000.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_1000.TabIndex = 145;
            this.lbl_Rs_1000.Text = "0";
            // 
            // lbl_Rs_2000
            // 
            this.lbl_Rs_2000.AutoSize = true;
            this.lbl_Rs_2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rs_2000.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Rs_2000.Location = new System.Drawing.Point(765, 511);
            this.lbl_Rs_2000.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rs_2000.Name = "lbl_Rs_2000";
            this.lbl_Rs_2000.Size = new System.Drawing.Size(20, 24);
            this.lbl_Rs_2000.TabIndex = 146;
            this.lbl_Rs_2000.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalAmount.Location = new System.Drawing.Point(517, 556);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(29, 31);
            this.lblTotalAmount.TabIndex = 147;
            this.lblTotalAmount.Text = "0";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(243, 45);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(18, 20);
            this.lblCustID.TabIndex = 148;
            this.lblCustID.Text = "0";
            this.lblCustID.Visible = false;
            this.lblCustID.Click += new System.EventHandler(this.lblCustID_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(584, 621);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(103, 54);
            this.btnclear.TabIndex = 149;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1040, 707);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblTotalAmount);
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
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_2000);
            this.Controls.Add(this.x2000lbl);
            this.Controls.Add(this.txt_1000);
            this.Controls.Add(this.x1000lbl);
            this.Controls.Add(this.txt_500);
            this.Controls.Add(this.x500lbl);
            this.Controls.Add(this.txt_200);
            this.Controls.Add(this.x200lbl);
            this.Controls.Add(this.txt_100);
            this.Controls.Add(this.x100lbl);
            this.Controls.Add(this.txt_50);
            this.Controls.Add(this.x50lbl);
            this.Controls.Add(this.txt_20);
            this.Controls.Add(this.x20lbl);
            this.Controls.Add(this.txt_10);
            this.Controls.Add(this.x10lbl);
            this.Controls.Add(this.txt_5);
            this.Controls.Add(this.x5lbl);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.x2lbl);
            this.Controls.Add(this.lbl_Rs_1);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.x1lbl);
            this.Controls.Add(this.cmbTypeOfAcc);
            this.Controls.Add(this.typeacclbl);
            this.Controls.Add(this.txtchqNo);
            this.Controls.Add(this.Chequelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.Datelb);
            this.Controls.Add(this.dtpTransDate);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.accnolb);
            this.Controls.Add(this.rb_credit);
            this.Controls.Add(this.rb_debit);
            this.Controls.Add(this.typetranslbl);
            this.Controls.Add(this.cmbCashCheque);
            this.Controls.Add(this.translbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTypeOfAcc;
        private System.Windows.Forms.Label typeacclbl;
        private System.Windows.Forms.TextBox txtchqNo;
        private System.Windows.Forms.Label Chequelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label Datelb;
        private System.Windows.Forms.DateTimePicker dtpTransDate;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Label accnolb;
        private System.Windows.Forms.RadioButton rb_credit;
        private System.Windows.Forms.RadioButton rb_debit;
        private System.Windows.Forms.Label typetranslbl;
        private System.Windows.Forms.ComboBox cmbCashCheque;
        private System.Windows.Forms.Label translbl;
        private System.Windows.Forms.TextBox txt_2000;
        private System.Windows.Forms.TextBox txt_1000;
        private System.Windows.Forms.TextBox txt_500;
        private System.Windows.Forms.Label x500lbl;
        private System.Windows.Forms.TextBox txt_200;
        private System.Windows.Forms.Label x200lbl;
        private System.Windows.Forms.TextBox txt_100;
        private System.Windows.Forms.Label x100lbl;
        private System.Windows.Forms.TextBox txt_50;
        private System.Windows.Forms.Label x50lbl;
        private System.Windows.Forms.TextBox txt_20;
        private System.Windows.Forms.Label x20lbl;
        private System.Windows.Forms.TextBox txt_10;
        private System.Windows.Forms.Label x10lbl;
        private System.Windows.Forms.TextBox txt_5;
        private System.Windows.Forms.Label x5lbl;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label x2lbl;
        private System.Windows.Forms.Label lbl_Rs_1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label x1lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label x1000lbl;
        private System.Windows.Forms.Label x2000lbl;
        private System.Windows.Forms.Label lbl_Rs_2;
        private System.Windows.Forms.Label lbl_Rs_5;
        private System.Windows.Forms.Label lbl_Rs_10;
        private System.Windows.Forms.Label lbl_Rs_20;
        private System.Windows.Forms.Label lbl_Rs_50;
        private System.Windows.Forms.Label lbl_Rs_100;
        private System.Windows.Forms.Label lbl_Rs_200;
        private System.Windows.Forms.Label lbl_Rs_500;
        private System.Windows.Forms.Label lbl_Rs_1000;
        private System.Windows.Forms.Label lbl_Rs_2000;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Button btnclear;

    }
}