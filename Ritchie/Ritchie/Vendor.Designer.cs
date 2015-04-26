namespace Ritchie
{
    partial class Vendor
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
            this.lblOptions = new System.Windows.Forms.Label();
            this.rbdisplayvendor = new System.Windows.Forms.RadioButton();
            this.rbAddVendor = new System.Windows.Forms.RadioButton();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.cbVendorName = new System.Windows.Forms.ComboBox();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtVendorPhone = new System.Windows.Forms.TextBox();
            this.txtVendorAddress = new System.Windows.Forms.TextBox();
            this.btnoptions = new System.Windows.Forms.Button();
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
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(81, 50);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(57, 17);
            this.lblOptions.TabIndex = 0;
            this.lblOptions.Text = "Options";
            // 
            // rbdisplayvendor
            // 
            this.rbdisplayvendor.AutoSize = true;
            this.rbdisplayvendor.Location = new System.Drawing.Point(268, 50);
            this.rbdisplayvendor.Name = "rbdisplayvendor";
            this.rbdisplayvendor.Size = new System.Drawing.Size(125, 21);
            this.rbdisplayvendor.TabIndex = 1;
            this.rbdisplayvendor.TabStop = true;
            this.rbdisplayvendor.Text = "Display Vendor";
            this.rbdisplayvendor.UseVisualStyleBackColor = true;
            this.rbdisplayvendor.CheckedChanged += new System.EventHandler(this.rbdisplayvendor_CheckedChanged);
            // 
            // rbAddVendor
            // 
            this.rbAddVendor.AutoSize = true;
            this.rbAddVendor.Location = new System.Drawing.Point(507, 48);
            this.rbAddVendor.Name = "rbAddVendor";
            this.rbAddVendor.Size = new System.Drawing.Size(104, 21);
            this.rbAddVendor.TabIndex = 2;
            this.rbAddVendor.TabStop = true;
            this.rbAddVendor.Text = "Add Vendor";
            this.rbAddVendor.UseVisualStyleBackColor = true;
            this.rbAddVendor.CheckedChanged += new System.EventHandler(this.rbAddVendor_CheckedChanged);
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(84, 132);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(95, 17);
            this.lblVendorName.TabIndex = 3;
            this.lblVendorName.Text = "Vendor Name";
            // 
            // cbVendorName
            // 
            this.cbVendorName.FormattingEnabled = true;
            this.cbVendorName.Location = new System.Drawing.Point(277, 132);
            this.cbVendorName.Name = "cbVendorName";
            this.cbVendorName.Size = new System.Drawing.Size(270, 24);
            this.cbVendorName.TabIndex = 4;
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(84, 196);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(71, 17);
            this.lblVendorID.TabIndex = 5;
            this.lblVendorID.Text = "Vendor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vendor Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vendor Adddress";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(277, 196);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(270, 22);
            this.txtVendorID.TabIndex = 8;
            // 
            // txtVendorPhone
            // 
            this.txtVendorPhone.Location = new System.Drawing.Point(277, 264);
            this.txtVendorPhone.Name = "txtVendorPhone";
            this.txtVendorPhone.Size = new System.Drawing.Size(270, 22);
            this.txtVendorPhone.TabIndex = 9;
            // 
            // txtVendorAddress
            // 
            this.txtVendorAddress.Location = new System.Drawing.Point(277, 342);
            this.txtVendorAddress.Name = "txtVendorAddress";
            this.txtVendorAddress.Size = new System.Drawing.Size(270, 22);
            this.txtVendorAddress.TabIndex = 10;
            // 
            // btnoptions
            // 
            this.btnoptions.Location = new System.Drawing.Point(268, 471);
            this.btnoptions.Name = "btnoptions";
            this.btnoptions.Size = new System.Drawing.Size(109, 36);
            this.btnoptions.TabIndex = 11;
            this.btnoptions.Text = "Display";
            this.btnoptions.UseVisualStyleBackColor = true;
            this.btnoptions.Click += new System.EventHandler(this.btnoptions_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(44, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Department";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(789, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(84, 17);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Usage Time";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(651, 13);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(92, 17);
            this.linkLabel3.TabIndex = 14;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Order Placed";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(535, 13);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(59, 17);
            this.linkLabel4.TabIndex = 15;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Member";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(403, 13);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(79, 17);
            this.linkLabel5.TabIndex = 16;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Lost Found";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(274, 13);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(75, 17);
            this.linkLabel6.TabIndex = 17;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Equipment";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(165, 13);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(70, 17);
            this.linkLabel7.TabIndex = 18;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Employee";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(918, 13);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(83, 17);
            this.linkLabel8.TabIndex = 19;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Work Hours";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 785);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnoptions);
            this.Controls.Add(this.txtVendorAddress);
            this.Controls.Add(this.txtVendorPhone);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.cbVendorName);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.rbAddVendor);
            this.Controls.Add(this.rbdisplayvendor);
            this.Controls.Add(this.lblOptions);
            this.Name = "Vendor";
            this.Text = "Ritchie Coliseum-Vendor";
            this.Load += new System.EventHandler(this.Vendor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.RadioButton rbdisplayvendor;
        private System.Windows.Forms.RadioButton rbAddVendor;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.ComboBox cbVendorName;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtVendorPhone;
        private System.Windows.Forms.TextBox txtVendorAddress;
        private System.Windows.Forms.Button btnoptions;
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