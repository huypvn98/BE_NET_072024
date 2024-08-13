using BE072024.Common_NetFrameWork;
using BE072024.DataAccess_NetFrameWork.Business;
using BE072024.DataAccess_NetFrameWork.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BE_07.WindowsForm
{
    public partial class frmGeometryManagement : Form
    {
        int distance = 0;
        GeometryBusiness geometryBusiness = new GeometryBusiness();
        public frmGeometryManagement()
        {
            InitializeComponent();
            distance = txbWidth.Height + 7;
        }

        private void rdoRectangle_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txbLongitude.Clear();
                txbWidth.Clear();
                rtbResult.Clear();
                if (rdoRectangle.Checked)
                {
                    lblWidth.Visible = true;
                    txbWidth.Visible = true;
                    lblLongitude.Text = "Chiều dài";
                    lblWidth.Text = "Chiều rộng";
                    btnCalculateArea.Location = new Point(btnCalculateArea.Location.X, txbWidth.Location.Y + distance);
                    btnPerimeter.Location = new Point(btnPerimeter.Location.X, btnCalculateArea.Location.Y);
                    pnlHeader.Height = btnPerimeter.Location.Y + btnPerimeter.Height + 7;

                    return;
                }
                lblLongitude.Text = "Bán kính";
                lblWidth.Visible = false;
                txbWidth.Visible = false;
                btnPerimeter.Location = new Point(btnPerimeter.Location.X, txbLongitude.Location.Y + distance);
                btnCalculateArea.Location = new Point(btnCalculateArea.Location.X, btnPerimeter.Location.Y);
                pnlHeader.Height = btnPerimeter.Location.Y + btnPerimeter.Height + 7;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            try
            {
                double length = 0;
                double width = 0;
                string errorMsg = string.Empty;
                //Kiểm tra dữ liệu đầu vào
                if (!geometryBusiness.CheckValidInput(txbLongitude.Text, txbLongitude.Name, out errorMsg, out length))
                {
                    MessageBox.Show(errorMsg);
                    txbLongitude.Focus();
                }
                if (rdoRectangle.Checked)
                {
                    //Kiểm tra dữ liệu đầu vào chiều rộng của hình chữ nhật
                    if (!geometryBusiness.CheckValidInput(txbWidth.Text, txbLongitude.Name, out errorMsg, out width))
                    {
                        MessageBox.Show(errorMsg);
                        txbWidth.Focus();
                    }
                    rtbResult.Text = new HinhChuNhat(length, width).TinhChuVi().ToString();
                    return;
                }
                rtbResult.Text = new HinhTron(length).TinhChuVi().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            try
            {
                double length = 0;
                double width = 0;
                string errorMsg = string.Empty;
                //Kiểm tra dữ liệu đầu vào
                if (!geometryBusiness.CheckValidInput(txbLongitude.Text, txbLongitude.Name, out errorMsg, out length))
                {
                    MessageBox.Show(errorMsg);
                    txbLongitude.Focus();
                }
                if (rdoRectangle.Checked)
                {
                    //Kiểm tra dữ liệu đầu vào chiều rộng của hình chữ nhật
                    if (!geometryBusiness.CheckValidInput(txbWidth.Text, txbLongitude.Name, out errorMsg, out width))
                    {
                        MessageBox.Show(errorMsg);
                        txbWidth.Focus();
                    }
                    rtbResult.Text = new HinhChuNhat(length, width).TinhDienTich().ToString();
                    return;
                }
                rtbResult.Text = new HinhTron(length).TinhDienTich().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
