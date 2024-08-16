namespace BE_07.WindowsForm
{
    partial class frmMain7
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
            this.btnExportByMonth = new System.Windows.Forms.Button();
            this.btnGeometryOptions = new System.Windows.Forms.Button();
            this.btnExportByWeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExportByMonth
            // 
            this.btnExportByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportByMonth.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportByMonth.ForeColor = System.Drawing.Color.Green;
            this.btnExportByMonth.Location = new System.Drawing.Point(139, 302);
            this.btnExportByMonth.Name = "btnExportByMonth";
            this.btnExportByMonth.Size = new System.Drawing.Size(523, 142);
            this.btnExportByMonth.TabIndex = 7;
            this.btnExportByMonth.Text = "Quản lý sản phẩm";
            this.btnExportByMonth.UseVisualStyleBackColor = true;
            // 
            // btnGeometryOptions
            // 
            this.btnGeometryOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeometryOptions.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeometryOptions.ForeColor = System.Drawing.Color.Green;
            this.btnGeometryOptions.Location = new System.Drawing.Point(139, 5);
            this.btnGeometryOptions.Name = "btnGeometryOptions";
            this.btnGeometryOptions.Size = new System.Drawing.Size(523, 143);
            this.btnGeometryOptions.TabIndex = 5;
            this.btnGeometryOptions.Text = "Quản lý hình học";
            this.btnGeometryOptions.UseVisualStyleBackColor = true;
            this.btnGeometryOptions.Click += new System.EventHandler(this.btnGeometryOptions_Click);
            // 
            // btnExportByWeek
            // 
            this.btnExportByWeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportByWeek.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportByWeek.ForeColor = System.Drawing.Color.Green;
            this.btnExportByWeek.Location = new System.Drawing.Point(139, 154);
            this.btnExportByWeek.Name = "btnExportByWeek";
            this.btnExportByWeek.Size = new System.Drawing.Size(523, 142);
            this.btnExportByWeek.TabIndex = 6;
            this.btnExportByWeek.Text = "Quản lý nhân viên";
            this.btnExportByWeek.UseVisualStyleBackColor = true;
            this.btnExportByWeek.Click += new System.EventHandler(this.btnExportByWeek_Click);
            // 
            // frmMain7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportByMonth);
            this.Controls.Add(this.btnGeometryOptions);
            this.Controls.Add(this.btnExportByWeek);
            this.Name = "frmMain7";
            this.Text = "frmMain7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportByMonth;
        private System.Windows.Forms.Button btnGeometryOptions;
        private System.Windows.Forms.Button btnExportByWeek;
    }
}