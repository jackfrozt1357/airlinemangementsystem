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
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(115, 27);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 0;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(115, 106);
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
            this.destination.Location = new System.Drawing.Point(287, 265);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(121, 21);
            this.destination.TabIndex = 3;
            // 
            // userdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 510);
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
    }
}