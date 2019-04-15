namespace WindowsFormsApplication1
{
    partial class userdata
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
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.airline = new System.Windows.Forms.ComboBox();
            this.numticket = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.firs = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.origin = new System.Windows.Forms.ComboBox();
            this.departtime = new System.Windows.Forms.ComboBox();
            this.arrivaltime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flightclass = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(156, 37);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 0;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(89, 106);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 0;
            // 
            // airline
            // 
            this.airline.FormattingEnabled = true;
            this.airline.Items.AddRange(new object[] {
            "Virgin",
            "Qatar",
            "Emirates"});
            this.airline.Location = new System.Drawing.Point(644, 37);
            this.airline.Name = "airline";
            this.airline.Size = new System.Drawing.Size(121, 21);
            this.airline.TabIndex = 1;
            this.airline.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numticket
            // 
            this.numticket.FormattingEnabled = true;
            this.numticket.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.numticket.Location = new System.Drawing.Point(657, 106);
            this.numticket.Name = "numticket";
            this.numticket.Size = new System.Drawing.Size(121, 21);
            this.numticket.TabIndex = 2;
            // 
            // destination
            // 
            this.destination.FormattingEnabled = true;
            this.destination.Items.AddRange(new object[] {
            "Paris,France",
            "U.S.A,New-York",
            "Nigeria,Lagos",
            ""});
            this.destination.Location = new System.Drawing.Point(89, 210);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(121, 21);
            this.destination.TabIndex = 3;
            // 
            // firs
            // 
            this.firs.AutoSize = true;
            this.firs.Location = new System.Drawing.Point(49, 9);
            this.firs.Name = "firs";
            this.firs.Size = new System.Drawing.Size(15, 13);
            this.firs.TabIndex = 4;
            this.firs.Text = "fir";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Location = new System.Drawing.Point(49, 80);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(23, 13);
            this.last.TabIndex = 5;
            this.last.Text = "last";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "des";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "departtime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "airine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "noofticket";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(614, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "orig";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "arrivaltime";
            // 
            // origin
            // 
            this.origin.FormattingEnabled = true;
            this.origin.Items.AddRange(new object[] {
            "Paris,France",
            "U.S.A,New-York",
            "Nigeria,Lagos",
            ""});
            this.origin.Location = new System.Drawing.Point(671, 210);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(121, 21);
            this.origin.TabIndex = 12;
            // 
            // departtime
            // 
            this.departtime.FormattingEnabled = true;
            this.departtime.Items.AddRange(new object[] {
            "8:00am",
            "10:00am",
            "12:00pm",
            "8:00pm"});
            this.departtime.Location = new System.Drawing.Point(105, 336);
            this.departtime.Name = "departtime";
            this.departtime.Size = new System.Drawing.Size(121, 21);
            this.departtime.TabIndex = 13;
            // 
            // arrivaltime
            // 
            this.arrivaltime.Location = new System.Drawing.Point(671, 327);
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.Size = new System.Drawing.Size(100, 20);
            this.arrivaltime.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "class";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flightclass
            // 
            this.flightclass.FormattingEnabled = true;
            this.flightclass.Items.AddRange(new object[] {
            "First Class",
            "Business Class",
            "Economy"});
            this.flightclass.Location = new System.Drawing.Point(421, 267);
            this.flightclass.Name = "flightclass";
            this.flightclass.Size = new System.Drawing.Size(121, 21);
            this.flightclass.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flightclass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrivaltime);
            this.Controls.Add(this.departtime);
            this.Controls.Add(this.origin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.last);
            this.Controls.Add(this.firs);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.numticket);
            this.Controls.Add(this.airline);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Name = "userdata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.ComboBox airline;
        private System.Windows.Forms.ComboBox numticket;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.Label firs;
        private System.Windows.Forms.Label last;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox origin;
        private System.Windows.Forms.ComboBox departtime;
        private System.Windows.Forms.TextBox arrivaltime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox flightclass;
        private System.Windows.Forms.Button button1;
    }
}