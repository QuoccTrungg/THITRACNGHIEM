
namespace TRACNGHIEM
{
    partial class Form_ThiTN
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOIDUNG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.A = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.C = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.D = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_luachon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_mamh = new System.Windows.Forms.ComboBox();
            this.vMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM.DS();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_nop = new System.Windows.Forms.Button();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cauhoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v_MONHOCTableAdapter = new TRACNGHIEM.DSTableAdapters.V_MONHOCTableAdapter();
            this.btn_sua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NOIDUNG,
            this.A,
            this.B,
            this.C,
            this.D});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MaximumSize = new System.Drawing.Size(1500, 300);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1180, 300);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.Width = 58;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.Text = "Nội Dung ";
            this.NOIDUNG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NOIDUNG.Width = 729;
            // 
            // A
            // 
            this.A.Text = "A";
            this.A.Width = 80;
            // 
            // B
            // 
            this.B.Text = "B";
            this.B.Width = 80;
            // 
            // C
            // 
            this.C.Text = "C";
            this.C.Width = 80;
            // 
            // D
            // 
            this.D.Text = "D";
            this.D.Width = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.txt_luachon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_mamh);
            this.groupBox1.Controls.Add(this.btn_xem);
            this.groupBox1.Controls.Add(this.btn_nop);
            this.groupBox1.Controls.Add(this.txt_d);
            this.groupBox1.Controls.Add(this.txt_b);
            this.groupBox1.Controls.Add(this.txt_c);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_a);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cauhoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtb_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 308);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1174, 401);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin CH";
            // 
            // txt_luachon
            // 
            this.txt_luachon.Location = new System.Drawing.Point(863, 35);
            this.txt_luachon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_luachon.Multiline = true;
            this.txt_luachon.Name = "txt_luachon";
            this.txt_luachon.Size = new System.Drawing.Size(295, 39);
            this.txt_luachon.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(731, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 39);
            this.label8.TabIndex = 23;
            this.label8.Text = "Đáp  án";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(383, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 39);
            this.label7.TabIndex = 22;
            this.label7.Text = "MAMH";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_mamh
            // 
            this.cmb_mamh.DataSource = this.vMONHOCBindingSource;
            this.cmb_mamh.DisplayMember = "MAMH";
            this.cmb_mamh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mamh.FormattingEnabled = true;
            this.cmb_mamh.Location = new System.Drawing.Point(513, 35);
            this.cmb_mamh.Name = "cmb_mamh";
            this.cmb_mamh.Size = new System.Drawing.Size(163, 24);
            this.cmb_mamh.TabIndex = 21;
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
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(1013, 118);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(145, 45);
            this.btn_xem.TabIndex = 20;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_nop
            // 
            this.btn_nop.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_nop.Location = new System.Drawing.Point(1013, 266);
            this.btn_nop.Name = "btn_nop";
            this.btn_nop.Size = new System.Drawing.Size(145, 49);
            this.btn_nop.TabIndex = 19;
            this.btn_nop.Text = "Nộp bài";
            this.btn_nop.UseVisualStyleBackColor = false;
            this.btn_nop.Click += new System.EventHandler(this.btn_nop_Click);
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(653, 334);
            this.txt_d.Margin = new System.Windows.Forms.Padding(4);
            this.txt_d.Multiline = true;
            this.txt_d.Name = "txt_d";
            this.txt_d.ReadOnly = true;
            this.txt_d.Size = new System.Drawing.Size(317, 45);
            this.txt_d.TabIndex = 18;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(653, 266);
            this.txt_b.Margin = new System.Windows.Forms.Padding(4);
            this.txt_b.Multiline = true;
            this.txt_b.Name = "txt_b";
            this.txt_b.ReadOnly = true;
            this.txt_b.Size = new System.Drawing.Size(317, 45);
            this.txt_b.TabIndex = 17;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(158, 334);
            this.txt_c.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c.Multiline = true;
            this.txt_c.Name = "txt_c";
            this.txt_c.ReadOnly = true;
            this.txt_c.Size = new System.Drawing.Size(317, 45);
            this.txt_c.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(26, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 45);
            this.label6.TabIndex = 15;
            this.label6.Text = "C";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(519, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 45);
            this.label5.TabIndex = 14;
            this.label5.Text = "B";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(519, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "D";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(158, 266);
            this.txt_a.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a.Multiline = true;
            this.txt_a.Name = "txt_a";
            this.txt_a.ReadOnly = true;
            this.txt_a.Size = new System.Drawing.Size(317, 45);
            this.txt_a.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(26, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cauhoi
            // 
            this.txt_cauhoi.Location = new System.Drawing.Point(158, 118);
            this.txt_cauhoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cauhoi.Multiline = true;
            this.txt_cauhoi.Name = "txt_cauhoi";
            this.txt_cauhoi.ReadOnly = true;
            this.txt_cauhoi.Size = new System.Drawing.Size(812, 130);
            this.txt_cauhoi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(26, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nội dung";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(158, 35);
            this.txtb_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_id.Multiline = true;
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.ReadOnly = true;
            this.txtb_id.Size = new System.Drawing.Size(182, 39);
            this.txtb_id.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_MONHOCTableAdapter
            // 
            this.v_MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(1013, 193);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(145, 45);
            this.btn_sua.TabIndex = 25;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // Form_ThiTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form_ThiTN";
            this.Text = "Form_ThiTN";
            this.Load += new System.EventHandler(this.Form_ThiTN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NOIDUNG;
        private System.Windows.Forms.ColumnHeader A;
        private System.Windows.Forms.ColumnHeader B;
        private System.Windows.Forms.ColumnHeader C;
        private System.Windows.Forms.ColumnHeader D;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_nop;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cauhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.ComboBox cmb_mamh;
        private DS dS;
        private System.Windows.Forms.BindingSource vMONHOCBindingSource;
        private DSTableAdapters.V_MONHOCTableAdapter v_MONHOCTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_luachon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sua;
    }
}