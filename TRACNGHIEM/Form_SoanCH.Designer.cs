
namespace TRACNGHIEM
{
    partial class Form_SoanCH
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_chuong = new System.Windows.Forms.TextBox();
            this.txt_trinhdo = new System.Windows.Forms.TextBox();
            this.txt_cauhoi = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cmb_loai = new System.Windows.Forms.ComboBox();
            this.cmb_mamh = new System.Windows.Forms.ComboBox();
            this.vMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM.DS();
            this.khanangdayTableAdapter1 = new TRACNGHIEM.DSTableAdapters.KHANANGDAYTableAdapter();
            this.v_MONHOCTableAdapter = new TRACNGHIEM.DSTableAdapters.V_MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã MH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(39, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chương";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(39, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trình độ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(39, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(39, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nội dung CH";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(179, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(208, 22);
            this.txt_id.TabIndex = 6;
            // 
            // txt_chuong
            // 
            this.txt_chuong.Location = new System.Drawing.Point(179, 190);
            this.txt_chuong.Name = "txt_chuong";
            this.txt_chuong.Size = new System.Drawing.Size(208, 22);
            this.txt_chuong.TabIndex = 8;
            // 
            // txt_trinhdo
            // 
            this.txt_trinhdo.Location = new System.Drawing.Point(179, 260);
            this.txt_trinhdo.Name = "txt_trinhdo";
            this.txt_trinhdo.Size = new System.Drawing.Size(208, 22);
            this.txt_trinhdo.TabIndex = 9;
            // 
            // txt_cauhoi
            // 
            this.txt_cauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txt_cauhoi.Location = new System.Drawing.Point(179, 388);
            this.txt_cauhoi.MinimumSize = new System.Drawing.Size(4, 50);
            this.txt_cauhoi.Multiline = true;
            this.txt_cauhoi.Name = "txt_cauhoi";
            this.txt_cauhoi.Size = new System.Drawing.Size(658, 201);
            this.txt_cauhoi.TabIndex = 10;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(496, 618);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(118, 38);
            this.btn_huy.TabIndex = 11;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(719, 618);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(118, 38);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cmb_loai
            // 
            this.cmb_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_loai.FormattingEnabled = true;
            this.cmb_loai.Location = new System.Drawing.Point(179, 326);
            this.cmb_loai.Name = "cmb_loai";
            this.cmb_loai.Size = new System.Drawing.Size(208, 24);
            this.cmb_loai.TabIndex = 13;
            this.cmb_loai.SelectedIndexChanged += new System.EventHandler(this.cmb_loai_SelectedIndexChanged);
            // 
            // cmb_mamh
            // 
            this.cmb_mamh.DataSource = this.vMONHOCBindingSource;
            this.cmb_mamh.DisplayMember = "MAMH";
            this.cmb_mamh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mamh.FormattingEnabled = true;
            this.cmb_mamh.Location = new System.Drawing.Point(179, 113);
            this.cmb_mamh.Name = "cmb_mamh";
            this.cmb_mamh.Size = new System.Drawing.Size(208, 24);
            this.cmb_mamh.TabIndex = 14;
            this.cmb_mamh.ValueMember = "MAMH";
            // 
            // vMONHOCBindingSource
            // 
            this.vMONHOCBindingSource.DataMember = "V_MONHOC";
            this.vMONHOCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khanangdayTableAdapter1
            // 
            this.khanangdayTableAdapter1.ClearBeforeFill = true;
            // 
            // v_MONHOCTableAdapter
            // 
            this.v_MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // Form_SoanCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 668);
            this.Controls.Add(this.cmb_mamh);
            this.Controls.Add(this.cmb_loai);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.txt_cauhoi);
            this.Controls.Add(this.txt_trinhdo);
            this.Controls.Add(this.txt_chuong);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_SoanCH";
            this.Text = "Form_SoanCH";
            this.Load += new System.EventHandler(this.Form_SoanCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DSTableAdapters.KHANANGDAYTableAdapter khanangdayTableAdapter1;
        private System.Windows.Forms.TextBox txt_chuong;
        private System.Windows.Forms.TextBox txt_trinhdo;
        private System.Windows.Forms.TextBox txt_cauhoi;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cmb_loai;
        private System.Windows.Forms.ComboBox cmb_mamh;
        private DS dS;
        private System.Windows.Forms.BindingSource vMONHOCBindingSource;
        private DSTableAdapters.V_MONHOCTableAdapter v_MONHOCTableAdapter;
        public System.Windows.Forms.TextBox txt_id;
    }
}