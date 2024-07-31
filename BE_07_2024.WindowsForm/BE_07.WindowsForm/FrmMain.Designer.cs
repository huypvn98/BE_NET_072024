namespace AutoChangeOrderOracle
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnAddEmp = new Button();
            btnImportEmp = new Button();
            btnShowEmpLst = new Button();
            btnExportEmp5 = new Button();
            btnExportEmp10 = new Button();
            SuspendLayout();
            // 
            // btnAddEmp
            // 
            btnAddEmp.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmp.ForeColor = Color.Green;
            btnAddEmp.Location = new Point(95, 45);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(416, 61);
            btnAddEmp.TabIndex = 0;
            btnAddEmp.Text = "Thêm nhân viên";
            btnAddEmp.UseVisualStyleBackColor = true;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnImportEmp
            // 
            btnImportEmp.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportEmp.ForeColor = Color.Green;
            btnImportEmp.Location = new Point(95, 112);
            btnImportEmp.Name = "btnImportEmp";
            btnImportEmp.Size = new Size(416, 61);
            btnImportEmp.TabIndex = 1;
            btnImportEmp.Text = "Thêm nhân viên bằng imprort excel";
            btnImportEmp.UseVisualStyleBackColor = true;
            btnImportEmp.Click += btnImportEmp_Click;
            // 
            // btnShowEmpLst
            // 
            btnShowEmpLst.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowEmpLst.ForeColor = Color.Green;
            btnShowEmpLst.Location = new Point(95, 179);
            btnShowEmpLst.Name = "btnShowEmpLst";
            btnShowEmpLst.Size = new Size(416, 61);
            btnShowEmpLst.TabIndex = 2;
            btnShowEmpLst.Text = "Hiển thị danh sách nhân viên";
            btnShowEmpLst.UseVisualStyleBackColor = true;
            btnShowEmpLst.Click += btnShowEmpLst_Click;
            // 
            // btnExportEmp5
            // 
            btnExportEmp5.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportEmp5.ForeColor = Color.Green;
            btnExportEmp5.Location = new Point(95, 246);
            btnExportEmp5.Name = "btnExportEmp5";
            btnExportEmp5.Size = new Size(416, 61);
            btnExportEmp5.TabIndex = 3;
            btnExportEmp5.Text = "Xuất excel danh sách nhân viên đã cống hiến 5 năm";
            btnExportEmp5.UseVisualStyleBackColor = true;
            btnExportEmp5.Click += btnExportEmp5_Click;
            // 
            // btnExportEmp10
            // 
            btnExportEmp10.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportEmp10.ForeColor = Color.Green;
            btnExportEmp10.Location = new Point(95, 313);
            btnExportEmp10.Name = "btnExportEmp10";
            btnExportEmp10.Size = new Size(416, 61);
            btnExportEmp10.TabIndex = 4;
            btnExportEmp10.Text = "Xuất excel danh sách nhân viên đã cống hiến 10 năm";
            btnExportEmp10.UseVisualStyleBackColor = true;
            btnExportEmp10.Click += btnExportEmp10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 408);
            Controls.Add(btnExportEmp10);
            Controls.Add(btnExportEmp5);
            Controls.Add(btnShowEmpLst);
            Controls.Add(btnImportEmp);
            Controls.Add(btnAddEmp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Quản lý nhân sự";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddEmp;
        private Button btnImportEmp;
        private Button btnShowEmpLst;
        private Button btnExportEmp5;
        private Button btnExportEmp10;
    }
}
