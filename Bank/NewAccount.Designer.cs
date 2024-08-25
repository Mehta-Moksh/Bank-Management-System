namespace Bank
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.cmb_typeofacc = new System.Windows.Forms.ComboBox();
            this.typelbl = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.doblbl = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.maillbl = new System.Windows.Forms.Label();
            this.txt_mob = new System.Windows.Forms.TextBox();
            this.moblbl = new System.Windows.Forms.Label();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.addresslbl = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.rb_unmarried = new System.Windows.Forms.RadioButton();
            this.rb_married = new System.Windows.Forms.RadioButton();
            this.cmb_kyc = new System.Windows.Forms.ComboBox();
            this.kyclbl = new System.Windows.Forms.Label();
            this.cmb_occupation = new System.Windows.Forms.ComboBox();
            this.occulbl = new System.Windows.Forms.Label();
            this.cmb_monthlyincome = new System.Windows.Forms.ComboBox();
            this.incomelbl = new System.Windows.Forms.Label();
            this.cmb_country = new System.Windows.Forms.ComboBox();
            this.countrylbl = new System.Windows.Forms.Label();
            this.cmb_state = new System.Windows.Forms.ComboBox();
            this.Statelbl = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.marriedlbl = new System.Windows.Forms.Label();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.genderlbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acc_no = new System.Windows.Forms.Label();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_custlist = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_custlist)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_typeofacc
            // 
            this.cmb_typeofacc.DropDownHeight = 250;
            this.cmb_typeofacc.DropDownWidth = 150;
            this.cmb_typeofacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_typeofacc.FormattingEnabled = true;
            this.cmb_typeofacc.IntegralHeight = false;
            this.cmb_typeofacc.Items.AddRange(new object[] {
            "Savings",
            "Current",
            "Salary",
            "Jan Dhan Account",
            "Mahila Mitra",
            "Noor",
            ""});
            this.cmb_typeofacc.Location = new System.Drawing.Point(278, 84);
            this.cmb_typeofacc.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_typeofacc.Name = "cmb_typeofacc";
            this.cmb_typeofacc.Size = new System.Drawing.Size(210, 28);
            this.cmb_typeofacc.TabIndex = 0;
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelbl.Location = new System.Drawing.Point(72, 84);
            this.typelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(202, 29);
            this.typelbl.TabIndex = 68;
            this.typelbl.Text = "Type Of Account :";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(278, 330);
            this.dob.Margin = new System.Windows.Forms.Padding(2);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(210, 20);
            this.dob.TabIndex = 5;
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblbl.Location = new System.Drawing.Point(185, 322);
            this.doblbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(89, 29);
            this.doblbl.TabIndex = 47;
            this.doblbl.Text = "D.O.B :";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(278, 284);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(210, 26);
            this.txt_email.TabIndex = 4;
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maillbl.Location = new System.Drawing.Point(180, 282);
            this.maillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(94, 29);
            this.maillbl.TabIndex = 45;
            this.maillbl.Text = "E-mail :";
            this.maillbl.Click += new System.EventHandler(this.maillbl_Click);
            // 
            // txt_mob
            // 
            this.txt_mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mob.Location = new System.Drawing.Point(278, 244);
            this.txt_mob.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mob.Multiline = true;
            this.txt_mob.Name = "txt_mob";
            this.txt_mob.Size = new System.Drawing.Size(210, 26);
            this.txt_mob.TabIndex = 3;
            // 
            // moblbl
            // 
            this.moblbl.AutoSize = true;
            this.moblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moblbl.Location = new System.Drawing.Point(137, 242);
            this.moblbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moblbl.Name = "moblbl";
            this.moblbl.Size = new System.Drawing.Size(137, 29);
            this.moblbl.TabIndex = 43;
            this.moblbl.Text = "Mobile No :";
            // 
            // txt_add
            // 
            this.txt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add.Location = new System.Drawing.Point(278, 171);
            this.txt_add.Margin = new System.Windows.Forms.Padding(2);
            this.txt_add.Multiline = true;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(210, 58);
            this.txt_add.TabIndex = 2;
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(160, 170);
            this.addresslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(114, 29);
            this.addresslbl.TabIndex = 41;
            this.addresslbl.Text = "Address :";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(278, 128);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(210, 31);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(22, 128);
            this.Namelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(252, 29);
            this.Namelbl.TabIndex = 39;
            this.Namelbl.Text = "Name/Name of Entity :";
            this.Namelbl.Click += new System.EventHandler(this.Namelbl_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(375, 17);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(342, 44);
            this.lbl1.TabIndex = 38;
            this.lbl1.Text = "New Account Form";
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(163, 456);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(100, 39);
            this.submitbtn.TabIndex = 17;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // rb_unmarried
            // 
            this.rb_unmarried.AutoSize = true;
            this.rb_unmarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_unmarried.Location = new System.Drawing.Point(803, 81);
            this.rb_unmarried.Margin = new System.Windows.Forms.Padding(2);
            this.rb_unmarried.Name = "rb_unmarried";
            this.rb_unmarried.Size = new System.Drawing.Size(110, 24);
            this.rb_unmarried.TabIndex = 9;
            this.rb_unmarried.Text = "Unmarried";
            this.rb_unmarried.UseVisualStyleBackColor = true;
            // 
            // rb_married
            // 
            this.rb_married.AutoSize = true;
            this.rb_married.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_married.Location = new System.Drawing.Point(700, 83);
            this.rb_married.Margin = new System.Windows.Forms.Padding(2);
            this.rb_married.Name = "rb_married";
            this.rb_married.Size = new System.Drawing.Size(87, 24);
            this.rb_married.TabIndex = 8;
            this.rb_married.TabStop = true;
            this.rb_married.Text = "Married";
            this.rb_married.UseVisualStyleBackColor = true;
            // 
            // cmb_kyc
            // 
            this.cmb_kyc.DropDownHeight = 250;
            this.cmb_kyc.DropDownWidth = 150;
            this.cmb_kyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_kyc.FormattingEnabled = true;
            this.cmb_kyc.IntegralHeight = false;
            this.cmb_kyc.Items.AddRange(new object[] {
            "Adhar Card",
            "Pan Card",
            "License",
            "Passport"});
            this.cmb_kyc.Location = new System.Drawing.Point(700, 338);
            this.cmb_kyc.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_kyc.Name = "cmb_kyc";
            this.cmb_kyc.Size = new System.Drawing.Size(228, 28);
            this.cmb_kyc.TabIndex = 15;
            // 
            // kyclbl
            // 
            this.kyclbl.AutoSize = true;
            this.kyclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyclbl.Location = new System.Drawing.Point(623, 336);
            this.kyclbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kyclbl.Name = "kyclbl";
            this.kyclbl.Size = new System.Drawing.Size(71, 26);
            this.kyclbl.TabIndex = 84;
            this.kyclbl.Text = "KYC :";
            this.kyclbl.Click += new System.EventHandler(this.kyclbl_Click);
            // 
            // cmb_occupation
            // 
            this.cmb_occupation.DropDownHeight = 250;
            this.cmb_occupation.DropDownWidth = 150;
            this.cmb_occupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_occupation.FormattingEnabled = true;
            this.cmb_occupation.IntegralHeight = false;
            this.cmb_occupation.Items.AddRange(new object[] {
            "Bussiness",
            "Service",
            "Self Employed"});
            this.cmb_occupation.Location = new System.Drawing.Point(700, 288);
            this.cmb_occupation.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_occupation.Name = "cmb_occupation";
            this.cmb_occupation.Size = new System.Drawing.Size(228, 28);
            this.cmb_occupation.TabIndex = 14;
            // 
            // occulbl
            // 
            this.occulbl.AutoSize = true;
            this.occulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occulbl.Location = new System.Drawing.Point(560, 286);
            this.occulbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.occulbl.Name = "occulbl";
            this.occulbl.Size = new System.Drawing.Size(134, 26);
            this.occulbl.TabIndex = 82;
            this.occulbl.Text = "Occupation :";
            // 
            // cmb_monthlyincome
            // 
            this.cmb_monthlyincome.DropDownHeight = 250;
            this.cmb_monthlyincome.DropDownWidth = 150;
            this.cmb_monthlyincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_monthlyincome.FormattingEnabled = true;
            this.cmb_monthlyincome.IntegralHeight = false;
            this.cmb_monthlyincome.Items.AddRange(new object[] {
            "Upto Rs. 1,00,000/-",
            "From Rs. 1,00,001 - Rs. 5,00,000/-",
            "From Rs. 5,00,001 - Rs. 10,00,000/-",
            "From Rs. 10,00,001 - Rs. 15,00,000/-",
            "From Rs. 15,00,001 - Rs. 25,00,000/-",
            "Above Rs. 25,00,000/-"});
            this.cmb_monthlyincome.Location = new System.Drawing.Point(700, 245);
            this.cmb_monthlyincome.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_monthlyincome.Name = "cmb_monthlyincome";
            this.cmb_monthlyincome.Size = new System.Drawing.Size(228, 28);
            this.cmb_monthlyincome.TabIndex = 13;
            // 
            // incomelbl
            // 
            this.incomelbl.AutoSize = true;
            this.incomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomelbl.Location = new System.Drawing.Point(516, 245);
            this.incomelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incomelbl.Name = "incomelbl";
            this.incomelbl.Size = new System.Drawing.Size(178, 26);
            this.incomelbl.TabIndex = 80;
            this.incomelbl.Text = "Monthly Income :";
            // 
            // cmb_country
            // 
            this.cmb_country.DropDownHeight = 250;
            this.cmb_country.DropDownWidth = 150;
            this.cmb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_country.FormattingEnabled = true;
            this.cmb_country.IntegralHeight = false;
            this.cmb_country.Items.AddRange(new object[] {
            "India"});
            this.cmb_country.Location = new System.Drawing.Point(700, 122);
            this.cmb_country.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_country.Name = "cmb_country";
            this.cmb_country.Size = new System.Drawing.Size(228, 28);
            this.cmb_country.TabIndex = 10;
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countrylbl.Location = new System.Drawing.Point(594, 120);
            this.countrylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(100, 26);
            this.countrylbl.TabIndex = 78;
            this.countrylbl.Text = "Country :";
            // 
            // cmb_state
            // 
            this.cmb_state.DropDownHeight = 250;
            this.cmb_state.DropDownWidth = 150;
            this.cmb_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.IntegralHeight = false;
            this.cmb_state.Items.AddRange(new object[] {
            "Gujarat"});
            this.cmb_state.Location = new System.Drawing.Point(700, 164);
            this.cmb_state.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.Size = new System.Drawing.Size(228, 28);
            this.cmb_state.TabIndex = 11;
            // 
            // Statelbl
            // 
            this.Statelbl.AutoSize = true;
            this.Statelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statelbl.Location = new System.Drawing.Point(619, 160);
            this.Statelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Statelbl.Name = "Statelbl";
            this.Statelbl.Size = new System.Drawing.Size(75, 26);
            this.Statelbl.TabIndex = 76;
            this.Statelbl.Text = "State :";
            // 
            // cmb_city
            // 
            this.cmb_city.DropDownHeight = 250;
            this.cmb_city.DropDownWidth = 150;
            this.cmb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.IntegralHeight = false;
            this.cmb_city.Items.AddRange(new object[] {
            "Jamnagar",
            "Rajkot",
            "Ahmedabad",
            "Surat",
            "Baroda",
            "Gandhinagar"});
            this.cmb_city.Location = new System.Drawing.Point(700, 206);
            this.cmb_city.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(228, 28);
            this.cmb_city.TabIndex = 12;
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylbl.Location = new System.Drawing.Point(632, 202);
            this.citylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(62, 26);
            this.citylbl.TabIndex = 74;
            this.citylbl.Text = "City :";
            // 
            // marriedlbl
            // 
            this.marriedlbl.AutoSize = true;
            this.marriedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marriedlbl.Location = new System.Drawing.Point(537, 81);
            this.marriedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.marriedlbl.Name = "marriedlbl";
            this.marriedlbl.Size = new System.Drawing.Size(157, 26);
            this.marriedlbl.TabIndex = 73;
            this.marriedlbl.Text = "Marital Status :";
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.Location = new System.Drawing.Point(103, 34);
            this.rb_female.Margin = new System.Windows.Forms.Padding(2);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(92, 28);
            this.rb_female.TabIndex = 0;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(103, 2);
            this.rb_male.Margin = new System.Windows.Forms.Padding(2);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(69, 28);
            this.rb_male.TabIndex = 0;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.genderrb1_CheckedChanged);
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlbl.Location = new System.Drawing.Point(2, 2);
            this.genderlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(96, 26);
            this.genderlbl.TabIndex = 70;
            this.genderlbl.Text = "Gender :";
            this.genderlbl.Click += new System.EventHandler(this.genderlbl_Click);
            // 
            // backbtn
            // 
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(993, 9);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 52);
            this.backbtn.TabIndex = 89;
            this.backbtn.Text = " ";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.genderlbl);
            this.panel1.Controls.Add(this.rb_male);
            this.panel1.Controls.Add(this.rb_female);
            this.panel1.Location = new System.Drawing.Point(175, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 84);
            this.panel1.TabIndex = 6;
            // 
            // acc_no
            // 
            this.acc_no.AutoSize = true;
            this.acc_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_no.Location = new System.Drawing.Point(565, 386);
            this.acc_no.Name = "acc_no";
            this.acc_no.Size = new System.Drawing.Size(130, 25);
            this.acc_no.TabIndex = 91;
            this.acc_no.Text = "Account No. :";
            // 
            // txt_accno
            // 
            this.txt_accno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accno.Location = new System.Drawing.Point(700, 386);
            this.txt_accno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_accno.Multiline = true;
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.Size = new System.Drawing.Size(228, 26);
            this.txt_accno.TabIndex = 16;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(333, 456);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(102, 39);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_custlist
            // 
            this.dgv_custlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_custlist.Location = new System.Drawing.Point(27, 514);
            this.dgv_custlist.Name = "dgv_custlist";
            this.dgv_custlist.Size = new System.Drawing.Size(977, 179);
            this.dgv_custlist.TabIndex = 94;
            this.dgv_custlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_custlist_CellClick);
            this.dgv_custlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(678, 456);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(83, 39);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(508, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(838, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1224, 788);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dgv_custlist);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_accno);
            this.Controls.Add(this.acc_no);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.rb_unmarried);
            this.Controls.Add(this.rb_married);
            this.Controls.Add(this.cmb_kyc);
            this.Controls.Add(this.kyclbl);
            this.Controls.Add(this.cmb_occupation);
            this.Controls.Add(this.occulbl);
            this.Controls.Add(this.cmb_monthlyincome);
            this.Controls.Add(this.incomelbl);
            this.Controls.Add(this.cmb_country);
            this.Controls.Add(this.countrylbl);
            this.Controls.Add(this.cmb_state);
            this.Controls.Add(this.Statelbl);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.citylbl);
            this.Controls.Add(this.marriedlbl);
            this.Controls.Add(this.cmb_typeofacc);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.doblbl);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.maillbl);
            this.Controls.Add(this.txt_mob);
            this.Controls.Add(this.moblbl);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAccount";
            this.Text = "00000000000000000000000";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_custlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_typeofacc;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.TextBox txt_mob;
        private System.Windows.Forms.Label moblbl;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.RadioButton rb_unmarried;
        private System.Windows.Forms.RadioButton rb_married;
        private System.Windows.Forms.ComboBox cmb_kyc;
        private System.Windows.Forms.Label kyclbl;
        private System.Windows.Forms.ComboBox cmb_occupation;
        private System.Windows.Forms.Label occulbl;
        private System.Windows.Forms.ComboBox cmb_monthlyincome;
        private System.Windows.Forms.Label incomelbl;
        private System.Windows.Forms.ComboBox cmb_country;
        private System.Windows.Forms.Label countrylbl;
        private System.Windows.Forms.ComboBox cmb_state;
        private System.Windows.Forms.Label Statelbl;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.Label marriedlbl;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label acc_no;
        private System.Windows.Forms.TextBox txt_accno;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_custlist;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}