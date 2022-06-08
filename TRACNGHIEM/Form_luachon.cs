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
    public partial class Form_luachon : Form
    {
        public Form_luachon()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0)
                return;
            String noidunga = txt_a.Text;
            String noidungb = txt_b.Text;
            String noidungc = txt_c.Text;
            String noidungd = txt_d.Text;

 
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();

            SqlCommand cmd = new SqlCommand("SP_ThemLuaChon", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", Program.id));
            cmd.Parameters.Add(new SqlParameter("@noidunga", noidunga));
            cmd.Parameters.Add(new SqlParameter("@noidungb", noidungb));
            cmd.Parameters.Add(new SqlParameter("@noidungc", noidungc));
            cmd.Parameters.Add(new SqlParameter("@noidungd", noidungd));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Thêm LC thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm CH\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }

            Program.conn.Close();
        }
    }
}
