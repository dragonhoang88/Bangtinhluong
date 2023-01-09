using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinh_Luong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Phần tính toán
        {
            double cangay100 = Convert.ToDouble(ht_cangay100.Text);
            
            double nghihuongluong80 = Convert.ToDouble(ht_nghihuongluong80.Text);
            double nghikhongluong = Convert.ToDouble(ht_nghikhongluong.Text);
            double tongngaycong = Convert.ToDouble(ht_tongngaycong.Text);
            double tangcabanngay150 = Convert.ToDouble(ht_tangcabanngay150.Text);
            double tangcabandem210 = Convert.ToDouble(ht_tangcadem210.Text);
            double tangcaCN200 = Convert.ToDouble(ht_tangcacn200.Text);
            double luongcoban = Convert.ToDouble(ht_luongcoban.Text);
            //double luongngaycong = Convert.ToDouble(ht_luongngaycong.Text);
            //double luongtangcangay150 = Convert.ToDouble(ht_luongcangay150.Text);
            //double luongtangcadem210 = Convert.ToDouble(ht_luongcadem210.Text);
            //double luongtangcaCN200 = Convert.ToDouble(ht_luongtangcaCN200.Text);
            //double tongluong = Convert.ToDouble(ht_tongluong.Text);
            double chuyencan = Convert.ToDouble(ht_chuyencan.Text);
            double xangxe = Convert.ToDouble(ht_xangxe.Text);
            double nhaO = Convert.ToDouble(ht_nhao.Text);
            double thamlien = Convert.ToDouble(ht_thamlien.Text);
            double trachnhiem = Convert.ToDouble(ht_trachnhiem.Text);
            double bucom = Convert.ToDouble(ht_butiencom.Text);
            //double tongtrocap = Convert.ToDouble(ht_tonghotro.Text);

            double tongluongdongbhxh = thamlien + trachnhiem + luongcoban;
            double tricdongbaohiem = tongluongdongbhxh * 0.105;
           
            double doanphi = Convert.ToDouble(ht_doanphi.Text);
            //double thuclinh = Convert.ToDouble(ht_thuclinh.Text);
            
            double tongluongtinhtangca = luongcoban + chuyencan + trachnhiem + thamlien;
            double tientrungaynghi80 = luongcoban / 26 * 0.2 * nghihuongluong80;
            double tiennghikhongluong = tongluongtinhtangca / 26 * nghikhongluong;
            double tienluongngaycong27 = tongluongtinhtangca / 26 * (tongngaycong - 26);
            double luongngaycong = luongcoban - tientrungaynghi80 - tiennghikhongluong + tienluongngaycong27;
            double luongtangcangay150 = tongluongtinhtangca / 26 / 8 * 1.5 * tangcabanngay150;
            double luongtangcadem210 = tongluongtinhtangca / 26 / 8 * 2.1 * tangcabandem210;
            double luongtangcaCN200 = tongluongtinhtangca / 26 / 8 * 2 * tangcaCN200;
            double tongluong = luongngaycong + luongtangcangay150 + luongtangcadem210 + luongtangcaCN200;
            double tonghotro = chuyencan + xangxe + nhaO + trachnhiem + thamlien;
            double cangay = tongngaycong - nghihuongluong80 - nghikhongluong;

            ht_cangay100.Text = cangay.ToString();

            int intluongngaycong = (int) luongngaycong;
            int inttangcabanngay150 = (int)luongtangcangay150;
            int inttongluong = (int)tongluong;
            int intluongtangcadem210 = (int)luongtangcadem210;
            int intluongtangcaCN200 = (int)luongtangcaCN200;
            int inttricdongbhxh = (int)tricdongbaohiem;

            ht_tonghotro.Text = tonghotro.ToString();
            ht_tongluongdongBHXH.Text = tongluongdongbhxh.ToString();
            ht_luongngaycong.Text = intluongngaycong.ToString();
            ht_luongcangay150.Text = inttangcabanngay150.ToString();
            ht_luongcadem210.Text = luongtangcadem210.ToString();
            ht_luongtangcaCN200.Text = luongtangcaCN200.ToString();
            ht_tongluong.Text = inttongluong.ToString();
            ht_tonghotro.Text = (nhaO + xangxe + thamlien + trachnhiem + chuyencan).ToString();
            ht_tongluongtinhtangca.Text = tongluongtinhtangca.ToString();
            ht_trichdongBH.Text = tricdongbaohiem.ToString();

            
            double thuclinh = tongluong + tonghotro - tricdongbaohiem - doanphi;
            int intthuclinh = (int) thuclinh;

            ht_thuclinh.Text = intthuclinh.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ht_cangay100_TextChanged(object sender, EventArgs e)
        {

        }

        private void ht_cangay100_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ht_nghihuongluong80_KeyDown(object sender, KeyEventArgs e) // sự kiện tính nghỉ hưởng lương 80%
        {
            if (e.KeyCode == Keys.Up)
            {
                ht_butiencom.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_nghikhongluong.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_nghikhongluong.Focus();
            }
        }

        private void ht_nghihuongluong100_KeyDown(object sender, KeyEventArgs e) // sự kiện tính nghỉ hưởng lương 100%
        {
            if (e.KeyCode == Keys.Up)
            {
                ht_nghihuongluong80.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_tongngaycong.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_tongngaycong.Focus();
            }
        }

        private void ht_tongngaycong_KeyDown(object sender, KeyEventArgs e)  // sự kiện tính ngày công
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_nghikhongluong.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_tangcabanngay150.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_tangcabanngay150.Focus();
            }
        }

        private void ht_tangcabanngay150_KeyDown(object sender, KeyEventArgs e) // sự kiện tính tăng ca ban ngày 150%
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_tongngaycong.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_tangcacn200.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_tangcacn200.Focus();
            }
        }

        private void ht_tangcacn200_KeyDown(object sender, KeyEventArgs e) // sự kiện tính tăng ca chủ nhật ngày nghỉ 200%
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_tangcabanngay150.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_tangcadem210.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_tangcadem210.Focus();
            }
        }

        private void ht_tangcadem210_KeyDown(object sender, KeyEventArgs e) // sự kiện tính tăng ca đêm 210%
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_tangcacn200.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_luongcoban.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_luongcoban.Focus();
            }
        }

        private void ht_luongcoban_KeyDown(object sender, KeyEventArgs e)   // sự kiện tính lương cơ bản
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_tangcadem210.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_chuyencan.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_chuyencan.Focus();
            }
        }

        private void ht_xangxe_KeyDown(object sender, KeyEventArgs e)  // sự kiện tính Xằng xe
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_chuyencan.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_nhao.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_nhao.Focus();
            }
        }

        private void ht_nhao_KeyDown(object sender, KeyEventArgs e) // sự kiện tính nhà ở
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_xangxe.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_thamlien.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_thamlien.Focus();
            }
        }

        private void ht_thamlien_KeyDown(object sender, KeyEventArgs e) // sự kiện tính thâm niên
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_nhao.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_trachnhiem.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_trachnhiem.Focus();
            }
        }

        private void ht_trachnhiem_KeyDown(object sender, KeyEventArgs e) // sự kiện tính trách nhiệm
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_thamlien.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_butiencom.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_butiencom.Focus();
            }
        }

        private void ht_butiencom_KeyDown(object sender, KeyEventArgs e) // sự kiện tính bù tiền cơm
        {

            if (e.KeyCode == Keys.Up)
            {
                ht_trachnhiem.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                button1.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void ht_chuyencan_KeyDown(object sender, KeyEventArgs e) // sự kiện tính chuyên cần
        {
            if (e.KeyCode == Keys.Up)
            {
                ht_luongcoban.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                ht_xangxe.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ht_xangxe.Focus();
            }
        }

        private void ht_nghihuongluong80_KeyPress(object sender, KeyPressEventArgs e) // sự kiện tính nghỉ hưởng lương 80%
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }
    }
}
