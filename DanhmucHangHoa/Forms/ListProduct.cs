using AppQuanLyTro2.Data_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuHanh4.Model;


namespace ThuHanh4.Forms
{

   
    public partial class ListProduct : Form
    {
        public DataProcesser dt = new DataProcesser();
        DataTable dtTable = new DataTable();
        DataTable dtTable2 = new DataTable();
        OpenFileDialog chonAnh=new OpenFileDialog();
        int chucnang = 0;
        public ListProduct()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {

            String query = "select MaHang, TenHang, TenChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh from [dbo].[tblHang] hh " +
                "           inner join [dbo].[tblChatLieu] cl on hh.ChatLieu = cl.MaChatLieu ";
            dtTable= dt.DocBang(query);
            String query2 = "select * from [dbo].[tblChatLieu]";
            dtTable2 = dt.DocBang(query2);
            GridViewHangHoa.DataSource = dtTable;
            GridViewHangHoa.Columns["Anh"].Visible = false;
            cmbChatLieu.Items.Clear();
            if (dtTable2.Rows.Count > 0)
            {
                foreach (DataRow dr in dtTable2.Rows) {
                    cmbChatLieu.Items.Add(dr["TenChatLieu"].ToString());
                }
            }
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGiaban.Text = "";
            cmbChatLieu.SelectedIndex = 0;
            picImage.Image = null;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = false;

            txtGiaban.ReadOnly = true;
            txtGiaNhap.ReadOnly = true;
            txtMaHang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtTenHang.ReadOnly = true;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
           
            chonAnh.Filter = "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp|TIFF Files (*.tiff)|*.tiff|All Files (*.*)|*.*";
            if(chonAnh.ShowDialog() == DialogResult.OK)
            {
                String anh= chonAnh.FileName; 


                picImage.Image=Image.FromFile(anh);
                picImage.SizeMode= PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Mở tệp thất bại");
            }
        }

        
        private void GridViewHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGiaban.ReadOnly = true;
            txtGiaNhap.ReadOnly = true;
            txtMaHang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = GridViewHangHoa.Rows[e.RowIndex];
                txtMaHang.Text = selectedRow.Cells["MaHang"].Value.ToString();
                txtTenHang.Text = selectedRow.Cells["TenHang"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                txtGiaNhap.Text = selectedRow.Cells["DonGiaNhap"].Value.ToString();
                txtGiaban.Text = selectedRow.Cells["DonGiaBan"].Value.ToString();
                cmbChatLieu.Text = selectedRow.Cells["TenChatLieu"].Value.ToString();

                string imagePath = selectedRow.Cells["Anh"].Value.ToString();
                // Dữ liệu chỉ có tên ảnh, không có đường dẫn đầy đủ
                // Gán đường dẫn đầy đủ cho imagePath với dữ liệu được lưu ở bin\Debug\Image
                // Cat chuoi imagePath de lay ten anh
                //imagePath = imagePath.Substring(imagePath.LastIndexOf('\\') + 1);
                imagePath = Application.StartupPath + @"\Image\" + imagePath;
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        picImage.Image = Image.FromFile(imagePath);
                        picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        chonAnh.FileName = imagePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở hình ảnh: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Đường dẫn hình ảnh không hợp lệ.");
                }
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            chucnang = 2;
            txtGiaban.ReadOnly = false;
            txtGiaNhap.ReadOnly = false;
            txtMaHang.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtTenHang.ReadOnly = false;
            picImage.Image = null;
            txtGiaban.Text = "";
            txtGiaNhap.Text = "";
            txtMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
            chonAnh.FileName = "";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Bạn có chắc chắn muốn thoát","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = 1;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtMaHang.ReadOnly = true;
            txtGiaban.ReadOnly = false;
            txtGiaNhap.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtTenHang.ReadOnly = false;
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            chucnang = 3;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtGiaban.Text = "";
            txtGiaNhap.Text = "";
            txtMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
            chonAnh.FileName = "";
            btnHuy.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucnang == 1)
            {
                String mahang = txtMaHang.Text;
                String tenhang = txtTenHang.Text;
                if (string.IsNullOrEmpty(mahang) || string.IsNullOrEmpty(tenhang))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                String chatLieu = cmbChatLieu.Text;
                String queryChatLieu = "select MaChatLieu from [dbo].[tblChatLieu] where TenChatLieu = N'" + chatLieu + "'";
                List<string> MaCL = dt.DocBang1(queryChatLieu);
                int MaChatLieu = int.Parse(MaCL[0]);
                
                int soLuong = int.Parse(txtSoLuong.Text);
                if (string.IsNullOrEmpty(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Số lượng phải là nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                float giaNhap = float.Parse(txtGiaNhap.Text);
                float giaBan = float.Parse(txtGiaban.Text);
                if (giaNhap >= giaBan)
                {
                    MessageBox.Show("Giá nhập phải nhỏ hơn giá bán");
                    return;

                }
                String anh = chonAnh.FileName;
                string[] arrListStr = anh.Split('\\');
                anh = arrListStr[arrListStr.Length - 1];


                String querySua = "UPDATE [dbo].[tblHang] " +
                    "SET [TenHang] = N'" + tenhang + "', " +
                    "[ChatLieu] = N'" + MaChatLieu + "', " +
                    "[SoLuong] = " + soLuong + ", " +
                    "[DonGiaNhap] = " + giaNhap + ", " +
                    "[DonGiaBan] = " + giaBan + ", " +
                    "[Anh] = N'" + anh + "' " +
                    "WHERE [MaHang] = '" + mahang + "'";

                dt.CapNhatDuLieu(querySua);
                MessageBox.Show("Sửa thành công");
                refresh();

            }
            else if(chucnang == 2)
            {
                String mahang = txtMaHang.Text;
                string tenhang = txtTenHang.Text;
                if (string.IsNullOrEmpty(mahang) || string.IsNullOrEmpty(tenhang))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                String chatLieu = cmbChatLieu.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                if (string.IsNullOrEmpty(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Số lượng phải là nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                float giaNhap = float.Parse(txtGiaNhap.Text);
                float giaBan = float.Parse(txtGiaban.Text);
                if (giaNhap >= giaBan)
                {
                    MessageBox.Show("Giá nhập phải nhỏ hơn giá bán");
                    return;

                }
                String anh = chonAnh.FileName;

                string[] arrListStr = anh.Split('\\');
                anh = arrListStr[arrListStr.Length - 1];

                // Chuyen anh vao thu muc Image
                string sourcePath = chonAnh.FileName;
                string targetPath = Application.StartupPath + @"\Image\" + anh;
                System.IO.File.Copy(sourcePath, targetPath, true);

                List<string> ha = dt.DocBang1("select MaChatLieu from [dbo].[tblChatLieu] where TenChatLieu = N'" + chatLieu + "'");
                int MaChatLieu = int.Parse(ha[0]);
                string insertSP = "insert into [dbo].[tblHang]" +
                                  "values(N'" + mahang + "',N'" + tenhang + "',N'" + MaChatLieu + "'," + soLuong + "," + giaNhap + "," + giaBan + ",'" + anh + "')";

                dtTable = dt.DocBang("select MaHang from tblHang where Mahang= N'" + mahang + "'");
                if (dtTable.Rows.Count > 0)
                {
                    MessageBox.Show("Mặt hàng này đã tồn tại");
                    return;
                }
                else
                {
                    dt.CapNhatDuLieu(insertSP);
                    MessageBox.Show("Thêm Thành Công");
                    refresh();
                }
            }
            else if (chucnang == 3)
            {
                if (!String.IsNullOrWhiteSpace(txtMaHang.Text))
                {
                    txtMaHang.ReadOnly = true;
                    String mahang = txtMaHang.Text;
                    string tenhang = txtTenHang.Text;
                    String queryXoa = "DELETE FROM [dbo].[tblHang] " +
                          "WHERE [MaHang] = N'" + mahang + "'";
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dt.CapNhatDuLieu(queryXoa);
                        MessageBox.Show("Xóa thành công sản phẩm ");
                        refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa ");

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
