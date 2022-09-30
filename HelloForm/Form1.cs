using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Để đóng vùng code lại: chọn đoạn code -> chuột phải -> sniper -> suround with -> region

namespace HelloForm
{
    public partial class form1 : Form
    {
        ErrorProvider error;

        public form1()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }


        private void btncong_Click(object sender, EventArgs e)
        {
            try
            {
                #region Lấy dữ liệu 
                var _soThuNhat = txtsothunhat.Text;
                var _soThuHai = txtsothuhai.Text;

                error.Clear(); //Để tiến hành kiểm tra lại từ đầu

                #endregion
                #region Kiểm tra dữ liệu hợp lệ
                if (String.IsNullOrEmpty(_soThuNhat))
                {
                    error.SetError(txtsothunhat, "Vui lòng nhật dữ số thứ nhất");
                    return;
                }

                if (String.IsNullOrEmpty(_soThuHai))
                {
                    error.SetError(txtsothuhai, "Vui lòng nhật dữ số thứ hai");
                    return;
                }
                #endregion

                #region Xử lý dữ liệu
                double soThuNhat = Convert.ToDouble(_soThuNhat);
                double soThuHai = Convert.ToDouble(_soThuHai);


                var ketQua = soThuNhat + soThuHai;
                if (rdblabel.Checked)
                {
                    lblketqua.Text = ketQua.ToString("N2");
                }
                else
                {
                    MessageBox.Show($"Kết quả: {ketQua:N2}");
                }
                #endregion
            }
            #region Exception
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập không đúng. Vui lòng nhập lại!");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập quá lớn. Vui lòng nhập dữ liệu nhỏ hơn!");
            }
            catch (Exception ex)    //Nếu dúng Exception thì bất kỳ lỗi gì cũng có thể bắt được
            {
                MessageBox.Show("Lỗi chương trình. Xem chi tiết " + ex.Message);
            }
            #endregion

        }
        private void btntru_Click(object sender, EventArgs e)
        {
            try
            {
                #region Lấy dữ liệu 
                var _soThuNhat = txtsothunhat.Text;
                var _soThuHai = txtsothuhai.Text;

                error.Clear(); //Để tiến hành kiểm tra lại từ đầu

                #endregion
                #region Kiểm tra dữ liệu hợp lệ
                if (String.IsNullOrEmpty(_soThuNhat))
                {
                    error.SetError(txtsothunhat, "Vui lòng nhật dữ số thứ nhất");
                    return;
                }

                if (String.IsNullOrEmpty(_soThuHai))
                {
                    error.SetError(txtsothuhai, "Vui lòng nhật dữ số thứ hai");
                    return;
                }
                #endregion

                #region Xử lý dữ liệu
                double soThuNhat = Convert.ToDouble(_soThuNhat);
                double soThuHai = Convert.ToDouble(_soThuHai);


                var ketQua = soThuNhat - soThuHai;
                if (rdblabel.Checked)
                {
                    lblketqua.Text = ketQua.ToString("N2");
                }
                else
                {
                    MessageBox.Show($"Kết quả: {ketQua:N2}");
                }
                #endregion
            }
            #region Exception
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập không đúng. Vui lòng nhập lại!");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập quá lớn. Vui lòng nhập dữ liệu nhỏ hơn!");
            }
            catch (Exception ex)    //Nếu dúng Exception thì bất kỳ lỗi gì cũng có thể bắt được
            {
                MessageBox.Show("Lỗi chương trình. Xem chi tiết " + ex.Message);
            }
            #endregion
        }
        private void btnnhan_Click(object sender, EventArgs e)
        {
            try
            {
                #region Lấy dữ liệu 
                var _soThuNhat = txtsothunhat.Text;
                var _soThuHai = txtsothuhai.Text;

                error.Clear(); //Để tiến hành kiểm tra lại từ đầu

                #endregion
                #region Kiểm tra dữ liệu hợp lệ
                if (String.IsNullOrEmpty(_soThuNhat))
                {
                    error.SetError(txtsothunhat, "Vui lòng nhật dữ số thứ nhất");
                    return;
                }

                if (String.IsNullOrEmpty(_soThuHai))
                {
                    error.SetError(txtsothuhai, "Vui lòng nhật dữ số thứ hai");
                    return;
                }
                #endregion

                #region Xử lý dữ liệu
                double soThuNhat = Convert.ToDouble(_soThuNhat);
                double soThuHai = Convert.ToDouble(_soThuHai);


                var ketQua = soThuNhat * soThuHai;
                if (rdblabel.Checked)
                {
                    lblketqua.Text = ketQua.ToString("N2");
                }
                else
                {
                    MessageBox.Show($"Kết quả: {ketQua:N2}");
                }
                #endregion
            }
            #region Exception
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập không đúng. Vui lòng nhập lại!");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập quá lớn. Vui lòng nhập dữ liệu nhỏ hơn!");
            }
            catch (Exception ex)    //Nếu dúng Exception thì bất kỳ lỗi gì cũng có thể bắt được
            {
                MessageBox.Show("Lỗi chương trình. Xem chi tiết " + ex.Message);
            }
            #endregion
        }
        private void btnchia_Click(object sender, EventArgs e)
        {
            try
            {
                #region Lấy dữ liệu 
                var _soThuNhat = txtsothunhat.Text;
                var _soThuHai = txtsothuhai.Text;

                error.Clear(); //Để tiến hành kiểm tra lại từ đầu

                #endregion
                #region Kiểm tra dữ liệu hợp lệ
                if (String.IsNullOrEmpty(_soThuNhat))
                {
                    error.SetError(txtsothunhat, "Vui lòng nhật dữ số thứ nhất");
                    return;
                }

                if (String.IsNullOrEmpty(_soThuHai))
                {
                    error.SetError(txtsothuhai, "Vui lòng nhật dữ số thứ hai");
                    return;
                }
                #endregion

                #region Xử lý dữ liệu
                double soThuNhat = Convert.ToDouble(_soThuNhat);
                double soThuHai = Convert.ToDouble(_soThuHai);
                double ketQua;

                if (soThuHai != 0)
                {
                    ketQua = soThuNhat / soThuHai;
                    if (rdblabel.Checked)
                    {
                        lblketqua.Text = ketQua.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show($"Kết quả: {ketQua:N2}");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể chia cho 0");
                }
                #endregion

            }
            #region Exception
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập không đúng. Vui lòng nhập lại!");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập quá lớn. Vui lòng nhập dữ liệu nhỏ hơn!");
            }
            catch (Exception ex)    //Nếu dúng Exception thì bất kỳ lỗi gì cũng có thể bắt được
            {
                MessageBox.Show("Lỗi chương trình. Xem chi tiết " + ex.Message);
            }
            #endregion
        }

        private void llkchonmau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var color = dialog.Color;
                this.BackColor = color;
            }
        }

        private void llkchonhinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var imagePath = openFileDialog.FileName;
                this.BackgroundImage = new Bitmap(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackColor = Color.White;
            }

        }

        private void llkchonmau_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var color = dialog.Color;
                this.BackColor = color;
            }
        }
    }
}