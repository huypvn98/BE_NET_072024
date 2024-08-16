using System.Drawing;
using System.Windows.Forms;

namespace BE_07.WindowsForm
{
    partial class frmEmployeeManagement
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
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.txbEmpCode = new System.Windows.Forms.TextBox();
            this.txbEmpName = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbAllowance = new System.Windows.Forms.TextBox();
            this.txbSalary = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.rdoIntern = new System.Windows.Forms.RadioButton();
            this.rdoFulltime = new System.Windows.Forms.RadioButton();
            this.rdoParttime = new System.Windows.Forms.RadioButton();
            this.dtgvEmpList = new System.Windows.Forms.DataGridView();
            this.EmpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.Location = new System.Drawing.Point(8, 35);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(72, 13);
            this.lblEmpCode.TabIndex = 0;
            this.lblEmpCode.Text = "Mã nhân viên";
            // 
            // txbEmpCode
            // 
            this.txbEmpCode.Location = new System.Drawing.Point(96, 28);
            this.txbEmpCode.Name = "txbEmpCode";
            this.txbEmpCode.Size = new System.Drawing.Size(112, 20);
            this.txbEmpCode.TabIndex = 1;
            // 
            // txbEmpName
            // 
            this.txbEmpName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmpName.Location = new System.Drawing.Point(288, 28);
            this.txbEmpName.Name = "txbEmpName";
            this.txbEmpName.Size = new System.Drawing.Size(152, 20);
            this.txbEmpName.TabIndex = 3;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(8, 62);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(73, 13);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Lương cơ bản";
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Location = new System.Drawing.Point(232, 62);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(47, 13);
            this.lblAllowance.TabIndex = 9;
            this.lblAllowance.Text = "Phụ cấp";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(376, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 20);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbAllowance);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txbSalary);
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Controls.Add(this.rdoIntern);
            this.panel1.Controls.Add(this.lblAllowance);
            this.panel1.Controls.Add(this.rdoFulltime);
            this.panel1.Controls.Add(this.rdoParttime);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.lblEmpCode);
            this.panel1.Controls.Add(this.txbEmpCode);
            this.panel1.Controls.Add(this.txbEmpName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 120);
            this.panel1.TabIndex = 14;
            // 
            // txbAllowance
            // 
            this.txbAllowance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAllowance.Location = new System.Drawing.Point(288, 55);
            this.txbAllowance.Name = "txbAllowance";
            this.txbAllowance.Size = new System.Drawing.Size(152, 20);
            this.txbAllowance.TabIndex = 21;
            // 
            // txbSalary
            // 
            this.txbSalary.Location = new System.Drawing.Point(96, 55);
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.Size = new System.Drawing.Size(112, 20);
            this.txbSalary.TabIndex = 20;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(232, 35);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(39, 13);
            this.lblEmpName.TabIndex = 19;
            this.lblEmpName.Text = "Họ tên";
            // 
            // rdoIntern
            // 
            this.rdoIntern.AutoSize = true;
            this.rdoIntern.Location = new System.Drawing.Point(280, 8);
            this.rdoIntern.Name = "rdoIntern";
            this.rdoIntern.Size = new System.Drawing.Size(68, 17);
            this.rdoIntern.TabIndex = 18;
            this.rdoIntern.Text = "Thực tập";
            this.rdoIntern.UseVisualStyleBackColor = true;
            // 
            // rdoFulltime
            // 
            this.rdoFulltime.AutoSize = true;
            this.rdoFulltime.Checked = true;
            this.rdoFulltime.Location = new System.Drawing.Point(96, 8);
            this.rdoFulltime.Name = "rdoFulltime";
            this.rdoFulltime.Size = new System.Drawing.Size(93, 17);
            this.rdoFulltime.TabIndex = 15;
            this.rdoFulltime.TabStop = true;
            this.rdoFulltime.Text = "Toàn thời gian";
            this.rdoFulltime.UseVisualStyleBackColor = true;
            this.rdoFulltime.Click += new System.EventHandler(this.rdoFulltime_Click);
            // 
            // rdoParttime
            // 
            this.rdoParttime.AutoSize = true;
            this.rdoParttime.Location = new System.Drawing.Point(192, 8);
            this.rdoParttime.Name = "rdoParttime";
            this.rdoParttime.Size = new System.Drawing.Size(87, 17);
            this.rdoParttime.TabIndex = 16;
            this.rdoParttime.Text = "Bán thời gian";
            this.rdoParttime.UseVisualStyleBackColor = true;
            this.rdoParttime.Click += new System.EventHandler(this.rdoParttime_Click);
            // 
            // dtgvEmpList
            // 
            this.dtgvEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpCode,
            this.EmpName,
            this.TotalSalary,
            this.Salary,
            this.Allowance,
            this.WorkingHours});
            this.dtgvEmpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvEmpList.Location = new System.Drawing.Point(0, 120);
            this.dtgvEmpList.Name = "dtgvEmpList";
            this.dtgvEmpList.Size = new System.Drawing.Size(448, 189);
            this.dtgvEmpList.TabIndex = 15;
            // 
            // EmpCode
            // 
            this.EmpCode.DataPropertyName = "EmpCode";
            this.EmpCode.HeaderText = "Mã nhân viên";
            this.EmpCode.Name = "EmpCode";
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Họ tên";
            this.EmpName.Name = "EmpName";
            this.EmpName.Width = 180;
            // 
            // TotalSalary
            // 
            this.TotalSalary.DataPropertyName = "TotalSalary";
            this.TotalSalary.HeaderText = "Tổng lương";
            this.TotalSalary.Name = "TotalSalary";
            this.TotalSalary.Width = 125;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Lương";
            this.Salary.Name = "Salary";
            this.Salary.Visible = false;
            this.Salary.Width = 90;
            // 
            // Allowance
            // 
            this.Allowance.DataPropertyName = "Allowance";
            this.Allowance.HeaderText = "Hình thức";
            this.Allowance.Name = "Allowance";
            this.Allowance.Visible = false;
            // 
            // WorkingHours
            // 
            this.WorkingHours.DataPropertyName = "WorkingHours";
            this.WorkingHours.HeaderText = "Số giờ làm";
            this.WorkingHours.Name = "WorkingHours";
            this.WorkingHours.Visible = false;
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 309);
            this.Controls.Add(this.dtgvEmpList);
            this.Controls.Add(this.panel1);
            this.Name = "frmEmployeeManagement";
            this.Text = "Quản lý nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblEmpCode;
        private TextBox txbEmpCode;
        private TextBox txbEmpName;
        private Label lblSalary;
        private Label lblAllowance;
        private Button btnAdd;
        private Panel panel1;
        private RadioButton rdoIntern;
        private RadioButton rdoFulltime;
        private RadioButton rdoParttime;
        private Label lblEmpName;
        private TextBox txbAllowance;
        private TextBox txbSalary;
        private DataGridView dtgvEmpList;
        private DataGridViewTextBoxColumn EmpCode;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn TotalSalary;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn Allowance;
        private DataGridViewTextBoxColumn WorkingHours;
    }
}