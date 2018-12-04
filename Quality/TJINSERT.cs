using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace Quality
{
    public partial class TJINSERT : DevExpress.XtraEditors.XtraForm
    {
        public TJINSERT()
        {
            InitializeComponent();
        }
        DbCon con = new DbCon();
        private void TJINSERT_Load(object sender, EventArgs e)
        {

            this.FCREATER.Text = Model.Uname;
            this.FCREATEDATE.Text = System.DateTime.Now.ToLocalTime().ToString();
            this.FSATIC.SelectedIndex = 0;
            AutoSizeColumn(dataGridView1);


        }
        /// <summary>
        ///调出车号选择弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Model.FSUPPLY = this.FSUPPLY.Text;
            Model.FitemName = this.FITEMNAME.Text;
            FCHXZ CH = new FCHXZ();
            CH.Show();
        }
        /// <summary>
        /// 使DataGridView的列自适应宽度
        /// </summary>
        /// <param name="dgViewFiles"></param>
        private void AutoSizeColumn(DataGridView dgViewFiles)
        {
            int width = 0;
            //使列自使用宽度
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < dgViewFiles.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                dgViewFiles.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += dgViewFiles.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，
            //则将DataGridView的列自动调整模式设置为显示的列即可，
            //如果是小于原来设定的宽度，将模式改为填充。
            if (width > dgViewFiles.Size.Width)
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列 从左开始 0，1，2
            dgViewFiles.Columns[1].Frozen = true;
        }

        private void 删除行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectindex = this.dataGridView1.CurrentRow.Index;///获取datagridview选中行索引
            dataGridView1.Rows.Remove(dataGridView1.Rows[selectindex]);///根据索引删除行
        }
        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow r = this.dataGridView1.Rows[i];
                r.HeaderCell.Value = string.Format("{0}", i + 1);
            }
            this.dataGridView1.Refresh();


        }
        /// <summary>
        /// 物料回车事件调出过滤界面（委托）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FITEMNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Model.FitemName = this.FITEMNAME.Text.Trim();///公共变量传值
                FitemFilter filter = new FitemFilter();
                filter.myevent += new FitemFilter.fitemevent(Filter_myevent);///接收数据
                filter.ShowDialog();
            }
        }

        private void Filter_myevent(string str, string str1)
        {
            this.FITEMNAME.Text = str;
            this.FITEMID.Text = str1;
        }
        /// <summary>
        /// 供应商回车事件（委托）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FSUPPLY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                FSUPPLYFILTER fsupplyfilter = new FSUPPLYFILTER();
                fsupplyfilter.Myevent += new FSUPPLYFILTER.FsupplyEvent(Fsupplyfilter_Myevent);
                fsupplyfilter.ShowDialog();
            }
        }

        private void Fsupplyfilter_Myevent(string str)
        {
            this.FSUPPLY.Text = str;
        }
        /// <summary>
        /// 新增按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearUI();
            this.FCREATER.Text = Model.Uname;
            this.FCREATEDATE.Text = System.DateTime.Now.ToLocalTime().ToString();
        }

        ///清空界面
        public void ClearUI()
        {
            this.FBILLNO.Text = "保存后自动填充";
            this.FSUPPLY.Text = "";
            this.FITEMNAME.Text = "";
            this.FSATIC.SelectedIndex = 0;
            this.FCH.Text = "";
            this.FITEMID.Text = "";
            this.dataGridView1.Rows.Clear();//清空gridview中的值
            this.FCREATER.Text = "";
            this.FCREATEDATE.Text = "";
            this.FAPPUSER.Text = "";
            this.FAPPDATE.Text = "";
        }
        /// <summary>
        /// 保存操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if ()
            //{

            //}
        }
        ///锁定界面操作
        public void LockUI()
        {
            this.FSUPPLY.ReadOnly = true;
            this.FITEMNAME.ReadOnly = true;
            this.dataGridView1.Enabled = true;

        }
        ///数据库新增操作
        public void InsertStrO()
        {
            try
            {
                //拼接字符串
                string StrInsertA = string.Format("insert into T_YTGTZJ_TJSY values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    FBILLNO.Text, FSUPPLY.Text, FITEMNAME.Text, FSATIC.Text, FCH.Text, FITEMID.Text, FCREATER.Text, FCREATEDATE.Text, FAPPUSER.Text, FAPPDATE.Text);
                ///数据库导入操作
                con.InsertStr(StrInsertA);
                //循环导入单据体操作
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    ///判断检验项目是否为空
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() != string.Empty)//False
                    {
                        string kj = "";
                        bool flag = Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].EditedFormattedValue);
                        kj=(flag ==true)?  "1" : "0";                      
                        string StrinsertB = string.Format("insert into T_YTGTZJ_TJSYENTRY values('{0}','{1}','{2}','{3}')", FBILLNO.Text, dataGridView1.Rows[i].Cells[0].Value.ToString(),
                            dataGridView1.Rows[i].Cells[2].Value.ToString(), kj);
                        con.InsertStr(StrinsertB);
                    }
                    else//true
                    {
                        break;
                    }

                }
            }
            catch (Exception xe)
            {
                MessageBox.Show(xe.Message);
            }

        }

        ///修改操作
        public void UpdateBill()
        {
            try
            {

            }
            catch (Exception ex)
            {


            }
        }
    }
}

