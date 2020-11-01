namespace QuanLyKhachSan
{
    partial class DoDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoDung));
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel5.TabIndex = 18;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(897, 62);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(194, 26);
            this.textSearch.TabIndex = 7;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(1028, 113);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(65, 42);
            this.butSearch.TabIndex = 6;
            this.butSearch.Text = "Tìm";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(715, 123);
            this.butDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(100, 46);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Xóa";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.BackColor = System.Drawing.Color.Transparent;
            this.radAdd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdd.Location = new System.Drawing.Point(586, 130);
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
            this.radEdit.Location = new System.Drawing.Point(586, 186);
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
            this.radView.Location = new System.Drawing.Point(586, 62);
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
            this.butFree.Location = new System.Drawing.Point(715, 55);
            this.butFree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butFree.Name = "butFree";
            this.butFree.Size = new System.Drawing.Size(100, 46);
            this.butFree.TabIndex = 0;
            this.butFree.Text = "Xem";
            this.butFree.UseVisualStyleBackColor = true;
            this.butFree.Click += new System.EventHandler(this.butFree_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(307, 194);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(163, 26);
            this.textPrice.TabIndex = 9;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(307, 133);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(163, 26);
            this.textName.TabIndex = 10;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(307, 65);
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
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.butDel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radEdit);
            this.panel3.Controls.Add(this.butFree);
            this.panel3.Controls.Add(this.radAdd);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.radView);
            this.panel3.Controls.Add(this.textPrice);
            this.panel3.Controls.Add(this.textName);
            this.panel3.Controls.Add(this.textID);
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
            this.listView1.Location = new System.Drawing.Point(0, 279);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1256, 298);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 262;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "ID vật dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tên";
            // 
            // DoDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 577);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1278, 633);
            this.MinimumSize = new System.Drawing.Size(1278, 633);
            this.Name = "DoDung";
            this.Text = "Vật dụng";
            this.Load += new System.EventHandler(this.FormDoDung_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}