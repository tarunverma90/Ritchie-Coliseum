namespace Ritchie
{
    partial class LostFound
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbAddDetails = new System.Windows.Forms.RadioButton();
            this.rbDisplay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUniversityID = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtItemLost = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.dtDateLost = new System.Windows.Forms.DateTimePicker();
            this.dtdateFound = new System.Windows.Forms.DateTimePicker();
            this.btnOptions = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.dgvLostFound = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLostFound)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // rbAddDetails
            // 
            this.rbAddDetails.AutoSize = true;
            this.rbAddDetails.Location = new System.Drawing.Point(376, 82);
            this.rbAddDetails.Name = "rbAddDetails";
            this.rbAddDetails.Size = new System.Drawing.Size(101, 21);
            this.rbAddDetails.TabIndex = 1;
            this.rbAddDetails.TabStop = true;
            this.rbAddDetails.Text = "Add Details";
            this.rbAddDetails.UseVisualStyleBackColor = true;
            this.rbAddDetails.CheckedChanged += new System.EventHandler(this.rbAddDetails_CheckedChanged);
            // 
            // rbDisplay
            // 
            this.rbDisplay.AutoSize = true;
            this.rbDisplay.Location = new System.Drawing.Point(581, 82);
            this.rbDisplay.Name = "rbDisplay";
            this.rbDisplay.Size = new System.Drawing.Size(122, 21);
            this.rbDisplay.TabIndex = 2;
            this.rbDisplay.TabStop = true;
            this.rbDisplay.Text = "Display Details";
            this.rbDisplay.UseVisualStyleBackColor = true;
            this.rbDisplay.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "University ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Found";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status (R\\NR)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Lost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type (L\\F)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Item Lost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Item Description";
            // 
            // txtUniversityID
            // 
            this.txtUniversityID.Location = new System.Drawing.Point(303, 131);
            this.txtUniversityID.Name = "txtUniversityID";
            this.txtUniversityID.Size = new System.Drawing.Size(171, 22);
            this.txtUniversityID.TabIndex = 10;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(614, 219);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(154, 22);
            this.txtStatus.TabIndex = 11;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(614, 178);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(154, 22);
            this.txtType.TabIndex = 12;
            // 
            // txtItemLost
            // 
            this.txtItemLost.Location = new System.Drawing.Point(303, 178);
            this.txtItemLost.Name = "txtItemLost";
            this.txtItemLost.Size = new System.Drawing.Size(171, 22);
            this.txtItemLost.TabIndex = 13;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(614, 129);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(154, 22);
            this.txtItemDescription.TabIndex = 14;
            // 
            // dtDateLost
            // 
            this.dtDateLost.Location = new System.Drawing.Point(303, 221);
            this.dtDateLost.Name = "dtDateLost";
            this.dtDateLost.Size = new System.Drawing.Size(171, 22);
            this.dtDateLost.TabIndex = 15;
            // 
            // dtdateFound
            // 
            this.dtdateFound.Location = new System.Drawing.Point(303, 276);
            this.dtdateFound.Name = "dtdateFound";
            this.dtdateFound.Size = new System.Drawing.Size(171, 22);
            this.dtdateFound.TabIndex = 16;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(839, 155);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(109, 40);
            this.btnOptions.TabIndex = 17;
            this.btnOptions.Text = "Display";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(23, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Department";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(129, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(70, 17);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Employee";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(783, 13);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(54, 17);
            this.linkLabel3.TabIndex = 20;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Vendor";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(642, 13);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(84, 17);
            this.linkLabel4.TabIndex = 21;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Usage Time";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(499, 13);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(92, 17);
            this.linkLabel5.TabIndex = 22;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Order Placed";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(373, 13);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(59, 17);
            this.linkLabel6.TabIndex = 23;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Member";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(247, 13);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(75, 17);
            this.linkLabel7.TabIndex = 24;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Equipment";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(883, 13);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(76, 17);
            this.linkLabel8.TabIndex = 25;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Work Hour";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // dgvLostFound
            // 
            this.dgvLostFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLostFound.Location = new System.Drawing.Point(198, 339);
            this.dgvLostFound.Name = "dgvLostFound";
            this.dgvLostFound.RowTemplate.Height = 24;
            this.dgvLostFound.Size = new System.Drawing.Size(750, 256);
            this.dgvLostFound.TabIndex = 26;
            // 
            // LostFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 762);
            this.Controls.Add(this.dgvLostFound);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.dtdateFound);
            this.Controls.Add(this.dtDateLost);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.txtItemLost);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtUniversityID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbDisplay);
            this.Controls.Add(this.rbAddDetails);
            this.Controls.Add(this.label1);
            this.Name = "LostFound";
            this.Text = "Ritchie Coliseum-Lost and Found";
            this.Load += new System.EventHandler(this.LostFound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLostFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAddDetails;
        private System.Windows.Forms.RadioButton rbDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUniversityID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtItemLost;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.DateTimePicker dtDateLost;
        private System.Windows.Forms.DateTimePicker dtdateFound;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.DataGridView dgvLostFound;
    }
}