namespace ControlExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pb_printedPic = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_design = new System.Windows.Forms.CheckBox();
            this.cb_programming = new System.Windows.Forms.CheckBox();
            this.cb_english = new System.Windows.Forms.CheckBox();
            this.cb_math = new System.Windows.Forms.CheckBox();
            this.txt_mobileNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fisrtname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_hobbies = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_mobileNo = new System.Windows.Forms.Label();
            this.pb_submitedPic = new System.Windows.Forms.PictureBox();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.list_hobbies = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_printedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_submitedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pb_printedPic
            // 
            this.pb_printedPic.Location = new System.Drawing.Point(532, 583);
            this.pb_printedPic.Name = "pb_printedPic";
            this.pb_printedPic.Size = new System.Drawing.Size(205, 158);
            this.pb_printedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_printedPic.TabIndex = 65;
            this.pb_printedPic.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(514, 552);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 64;
            this.label18.Text = "Pic:";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(495, 486);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(233, 28);
            this.btn_submit.TabIndex = 63;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(550, 765);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(154, 42);
            this.btn_print.TabIndex = 61;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(495, 429);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(100, 28);
            this.btn_browse.TabIndex = 60;
            this.btn_browse.Text = "Browse:";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_female.Location = new System.Drawing.Point(495, 151);
            this.rd_female.Margin = new System.Windows.Forms.Padding(4);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(77, 21);
            this.rd_female.TabIndex = 59;
            this.rd_female.TabStop = true;
            this.rd_female.Text = "Female";
            this.rd_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(495, 116);
            this.rb_male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(60, 21);
            this.rb_male.TabIndex = 58;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(491, 223);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 57;
            this.label17.Text = "Your Pic:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(56, 801);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Subjects:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(56, 765);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 55;
            this.label15.Text = "Hobbies:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(56, 734);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "City:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 699);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Gender:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 658);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Mobile no:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 624);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 589);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Frist Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 546);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "Submitted info:";
            // 
            // cb_design
            // 
            this.cb_design.AutoSize = true;
            this.cb_design.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_design.Location = new System.Drawing.Point(187, 486);
            this.cb_design.Margin = new System.Windows.Forms.Padding(4);
            this.cb_design.Name = "cb_design";
            this.cb_design.Size = new System.Drawing.Size(76, 21);
            this.cb_design.TabIndex = 47;
            this.cb_design.Text = "Design";
            this.cb_design.UseVisualStyleBackColor = true;
            // 
            // cb_programming
            // 
            this.cb_programming.AutoSize = true;
            this.cb_programming.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_programming.Location = new System.Drawing.Point(187, 457);
            this.cb_programming.Margin = new System.Windows.Forms.Padding(4);
            this.cb_programming.Name = "cb_programming";
            this.cb_programming.Size = new System.Drawing.Size(124, 21);
            this.cb_programming.TabIndex = 46;
            this.cb_programming.Text = "Programming";
            this.cb_programming.UseVisualStyleBackColor = true;
            // 
            // cb_english
            // 
            this.cb_english.AutoSize = true;
            this.cb_english.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_english.Location = new System.Drawing.Point(187, 429);
            this.cb_english.Margin = new System.Windows.Forms.Padding(4);
            this.cb_english.Name = "cb_english";
            this.cb_english.Size = new System.Drawing.Size(79, 21);
            this.cb_english.TabIndex = 45;
            this.cb_english.Text = "English";
            this.cb_english.UseVisualStyleBackColor = true;
            // 
            // cb_math
            // 
            this.cb_math.AutoSize = true;
            this.cb_math.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_math.Location = new System.Drawing.Point(187, 401);
            this.cb_math.Margin = new System.Windows.Forms.Padding(4);
            this.cb_math.Name = "cb_math";
            this.cb_math.Size = new System.Drawing.Size(65, 21);
            this.cb_math.TabIndex = 44;
            this.cb_math.Text = "Math";
            this.cb_math.UseVisualStyleBackColor = true;
            // 
            // txt_mobileNo
            // 
            this.txt_mobileNo.Location = new System.Drawing.Point(187, 151);
            this.txt_mobileNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mobileNo.Name = "txt_mobileNo";
            this.txt_mobileNo.Size = new System.Drawing.Size(275, 22);
            this.txt_mobileNo.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(491, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Gender:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(187, 82);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(275, 22);
            this.txt_firstName.TabIndex = 41;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(187, 114);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(275, 22);
            this.txt_lastName.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 401);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Subjects:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Hobbies:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mobile no:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Frist Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Student info:";
            // 
            // lbl_fisrtname
            // 
            this.lbl_fisrtname.AutoSize = true;
            this.lbl_fisrtname.Location = new System.Drawing.Point(201, 590);
            this.lbl_fisrtname.Name = "lbl_fisrtname";
            this.lbl_fisrtname.Size = new System.Drawing.Size(10, 16);
            this.lbl_fisrtname.TabIndex = 66;
            this.lbl_fisrtname.Text = " ";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(201, 624);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(10, 16);
            this.lbl_lastname.TabIndex = 68;
            this.lbl_lastname.Text = " ";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(201, 802);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(10, 16);
            this.lbl_subject.TabIndex = 69;
            this.lbl_subject.Text = " ";
            // 
            // lbl_hobbies
            // 
            this.lbl_hobbies.AutoSize = true;
            this.lbl_hobbies.Location = new System.Drawing.Point(201, 765);
            this.lbl_hobbies.Name = "lbl_hobbies";
            this.lbl_hobbies.Size = new System.Drawing.Size(10, 16);
            this.lbl_hobbies.TabIndex = 70;
            this.lbl_hobbies.Text = " ";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(201, 734);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(10, 16);
            this.lbl_city.TabIndex = 71;
            this.lbl_city.Text = " ";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(201, 700);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(10, 16);
            this.lbl_gender.TabIndex = 72;
            this.lbl_gender.Text = " ";
            // 
            // lbl_mobileNo
            // 
            this.lbl_mobileNo.AutoSize = true;
            this.lbl_mobileNo.Location = new System.Drawing.Point(201, 659);
            this.lbl_mobileNo.Name = "lbl_mobileNo";
            this.lbl_mobileNo.Size = new System.Drawing.Size(10, 16);
            this.lbl_mobileNo.TabIndex = 73;
            this.lbl_mobileNo.Text = " ";
            // 
            // pb_submitedPic
            // 
            this.pb_submitedPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_submitedPic.Location = new System.Drawing.Point(523, 243);
            this.pb_submitedPic.Name = "pb_submitedPic";
            this.pb_submitedPic.Size = new System.Drawing.Size(205, 158);
            this.pb_submitedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_submitedPic.TabIndex = 74;
            this.pb_submitedPic.TabStop = false;
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(187, 192);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(275, 24);
            this.cb_city.TabIndex = 75;
            // 
            // list_hobbies
            // 
            this.list_hobbies.FormattingEnabled = true;
            this.list_hobbies.ItemHeight = 16;
            this.list_hobbies.Location = new System.Drawing.Point(187, 243);
            this.list_hobbies.Name = "list_hobbies";
            this.list_hobbies.Size = new System.Drawing.Size(275, 132);
            this.list_hobbies.TabIndex = 76;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 843);
            this.Controls.Add(this.list_hobbies);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.pb_submitedPic);
            this.Controls.Add(this.lbl_mobileNo);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_hobbies);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_fisrtname);
            this.Controls.Add(this.pb_printedPic);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.rd_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_design);
            this.Controls.Add(this.cb_programming);
            this.Controls.Add(this.cb_english);
            this.Controls.Add(this.cb_math);
            this.Controls.Add(this.txt_mobileNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_printedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_submitedPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox pb_printedPic;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_browse;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb_design;
        private System.Windows.Forms.CheckBox cb_programming;
        private System.Windows.Forms.CheckBox cb_english;
        private System.Windows.Forms.CheckBox cb_math;
        private System.Windows.Forms.TextBox txt_mobileNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fisrtname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_hobbies;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_mobileNo;
        private System.Windows.Forms.PictureBox pb_submitedPic;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.ListBox list_hobbies;
    }
}

