using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM
{
    public partial class Form_ThiTN : Form
    {
        public Form_ThiTN()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String id = listView1.SelectedItems[0].SubItems[0].Text;
            txtb_id.Text = id;
            String cauhoi = listView1.SelectedItems[0].SubItems[1].Text;
            txt_cauhoi.Text = cauhoi;
            String a = listView1.SelectedItems[0].SubItems[2].Text;
            txt_a.Text = a;
            String b = listView1.SelectedItems[0].SubItems[3].Text;
            txt_b.Text = b;
            String c = listView1.SelectedItems[0].SubItems[4].Text;
            txt_c.Text = c;
            String d = listView1.SelectedItems[0].SubItems[5].Text;
            txt_d.Text = d;         
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (Program.KetNoi() == 0)
                return;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            String mamh = cmb_mamh.Text;
            SqlCommand cmd = new SqlCommand("SP_LIET_KE_DE_THI2", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAMH", mamh));
            cmd.Parameters.Add(new SqlParameter("@SOCAUTHI", 20));
            cmd.Parameters.Add(new SqlParameter("@TRINHDO", "DH"));
            try
            {
                SqlDataReader myreader = cmd.ExecuteReader();
                int i = 0;
                while (myreader.Read())
                {
                    listView1.Items.Add(myreader[0].ToString());
                    listView1.Items[i].SubItems.Add(myreader[1].ToString());
                    listView1.Items[i].SubItems.Add(myreader[2].ToString());
                    listView1.Items[i].SubItems.Add(myreader[3].ToString());
                    listView1.Items[i].SubItems.Add(myreader[4].ToString());
                    listView1.Items[i].SubItems.Add(myreader[5].ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xem đề thi\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void Form_ThiTN_Load(object sender, EventArgs e)
        {
            this.v_MONHOCTableAdapter.Fill(this.dS.V_MONHOC);
        }

        private void btn_nop_Click(object sender, EventArgs e)
        {
            if (txt_luachon.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án không k đc để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.KetNoi() == 0)
                return;
            String dapan = txt_luachon.Text;
            String mamh = cmb_mamh.Text;
            int id = Convert.ToInt32(txtb_id.Text);
            String masv = Program.username;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();

            SqlCommand cmd = new SqlCommand("SP_LichSuThi", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@mamh", mamh));
            cmd.Parameters.Add(new SqlParameter("@dapan", dapan));
            cmd.Parameters.Add(new SqlParameter("@masv", masv));

            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Nộp câu trả lời thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể nộp câu hỏi\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }

            Program.conn.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_luachon.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án không k đc để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.KetNoi() == 0)
                return;
            String dapan = txt_luachon.Text;
            String mamh = cmb_mamh.Text;
            int id = Convert.ToInt32(txtb_id.Text);
            String masv = Program.username;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();

            SqlCommand cmd = new SqlCommand("SP_SuaLichSuThi", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@mamh", mamh));
            cmd.Parameters.Add(new SqlParameter("@dapan", dapan));
            cmd.Parameters.Add(new SqlParameter("@masv", masv));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Sửa câu trả lời thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể sửa câu hỏi\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }

            Program.conn.Close();
        }
    }
}
