namespace Ritchie
{
    partial class Department
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
            this.cbdepartmentname = new System.Windows.Forms.ComboBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lbldepartmentID = new System.Windows.Forms.Label();
            this.lbldepartmentphone = new System.Windows.Forms.Label();
            this.lbldepartmentLocation = new System.Windows.Forms.Label();
            this.txtdepartmentid = new System.Windows.Forms.TextBox();
            this.txtdepartmentphone = new System.Windows.Forms.TextBox();
            this.txtdepartmentlocation = new System.Windows.Forms.TextBox();
            this.lbloptions = new System.Windows.Forms.Label();
            this.rbdisplay = new System.Windows.Forms.RadioButton();
            this.rbinsert = new System.Windows.Forms.RadioButton();
            this.btndepartmentaction = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cbdepartmentname
            // 
            this.cbdepartmentname.FormattingEnabled = true;
            this.cbdepartmentname.Location = new System.Drawing.Point(265, 147);
            this.cbdepartmentname.Name = "cbdepartmentname";
            this.cbdepartmentname.Size = new System.Drawing.Size(326, 24);
            this.cbdepartmentname.TabIndex = 0;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(51, 147);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(123, 17);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lbldepartmentID
            // 
            this.lbldepartmentID.AutoSize = true;
            this.lbldepartmentID.Location = new System.Drawing.Point(49, 205);
            this.lbldepartmentID.Name = "lbldepartmentID";
            this.lbldepartmentID.Size = new System.Drawing.Size(99, 17);
            this.lbldepartmentID.TabIndex = 2;
            this.lbldepartmentID.Text = "Department ID";
            this.lbldepartmentID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldepartmentphone
            // 
            this.lbldepartmentphone.AutoSize = true;
            this.lbldepartmentphone.Location = new System.Drawing.Point(49, 269);
            this.lbldepartmentphone.Name = "lbldepartmentphone";
            this.lbldepartmentphone.Size = new System.Drawing.Size(127, 17);
            this.lbldepartmentphone.TabIndex = 3;
            this.lbldepartmentphone.Text = "Department Phone";
            // 
            // lbldepartmentLocation
            // 
            this.lbldepartmentLocation.AutoSize = true;
            this.lbldepartmentLocation.Location = new System.Drawing.Point(49, 333);
            this.lbldepartmentLocation.Name = "lbldepartmentLocation";
            this.lbldepartmentLocation.Size = new System.Drawing.Size(140, 17);
            this.lbldepartmentLocation.TabIndex = 4;
            this.lbldepartmentLocation.Text = "Department Location";
            // 
            // txtdepartmentid
            // 
            this.txtdepartmentid.Location = new System.Drawing.Point(266, 205);
            this.txtdepartmentid.Name = "txtdepartmentid";
            this.txtdepartmentid.Size = new System.Drawing.Size(325, 22);
            this.txtdepartmentid.TabIndex = 5;
            // 
            // txtdepartmentphone
            // 
            this.txtdepartmentphone.Location = new System.Drawing.Point(269, 264);
            this.txtdepartmentphone.Name = "txtdepartmentphone";
            this.txtdepartmentphone.Size = new System.Drawing.Size(322, 22);
            this.txtdepartmentphone.TabIndex = 6;
            // 
            // txtdepartmentlocation
            // 
            this.txtdepartmentlocation.Location = new System.Drawing.Point(269, 330);
            this.txtdepartmentlocation.Name = "txtdepartmentlocation";
            this.txtdepartmentlocation.Size = new System.Drawing.Size(322, 22);
            this.txtdepartmentlocation.TabIndex = 7;
            // 
            // lbloptions
            // 
            this.lbloptions.AutoSize = true;
            this.lbloptions.Location = new System.Drawing.Point(53, 78);
            this.lbloptions.Name = "lbloptions";
            this.lbloptions.Size = new System.Drawing.Size(57, 17);
            this.lbloptions.TabIndex = 8;
            this.lbloptions.Text = "Options";
            // 
            // rbdisplay
            // 
            this.rbdisplay.AutoSize = true;
            this.rbdisplay.Location = new System.Drawing.Point(265, 78);
            this.rbdisplay.Name = "rbdisplay";
            this.rbdisplay.Size = new System.Drawing.Size(151, 21);
            this.rbdisplay.TabIndex = 9;
            this.rbdisplay.TabStop = true;
            this.rbdisplay.Text = "Display department";
            this.rbdisplay.UseVisualStyleBackColor = true;
            this.rbdisplay.CheckedChanged += new System.EventHandler(this.rbdisplay_CheckedChanged);
            // 
            // rbinsert
            // 
            this.rbinsert.AutoSize = true;
            this.rbinsert.Location = new System.Drawing.Point(468, 76);
            this.rbinsert.Name = "rbinsert";
            this.rbinsert.Size = new System.Drawing.Size(132, 21);
            this.rbinsert.TabIndex = 10;
            this.rbinsert.TabStop = true;
            this.rbinsert.Text = "Add Department";
            this.rbinsert.UseVisualStyleBackColor = true;
            this.rbinsert.CheckedChanged += new System.EventHandler(this.rbinsert_CheckedChanged);
            // 
            // btndepartmentaction
            // 
            this.btndepartmentaction.Location = new System.Drawing.Point(269, 432);
            this.btndepartmentaction.Name = "btndepartmentaction";
            this.btndepartmentaction.Size = new System.Drawing.Size(99, 38);
            this.btndepartmentaction.TabIndex = 11;
            this.btndepartmentaction.Text = "Display";
            this.btndepartmentaction.UseVisualStyleBackColor = true;
            this.btndepartmentaction.Click += new System.EventHandler(this.btndepartmentaction_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(31, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Employee";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(866, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 17);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Vendor";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(718, 13);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(84, 17);
            this.linkLabel3.TabIndex = 14;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Usage Time";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(571, 13);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(92, 17);
            this.linkLabel4.TabIndex = 15;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Order Placed";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(429, 13);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(75, 17);
            this.linkLabel5.TabIndex = 16;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "LostFound";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(292, 13);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(59, 17);
            this.linkLabel6.TabIndex = 17;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Member";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(160, 13);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(75, 17);
            this.linkLabel7.TabIndex = 18;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Equipment";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(979, 13);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(76, 17);
            this.linkLabel8.TabIndex = 19;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Work Hour";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 757);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btndepartmentaction);
            this.Controls.Add(this.rbinsert);
            this.Controls.Add(this.rbdisplay);
            this.Controls.Add(this.lbloptions);
            this.Controls.Add(this.txtdepartmentlocation);
            this.Controls.Add(this.txtdepartmentphone);
            this.Controls.Add(this.txtdepartmentid);
            this.Controls.Add(this.lbldepartmentLocation);
            this.Controls.Add(this.lbldepartmentphone);
            this.Controls.Add(this.lbldepartmentID);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.cbdepartmentname);
            this.Name = "Department";
            this.Text = "Ritchie Coliseum-Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbdepartmentname;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lbldepartmentID;
        private System.Windows.Forms.Label lbldepartmentphone;
        private System.Windows.Forms.Label lbldepartmentLocation;
        private System.Windows.Forms.TextBox txtdepartmentid;
        private System.Windows.Forms.TextBox txtdepartmentphone;
        private System.Windows.Forms.TextBox txtdepartmentlocation;
        private System.Windows.Forms.Label lbloptions;
        private System.Windows.Forms.RadioButton rbdisplay;
        private System.Windows.Forms.RadioButton rbinsert;
        private System.Windows.Forms.Button btndepartmentaction;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
    }
}

