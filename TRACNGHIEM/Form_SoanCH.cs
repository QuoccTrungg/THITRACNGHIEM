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
    public partial class Form_SoanCH : Form
    {
        public Form_SoanCH()
        {
            InitializeComponent();
        }

        private void cmb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Trim() == "" || txt_chuong.Text.Trim() == ""
               || txt_trinhdo.Text.Trim() == "" || txt_cauhoi.Text.Trim() == "")
            {
                MessageBox.Show("Các trường thông tin k đc để trống!", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.KetNoi() == 0)
                return;
            String id =Program.id= txt_id.Text;
            String mamh = cmb_mamh.Text;   
            String trinhdo = txt_trinhdo.Text;
            String chuong = txt_chuong.Text;
            String cauhoi = txt_cauhoi.Text;
            String loai = cmb_loai.Text;
            String magv = Program.username;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            
            SqlCommand cmd = new SqlCommand("SP_ThemCauHoi", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id)); 
            cmd.Parameters.Add(new SqlParameter("@noidung",cauhoi));
            cmd.Parameters.Add(new SqlParameter("@chuong", chuong));
            cmd.Parameters.Add(new SqlParameter("@trinhdo",trinhdo));
            cmd.Parameters.Add(new SqlParameter("@loai", loai));
            cmd.Parameters.Add(new SqlParameter("@magv", magv));
            cmd.Parameters.Add(new SqlParameter("@mamh", mamh));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Thêm CH thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                if (loai == "LC")
                {
                    Form_luachon f = new Form_luachon();
                    f.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm CH\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            
            Program.conn.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_SoanCH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_MONHOC' table. You can move, or remove it, as needed.
            this.v_MONHOCTableAdapter.Fill(this.dS.V_MONHOC);
            cmb_loai.Items.Add("LC");
            cmb_loai.Items.Add("YN");
            cmb_loai.Items.Add("DK");
        }
    }
}
