namespace Ritchie
{
    partial class WorkHour
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEMployeeID = new System.Windows.Forms.TextBox();
            this.dtClockIn = new System.Windows.Forms.DateTimePicker();
            this.Department = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.Employee = new System.Windows.Forms.LinkLabel();
            this.dgvworkhour = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtclockin = new System.Windows.Forms.TextBox();
            this.txtclockout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbDisplay = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvworkhour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clock Out (HH:MM:SS)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clock In (HH:MM:SS)";
            // 
            // txtEMployeeID
            // 
            this.txtEMployeeID.Location = new System.Drawing.Point(226, 117);
            this.txtEMployeeID.Name = "txtEMployeeID";
            this.txtEMployeeID.Size = new System.Drawing.Size(298, 22);
            this.txtEMployeeID.TabIndex = 3;
            // 
            // dtClockIn
            // 
            this.dtClockIn.Location = new System.Drawing.Point(226, 181);
            this.dtClockIn.Name = "dtClockIn";
            this.dtClockIn.Size = new System.Drawing.Size(298, 22);
            this.dtClockIn.TabIndex = 4;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(46, 24);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(82, 17);
            this.Department.TabIndex = 6;
            this.Department.TabStop = true;
            this.Department.Text = "Department";
            this.Department.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Department_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(770, 24);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(84, 17);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Usage Time";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(637, 24);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(92, 17);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Order Placed";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(534, 24);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(59, 17);
            this.linkLabel4.TabIndex = 9;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Member";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(400, 24);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(79, 17);
            this.linkLabel5.TabIndex = 10;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Lost Found";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(284, 24);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(75, 17);
            this.linkLabel6.TabIndex = 11;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Equipment";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(171, 24);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(70, 17);
            this.Employee.TabIndex = 12;
            this.Employee.TabStop = true;
            this.Employee.Text = "Employee";
            this.Employee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Employee_LinkClicked);
            // 
            // dgvworkhour
            // 
            this.dgvworkhour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvworkhour.Location = new System.Drawing.Point(196, 342);
            this.dgvworkhour.Name = "dgvworkhour";
            this.dgvworkhour.RowTemplate.Height = 24;
            this.dgvworkhour.Size = new System.Drawing.Size(569, 201);
            this.dgvworkhour.TabIndex = 13;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(737, 117);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(131, 41);
            this.btnDisplay.TabIndex = 14;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(904, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vendor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date";
            // 
            // txtclockin
            // 
            this.txtclockin.Location = new System.Drawing.Point(226, 261);
            this.txtclockin.Name = "txtclockin";
            this.txtclockin.Size = new System.Drawing.Size(177, 22);
            this.txtclockin.TabIndex = 17;
            // 
            // txtclockout
            // 
            this.txtclockout.Location = new System.Drawing.Point(618, 258);
            this.txtclockout.Name = "txtclockout";
            this.txtclockout.Size = new System.Drawing.Size(161, 22);
            this.txtclockout.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Options";
            // 
            // rbDisplay
            // 
            this.rbDisplay.AutoSize = true;
            this.rbDisplay.Location = new System.Drawing.Point(226, 64);
            this.rbDisplay.Name = "rbDisplay";
            this.rbDisplay.Size = new System.Drawing.Size(75, 21);
            this.rbDisplay.TabIndex = 20;
            this.rbDisplay.TabStop = true;
            this.rbDisplay.Text = "Display";
            this.rbDisplay.UseVisualStyleBackColor = true;
            this.rbDisplay.CheckedChanged += new System.EventHandler(this.rbDisplay_CheckedChanged);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(403, 64);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(54, 21);
            this.rbAdd.TabIndex = 21;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // WorkHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 748);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.rbDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtclockout);
            this.Controls.Add(this.txtclockin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.dgvworkhour);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.dtClockIn);
            this.Controls.Add(this.txtEMployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorkHour";
            this.Text = "Ritchie Coliseum-WorkHour";
            this.Load += new System.EventHandler(this.WorkHour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvworkhour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEMployeeID;
        private System.Windows.Forms.DateTimePicker dtClockIn;
        private System.Windows.Forms.LinkLabel Department;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel Employee;
        private System.Windows.Forms.DataGridView dgvworkhour;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtclockin;
        private System.Windows.Forms.TextBox txtclockout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDisplay;
        private System.Windows.Forms.RadioButton rbAdd;
    }
}