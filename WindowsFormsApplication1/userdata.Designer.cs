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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userdata));
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.origin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departtime = new System.Windows.Forms.ComboBox();
            this.arrivaltime = new System.Windows.Forms.TextBox();
            this.flightclass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lastname1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firstname1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firs = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.airline = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numticket = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(414, 57);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 0;
            this.firstname.Visible = false;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(414, 131);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 0;
            this.lastname.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.label7);
            this.bunifuGradientPanel2.Controls.Add(this.origin);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.label4);
            this.bunifuGradientPanel2.Controls.Add(this.departtime);
            this.bunifuGradientPanel2.Controls.Add(this.arrivaltime);
            this.bunifuGradientPanel2.Controls.Add(this.flightclass);
            this.bunifuGradientPanel2.Controls.Add(this.label3);
            this.bunifuGradientPanel2.Controls.Add(this.label8);
            this.bunifuGradientPanel2.Controls.Add(this.destination);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(578, 78);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(295, 309);
            this.bunifuGradientPanel2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "origin";
            // 
            // origin
            // 
            this.origin.FormattingEnabled = true;
            this.origin.Items.AddRange(new object[] {
            "Paris,France",
            "U.S.A,New-York",
            "Nigeria,Lagos",
            ""});
            this.origin.Location = new System.Drawing.Point(43, 43);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(235, 21);
            this.origin.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "class";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Departure Time";
            // 
            // departtime
            // 
            this.departtime.FormattingEnabled = true;
            this.departtime.Items.AddRange(new object[] {
            "8:00am",
            "10:00am",
            "12:00pm",
            "8:00pm"});
            this.departtime.Location = new System.Drawing.Point(157, 248);
            this.departtime.Name = "departtime";
            this.departtime.Size = new System.Drawing.Size(121, 21);
            this.departtime.TabIndex = 13;
            // 
            // arrivaltime
            // 
            this.arrivaltime.Location = new System.Drawing.Point(43, 248);
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.Size = new System.Drawing.Size(100, 20);
            this.arrivaltime.TabIndex = 14;
            // 
            // flightclass
            // 
            this.flightclass.FormattingEnabled = true;
            this.flightclass.Items.AddRange(new object[] {
            "First Class",
            "Business Class",
            "Economy"});
            this.flightclass.Location = new System.Drawing.Point(43, 131);
            this.flightclass.Name = "flightclass";
            this.flightclass.Size = new System.Drawing.Size(235, 21);
            this.flightclass.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "destination";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Arrival time";
            // 
            // destination
            // 
            this.destination.FormattingEnabled = true;
            this.destination.Items.AddRange(new object[] {
            "Paris,France",
            "U.S.A,New-York",
            "Nigeria,Lagos",
            ""});
            this.destination.Location = new System.Drawing.Point(43, 186);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(235, 21);
            this.destination.TabIndex = 3;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lastname1);
            this.bunifuGradientPanel1.Controls.Add(this.firstname1);
            this.bunifuGradientPanel1.Controls.Add(this.firs);
            this.bunifuGradientPanel1.Controls.Add(this.last);
            this.bunifuGradientPanel1.Controls.Add(this.airline);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.numticket);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(25, 68);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(383, 309);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // lastname1
            // 
            this.lastname1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lastname1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lastname1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lastname1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lastname1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastname1.HintForeColor = System.Drawing.Color.Empty;
            this.lastname1.HintText = "";
            this.lastname1.isPassword = false;
            this.lastname1.LineFocusedColor = System.Drawing.Color.Blue;
            this.lastname1.LineIdleColor = System.Drawing.Color.Gray;
            this.lastname1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lastname1.LineThickness = 3;
            this.lastname1.Location = new System.Drawing.Point(39, 118);
            this.lastname1.Margin = new System.Windows.Forms.Padding(4);
            this.lastname1.MaxLength = 32767;
            this.lastname1.Name = "lastname1";
            this.lastname1.Size = new System.Drawing.Size(322, 34);
            this.lastname1.TabIndex = 20;
            this.lastname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // firstname1
            // 
            this.firstname1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.firstname1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.firstname1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.firstname1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.firstname1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstname1.HintForeColor = System.Drawing.Color.Empty;
            this.firstname1.HintText = "";
            this.firstname1.isPassword = false;
            this.firstname1.LineFocusedColor = System.Drawing.Color.Blue;
            this.firstname1.LineIdleColor = System.Drawing.Color.Gray;
            this.firstname1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.firstname1.LineThickness = 3;
            this.firstname1.Location = new System.Drawing.Point(39, 43);
            this.firstname1.Margin = new System.Windows.Forms.Padding(4);
            this.firstname1.MaxLength = 32767;
            this.firstname1.Name = "firstname1";
            this.firstname1.Size = new System.Drawing.Size(322, 34);
            this.firstname1.TabIndex = 19;
            this.firstname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // firs
            // 
            this.firs.AutoSize = true;
            this.firs.Location = new System.Drawing.Point(36, 26);
            this.firs.Name = "firs";
            this.firs.Size = new System.Drawing.Size(52, 13);
            this.firs.TabIndex = 4;
            this.firs.Text = "Firstname";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Location = new System.Drawing.Point(36, 101);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(49, 13);
            this.last.TabIndex = 5;
            this.last.Text = "lastname";
            // 
            // airline
            // 
            this.airline.FormattingEnabled = true;
            this.airline.Items.AddRange(new object[] {
            "Virgin",
            "Qatar",
            "Emirates"});
            this.airline.Location = new System.Drawing.Point(39, 186);
            this.airline.Name = "airline";
            this.airline.Size = new System.Drawing.Size(322, 21);
            this.airline.TabIndex = 1;
            this.airline.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "AirLine";
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
            this.numticket.Location = new System.Drawing.Point(39, 247);
            this.numticket.Name = "numticket";
            this.numticket.Size = new System.Drawing.Size(322, 21);
            this.numticket.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number of Ticket";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(794, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userdata";
            this.Text = "v";
            this.Load += new System.EventHandler(this.userdata_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstname1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastname1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}