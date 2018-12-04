namespace Quality
{
    partial class TJINSERT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TJINSERT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FSATIC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FSUPPLY = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FITEMNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FCH = new System.Windows.Forms.TextBox();
            this.FBILLNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下达化验部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FAPPDATE = new System.Windows.Forms.TextBox();
            this.FAPPUSER = new System.Windows.Forms.TextBox();
            this.FCREATEDATE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FCREATER = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FJYXM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FJYZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSFCYKJ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.FITEMID = new System.Windows.Forms.TextBox();
            this.获取状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FSATIC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FSUPPLY);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FITEMID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.FITEMNAME);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FCH);
            this.panel1.Controls.Add(this.FBILLNO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 69);
            this.panel1.TabIndex = 0;
         
            // 
            // FSATIC
            // 
            this.FSATIC.Enabled = false;
            this.FSATIC.FormattingEnabled = true;
            this.FSATIC.Items.AddRange(new object[] {
            "新增",
            "已保存，待下达化验部",
            "已审核，化验信息已反写"});
            this.FSATIC.Location = new System.Drawing.Point(76, 39);
            this.FSATIC.Name = "FSATIC";
            this.FSATIC.Size = new System.Drawing.Size(137, 22);
            this.FSATIC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "单据状态：";
            // 
            // FSUPPLY
            // 
            this.FSUPPLY.Location = new System.Drawing.Point(288, 12);
            this.FSUPPLY.Name = "FSUPPLY";
            this.FSUPPLY.Size = new System.Drawing.Size(133, 22);
            this.FSUPPLY.TabIndex = 3;
            this.FSUPPLY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FSUPPLY_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(433, 39);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "选择";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "供应商：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "车   号：";
            // 
            // FITEMNAME
            // 
            this.FITEMNAME.Location = new System.Drawing.Point(486, 12);
            this.FITEMNAME.Name = "FITEMNAME";
            this.FITEMNAME.Size = new System.Drawing.Size(133, 22);
            this.FITEMNAME.TabIndex = 5;
            this.FITEMNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FITEMNAME_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "物料名称：";
            // 
            // FCH
            // 
            this.FCH.Location = new System.Drawing.Point(289, 39);
            this.FCH.Name = "FCH";
            this.FCH.ReadOnly = true;
            this.FCH.Size = new System.Drawing.Size(133, 22);
            this.FCH.TabIndex = 3;
            // 
            // FBILLNO
            // 
            this.FBILLNO.Enabled = false;
            this.FBILLNO.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FBILLNO.Location = new System.Drawing.Point(76, 12);
            this.FBILLNO.Name = "FBILLNO";
            this.FBILLNO.ReadOnly = true;
            this.FBILLNO.Size = new System.Drawing.Size(137, 22);
            this.FBILLNO.TabIndex = 1;
            this.FBILLNO.Text = "保存后自动填充";
            this.FBILLNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "单据编码：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.下达化验部ToolStripMenuItem,
            this.审核ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.获取状态ToolStripMenuItem});
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 下达化验部ToolStripMenuItem
            // 
            this.下达化验部ToolStripMenuItem.Name = "下达化验部ToolStripMenuItem";
            this.下达化验部ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.下达化验部ToolStripMenuItem.Text = "下达化验部";
            // 
            // 审核ToolStripMenuItem
            // 
            this.审核ToolStripMenuItem.Name = "审核ToolStripMenuItem";
            this.审核ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.审核ToolStripMenuItem.Text = "审核";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.FAPPDATE);
            this.panel2.Controls.Add(this.FAPPUSER);
            this.panel2.Controls.Add(this.FCREATEDATE);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.FCREATER);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 38);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "审核日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "创建日期：";
            // 
            // FAPPDATE
            // 
            this.FAPPDATE.Location = new System.Drawing.Point(661, 9);
            this.FAPPDATE.Name = "FAPPDATE";
            this.FAPPDATE.ReadOnly = true;
            this.FAPPDATE.Size = new System.Drawing.Size(127, 22);
            this.FAPPDATE.TabIndex = 1;
            // 
            // FAPPUSER
            // 
            this.FAPPUSER.Location = new System.Drawing.Point(467, 9);
            this.FAPPUSER.Name = "FAPPUSER";
            this.FAPPUSER.ReadOnly = true;
            this.FAPPUSER.Size = new System.Drawing.Size(127, 22);
            this.FAPPUSER.TabIndex = 1;
            // 
            // FCREATEDATE
            // 
            this.FCREATEDATE.Location = new System.Drawing.Point(280, 9);
            this.FCREATEDATE.Name = "FCREATEDATE";
            this.FCREATEDATE.ReadOnly = true;
            this.FCREATEDATE.Size = new System.Drawing.Size(127, 22);
            this.FCREATEDATE.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "审核人：";
            // 
            // FCREATER
            // 
            this.FCREATER.Location = new System.Drawing.Point(86, 9);
            this.FCREATER.Name = "FCREATER";
            this.FCREATER.ReadOnly = true;
            this.FCREATER.Size = new System.Drawing.Size(127, 22);
            this.FCREATER.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "创建人：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 324);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FJYXM,
            this.FJYZ,
            this.FSFCYKJ});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(831, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // FJYXM
            // 
            this.FJYXM.HeaderText = "检验项目";
            this.FJYXM.Name = "FJYXM";
            this.FJYXM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FJYZ
            // 
            this.FJYZ.HeaderText = "实际检验值";
            this.FJYZ.Name = "FJYZ";
            this.FJYZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FSFCYKJ
            // 
            this.FSFCYKJ.HeaderText = "是否参与扣价";
            this.FSFCYKJ.Name = "FSFCYKJ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除行ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // 删除行ToolStripMenuItem
            // 
            this.删除行ToolStripMenuItem.Name = "删除行ToolStripMenuItem";
            this.删除行ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.删除行ToolStripMenuItem.Text = "删除行";
            this.删除行ToolStripMenuItem.Click += new System.EventHandler(this.删除行ToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "物料内码：";
            this.label10.Visible = false;
            // 
            // FITEMID
            // 
            this.FITEMID.Location = new System.Drawing.Point(574, 40);
            this.FITEMID.Name = "FITEMID";
            this.FITEMID.ReadOnly = true;
            this.FITEMID.Size = new System.Drawing.Size(133, 22);
            this.FITEMID.TabIndex = 5;
            this.FITEMID.Visible = false;
            // 
            // 获取状态ToolStripMenuItem
            // 
            this.获取状态ToolStripMenuItem.Name = "获取状态ToolStripMenuItem";
            this.获取状态ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.获取状态ToolStripMenuItem.Text = "获取状态";
           
            // 
            // TJINSERT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 456);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TJINSERT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "统计试样委托单-新增";
            this.Load += new System.EventHandler(this.TJINSERT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FBILLNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下达化验部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 审核ToolStripMenuItem;
        private System.Windows.Forms.TextBox FSUPPLY;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FITEMNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FSATIC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FCREATER;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FCREATEDATE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FAPPDATE;
        private System.Windows.Forms.TextBox FAPPUSER;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FJYXM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FJYZ;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FSFCYKJ;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除行ToolStripMenuItem;
        private System.Windows.Forms.TextBox FITEMID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem 获取状态ToolStripMenuItem;
    }
}