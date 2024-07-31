namespace AutoChangeOrderOracle
{
    partial class frmAddEmp
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
            lbl_EMP_CODE = new Label();
            txb_EMP_CODE = new TextBox();
            txb_EMP_NAME = new TextBox();
            lbl_EMP_NAME = new Label();
            lbl_START_DT = new Label();
            lbl_FACTOR = new Label();
            START_DT = new DateTimePicker();
            lbl_POSITION = new Label();
            cbx_POSITION = new ComboBox();
            cbx_FACTOR = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lbl_EMP_CODE
            // 
            lbl_EMP_CODE.AutoSize = true;
            lbl_EMP_CODE.Location = new Point(8, 14);
            lbl_EMP_CODE.Name = "lbl_EMP_CODE";
            lbl_EMP_CODE.Size = new Size(79, 15);
            lbl_EMP_CODE.TabIndex = 0;
            lbl_EMP_CODE.Text = "Mã nhân viên";
            // 
            // txb_EMP_CODE
            // 
            txb_EMP_CODE.Location = new Point(113, 5);
            txb_EMP_CODE.Name = "txb_EMP_CODE";
            txb_EMP_CODE.Size = new Size(200, 23);
            txb_EMP_CODE.TabIndex = 1;
            // 
            // txb_EMP_NAME
            // 
            txb_EMP_NAME.Location = new Point(113, 32);
            txb_EMP_NAME.Name = "txb_EMP_NAME";
            txb_EMP_NAME.Size = new Size(200, 23);
            txb_EMP_NAME.TabIndex = 3;
            // 
            // lbl_EMP_NAME
            // 
            lbl_EMP_NAME.AutoSize = true;
            lbl_EMP_NAME.Location = new Point(8, 41);
            lbl_EMP_NAME.Name = "lbl_EMP_NAME";
            lbl_EMP_NAME.Size = new Size(80, 15);
            lbl_EMP_NAME.TabIndex = 2;
            lbl_EMP_NAME.Text = "Tên nhân viên";
            // 
            // lbl_START_DT
            // 
            lbl_START_DT.AutoSize = true;
            lbl_START_DT.Location = new Point(8, 70);
            lbl_START_DT.Name = "lbl_START_DT";
            lbl_START_DT.Size = new Size(100, 15);
            lbl_START_DT.TabIndex = 4;
            lbl_START_DT.Text = "Ngày vào công ty";
            // 
            // lbl_FACTOR
            // 
            lbl_FACTOR.AutoSize = true;
            lbl_FACTOR.Location = new Point(8, 127);
            lbl_FACTOR.Name = "lbl_FACTOR";
            lbl_FACTOR.Size = new Size(71, 15);
            lbl_FACTOR.TabIndex = 6;
            lbl_FACTOR.Text = "Hệ số lương";
            // 
            // START_DT
            // 
            START_DT.Location = new Point(113, 61);
            START_DT.Name = "START_DT";
            START_DT.Size = new Size(200, 23);
            START_DT.TabIndex = 8;
            // 
            // lbl_POSITION
            // 
            lbl_POSITION.AutoSize = true;
            lbl_POSITION.Location = new Point(8, 98);
            lbl_POSITION.Name = "lbl_POSITION";
            lbl_POSITION.Size = new Size(85, 15);
            lbl_POSITION.TabIndex = 9;
            lbl_POSITION.Text = "Vị trí công việc";
            // 
            // cbx_POSITION
            // 
            cbx_POSITION.FormattingEnabled = true;
            cbx_POSITION.Items.AddRange(new object[] { "Nhân viên", "Phó phòng", "Trưởng phòng", "Quản lý", "Giám đốc" });
            cbx_POSITION.Location = new Point(113, 90);
            cbx_POSITION.Name = "cbx_POSITION";
            cbx_POSITION.Size = new Size(200, 23);
            cbx_POSITION.TabIndex = 11;
            cbx_POSITION.SelectedValueChanged += cbx_POSITION_SelectedValueChanged;
            // 
            // cbx_FACTOR
            // 
            cbx_FACTOR.FormattingEnabled = true;
            cbx_FACTOR.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "4" });
            cbx_FACTOR.Location = new Point(113, 119);
            cbx_FACTOR.Name = "cbx_FACTOR";
            cbx_FACTOR.Size = new Size(200, 23);
            cbx_FACTOR.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(238, 149);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 178);
            Controls.Add(btnSave);
            Controls.Add(cbx_FACTOR);
            Controls.Add(cbx_POSITION);
            Controls.Add(lbl_POSITION);
            Controls.Add(START_DT);
            Controls.Add(lbl_FACTOR);
            Controls.Add(lbl_START_DT);
            Controls.Add(txb_EMP_NAME);
            Controls.Add(lbl_EMP_NAME);
            Controls.Add(txb_EMP_CODE);
            Controls.Add(lbl_EMP_CODE);
            Name = "frmAddEmp";
            Text = "Thêm nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_EMP_CODE;
        private TextBox txb_EMP_CODE;
        private TextBox txb_EMP_NAME;
        private Label lbl_EMP_NAME;
        private Label lbl_START_DT;
        private Label lbl_FACTOR;
        private DateTimePicker START_DT;
        private Label lbl_POSITION;
        private ComboBox cbx_POSITION;
        private ComboBox cbx_FACTOR;
        private Button btnSave;
    }
}