namespace AutoChangeOrderOracle
{
    partial class frmEmpLst
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
            listView1 = new ListView();
            colEmpCode = new ColumnHeader();
            colEmpName = new ColumnHeader();
            colStartDT = new ColumnHeader();
            colPosition = new ColumnHeader();
            colFactor = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { colEmpCode, colEmpName, colStartDT, colPosition, colFactor });
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(800, 450);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colEmpCode
            // 
            colEmpCode.Text = "Mã nhân viên";
            colEmpCode.Width = 150;
            // 
            // colEmpName
            // 
            colEmpName.Text = "Tên nhân viên";
            colEmpName.Width = 180;
            // 
            // colStartDT
            // 
            colStartDT.Text = "Ngày vào công ty";
            colStartDT.Width = 150;
            // 
            // colPosition
            // 
            colPosition.Text = "Vị trí công việc";
            colPosition.Width = 180;
            // 
            // colFactor
            // 
            colFactor.Text = "Hệ số lương";
            colFactor.Width = 150;
            // 
            // frmEmpLst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Name = "frmEmpLst";
            Text = "frmEmpLst";
            Load += frmEmpLst_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader colEmpCode;
        private ColumnHeader colEmpName;
        private ColumnHeader colStartDT;
        private ColumnHeader colPosition;
        private ColumnHeader colFactor;
    }
}