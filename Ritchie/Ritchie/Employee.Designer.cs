namespace Ritchie
{
    partial class Employee
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
            this.rbDisplayEmployee = new System.Windows.Forms.RadioButton();
            this.rbAddEmployee = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEmployeeName = new System.Windows.Forms.ComboBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.txtEmployeeTitle = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddess = new System.Windows.Forms.TextBox();
            this.txtEMployeePhone = new System.Windows.Forms.TextBox();
            this.txtEmployeePaySCale = new System.Windows.Forms.TextBox();
            this.dtEmployeeDOb = new System.Windows.Forms.DateTimePicker();
            this.btnEmpoyeeOptions = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // rbDisplayEmployee
            // 
            this.rbDisplayEmployee.AutoSize = true;
            this.rbDisplayEmployee.Location = new System.Drawing.Point(285, 76);
            this.rbDisplayEmployee.Name = "rbDisplayEmployee";
            this.rbDisplayEmployee.Size = new System.Drawing.Size(141, 21);
            this.rbDisplayEmployee.TabIndex = 1;
            this.rbDisplayEmployee.TabStop = true;
            this.rbDisplayEmployee.Text = "Display Employee";
            this.rbDisplayEmployee.UseVisualStyleBackColor = true;
            this.rbDisplayEmployee.CheckedChanged += new System.EventHandler(this.rbDisplayEmployee_CheckedChanged);
            // 
            // rbAddEmployee
            // 
            this.rbAddEmployee.AutoSize = true;
            this.rbAddEmployee.Location = new System.Drawing.Point(499, 74);
            this.rbAddEmployee.Name = "rbAddEmployee";
            this.rbAddEmployee.Size = new System.Drawing.Size(120, 21);
            this.rbAddEmployee.TabIndex = 2;
            this.rbAddEmployee.TabStop = true;
            this.rbAddEmployee.Text = "Add Employee";
            this.rbAddEmployee.UseVisualStyleBackColor = true;
            this.rbAddEmployee.CheckedChanged += new System.EventHandler(this.rbAddEmployee_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manager ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Employee Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Employee Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Employee DOB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Employee Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(615, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Employee Pay Scale";
            // 
            // cbEmployeeName
            // 
            this.cbEmployeeName.FormattingEnabled = true;
            this.cbEmployeeName.Location = new System.Drawing.Point(285, 144);
            this.cbEmployeeName.Name = "cbEmployeeName";
            this.cbEmployeeName.Size = new System.Drawing.Size(209, 24);
            this.cbEmployeeName.TabIndex = 12;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(285, 211);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(209, 22);
            this.txtEmployeeID.TabIndex = 13;
            // 
            // txtManagerID
            // 
            this.txtManagerID.Location = new System.Drawing.Point(285, 297);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.Size = new System.Drawing.Size(209, 22);
            this.txtManagerID.TabIndex = 14;
            // 
            // txtEmployeeTitle
            // 
            this.txtEmployeeTitle.Location = new System.Drawing.Point(285, 379);
            this.txtEmployeeTitle.Name = "txtEmployeeTitle";
            this.txtEmployeeTitle.Size = new System.Drawing.Size(209, 22);
            this.txtEmployeeTitle.TabIndex = 15;
            // 
            // txtEmployeeAddess
            // 
            this.txtEmployeeAddess.Location = new System.Drawing.Point(285, 460);
            this.txtEmployeeAddess.Name = "txtEmployeeAddess";
            this.txtEmployeeAddess.Size = new System.Drawing.Size(209, 22);
            this.txtEmployeeAddess.TabIndex = 16;
            // 
            // txtEMployeePhone
            // 
            this.txtEMployeePhone.Location = new System.Drawing.Point(774, 214);
            this.txtEMployeePhone.Name = "txtEMployeePhone";
            this.txtEMployeePhone.Size = new System.Drawing.Size(200, 22);
            this.txtEMployeePhone.TabIndex = 18;
            // 
            // txtEmployeePaySCale
            // 
            this.txtEmployeePaySCale.Location = new System.Drawing.Point(774, 280);
            this.txtEmployeePaySCale.Name = "txtEmployeePaySCale";
            this.txtEmployeePaySCale.Size = new System.Drawing.Size(200, 22);
            this.txtEmployeePaySCale.TabIndex = 19;
            // 
            // dtEmployeeDOb
            // 
            this.dtEmployeeDOb.Location = new System.Drawing.Point(774, 145);
            this.dtEmployeeDOb.Name = "dtEmployeeDOb";
            this.dtEmployeeDOb.Size = new System.Drawing.Size(200, 22);
            this.dtEmployeeDOb.TabIndex = 20;
            // 
            // btnEmpoyeeOptions
            // 
            this.btnEmpoyeeOptions.Location = new System.Drawing.Point(285, 537);
            this.btnEmpoyeeOptions.Name = "btnEmpoyeeOptions";
            this.btnEmpoyeeOptions.Size = new System.Drawing.Size(123, 41);
            this.btnEmpoyeeOptions.TabIndex = 21;
            this.btnEmpoyeeOptions.Text = "Display";
            this.btnEmpoyeeOptions.UseVisualStyleBackColor = true;
            this.btnEmpoyeeOptions.Click += new System.EventHandler(this.btnEmpoyeeOptions_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(26, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 17);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Department";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(128, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(75, 17);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Equipment";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(223, 9);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(79, 17);
            this.linkLabel3.TabIndex = 24;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Lost Found";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(318, 9);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(59, 17);
            this.linkLabel4.TabIndex = 25;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Member";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(407, 9);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(92, 17);
            this.linkLabel5.TabIndex = 26;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Order Placed";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(513, 9);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(84, 17);
            this.linkLabel6.TabIndex = 27;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Usage Time";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(630, 9);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(54, 17);
            this.linkLabel7.TabIndex = 28;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Vendor";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(723, 9);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(76, 17);
            this.linkLabel8.TabIndex = 29;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Work Hour";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Department ID";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(774, 343);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(200, 22);
            this.txtDepartmentID.TabIndex = 31;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 769);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnEmpoyeeOptions);
            this.Controls.Add(this.dtEmployeeDOb);
            this.Controls.Add(this.txtEmployeePaySCale);
            this.Controls.Add(this.txtEMployeePhone);
            this.Controls.Add(this.txtEmployeeAddess);
            this.Controls.Add(this.txtEmployeeTitle);
            this.Controls.Add(this.txtManagerID);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.cbEmployeeName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbAddEmployee);
            this.Controls.Add(this.rbDisplayEmployee);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Ritchie Coliseum-Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDisplayEmployee;
        private System.Windows.Forms.RadioButton rbAddEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.TextBox txtEmployeeTitle;
        private System.Windows.Forms.TextBox txtEmployeeAddess;
        private System.Windows.Forms.TextBox txtEMployeePhone;
        private System.Windows.Forms.TextBox txtEmployeePaySCale;
        private System.Windows.Forms.DateTimePicker dtEmployeeDOb;
        private System.Windows.Forms.Button btnEmpoyeeOptions;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepartmentID;
    }
}