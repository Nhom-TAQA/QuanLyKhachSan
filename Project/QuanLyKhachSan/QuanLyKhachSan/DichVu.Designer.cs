namespace QuanLyKhachSan
{
    partial class DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVu));
            this.panel5 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.radView = new System.Windows.Forms.RadioButton();
            this.butFree = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1256, 577);
            this.panel5.TabIndex = 19;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(892, 67);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(194, 26);
            this.textSearch.TabIndex = 7;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(1015, 120);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(71, 52);
            this.butSearch.TabIndex = 6;
            this.butSearch.Text = "Tìm";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(744, 148);
            this.butDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(100, 46);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Delete";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.BackColor = System.Drawing.Color.Transparent;
            this.radAdd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdd.Location = new System.Drawing.Point(592, 131);
            this.radAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(82, 29);
            this.radAdd.TabIndex = 4;
            this.radAdd.Text = "Thêm";
            this.radAdd.UseVisualStyleBackColor = false;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.BackColor = System.Drawing.Color.Transparent;
            this.radEdit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEdit.Location = new System.Drawing.Point(590, 192);
            this.radEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(71, 29);
            this.radEdit.TabIndex = 4;
            this.radEdit.Text = "Sửa";
            this.radEdit.UseVisualStyleBackColor = false;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radView
            // 
            this.radView.AutoSize = true;
            this.radView.BackColor = System.Drawing.Color.Transparent;
            this.radView.Checked = true;
            this.radView.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radView.Location = new System.Drawing.Point(592, 64);
            this.radView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radView.Name = "radView";
            this.radView.Size = new System.Drawing.Size(72, 29);
            this.radView.TabIndex = 2;
            this.radView.TabStop = true;
            this.radView.Text = "Xem";
            this.radView.UseVisualStyleBackColor = false;
            this.radView.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // butFree
            // 
            this.butFree.Enabled = false;
            this.butFree.Location = new System.Drawing.Point(744, 67);
            this.butFree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butFree.Name = "butFree";
            this.butFree.Size = new System.Drawing.Size(100, 46);
            this.butFree.TabIndex = 0;
            this.butFree.Text = "View";
            this.butFree.UseVisualStyleBackColor = true;
            this.butFree.Click += new System.EventHandler(this.butFree_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(304, 194);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(163, 26);
            this.textPrice.TabIndex = 9;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(304, 134);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(163, 26);
            this.textName.TabIndex = 10;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(304, 66);
            this.textID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(163, 26);
            this.textID.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.butSearch);
            this.panel3.Controls.Add(this.textSearch);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.butDel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.radEdit);
            this.panel3.Controls.Add(this.butFree);
            this.panel3.Controls.Add(this.radAdd);
            this.panel3.Controls.Add(this.textPrice);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.radView);
            this.panel3.Controls.Add(this.textID);
            this.panel3.Controls.Add(this.textName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1256, 577);
            this.panel3.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 306);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1256, 271);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service ID";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Service Name";
            this.columnHeader2.Width = 228;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "ID dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Giá dịch vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tên dịch vụ";
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 577);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1278, 633);
            this.MinimumSize = new System.Drawing.Size(1278, 633);
            this.Name = "DichVu";
            this.Text = "Dịch Vụ";
            this.Load += new System.EventHandler(this.FormDichVu_Load);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.RadioButton radView;
        private System.Windows.Forms.Button butFree;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}