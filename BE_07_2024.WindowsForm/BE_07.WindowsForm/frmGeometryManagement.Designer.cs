namespace BE_07.WindowsForm
{
    partial class frmGeometryManagement
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
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.txbLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Checked = true;
            this.rdoRectangle.Location = new System.Drawing.Point(64, 8);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(92, 17);
            this.rdoRectangle.TabIndex = 0;
            this.rdoRectangle.TabStop = true;
            this.rdoRectangle.Text = "Hình chữ nhật";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            this.rdoRectangle.CheckedChanged += new System.EventHandler(this.rdoRectangle_CheckedChanged);
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(162, 8);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(68, 17);
            this.rdoCircle.TabIndex = 1;
            this.rdoCircle.Text = "Hình tròn";
            this.rdoCircle.UseVisualStyleBackColor = true;
            // 
            // txbLongitude
            // 
            this.txbLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLongitude.Location = new System.Drawing.Point(64, 35);
            this.txbLongitude.Name = "txbLongitude";
            this.txbLongitude.Size = new System.Drawing.Size(197, 20);
            this.txbLongitude.TabIndex = 2;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(5, 42);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(51, 13);
            this.lblLongitude.TabIndex = 3;
            this.lblLongitude.Text = "Chiều dài";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnCalculateArea);
            this.pnlHeader.Controls.Add(this.btnPerimeter);
            this.pnlHeader.Controls.Add(this.lblWidth);
            this.pnlHeader.Controls.Add(this.txbWidth);
            this.pnlHeader.Controls.Add(this.rdoRectangle);
            this.pnlHeader.Controls.Add(this.lblLongitude);
            this.pnlHeader.Controls.Add(this.rdoCircle);
            this.pnlHeader.Controls.Add(this.txbLongitude);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(264, 116);
            this.pnlHeader.TabIndex = 4;
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculateArea.Location = new System.Drawing.Point(177, 88);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(84, 22);
            this.btnCalculateArea.TabIndex = 7;
            this.btnCalculateArea.Text = "Tính diện tích";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.btnCalculateArea_Click);
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerimeter.Location = new System.Drawing.Point(96, 88);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(75, 22);
            this.btnPerimeter.TabIndex = 6;
            this.btnPerimeter.Text = "Tính chu vi";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(5, 69);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(58, 13);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Chiều rộng";
            // 
            // txbWidth
            // 
            this.txbWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbWidth.Location = new System.Drawing.Point(64, 62);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(197, 20);
            this.txbWidth.TabIndex = 4;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.rtbResult);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResult.Location = new System.Drawing.Point(0, 116);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(264, 123);
            this.pnlResult.TabIndex = 5;
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.Location = new System.Drawing.Point(0, 0);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(264, 124);
            this.rtbResult.TabIndex = 0;
            this.rtbResult.Text = "";
            // 
            // frmGeometryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 239);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmGeometryManagement";
            this.Text = "Quản lý hình học";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.TextBox txbLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}