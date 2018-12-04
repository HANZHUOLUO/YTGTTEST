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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Quality
{
    public partial class FSUPPLYFILTER : DevExpress.XtraEditors.XtraForm
    {
        public FSUPPLYFILTER()
        {
            InitializeComponent();
        }
        DbCon conn = new DbCon();
        DataSet ds;
        //定义委托事件
        public delegate void FsupplyEvent(string str);
        public event FsupplyEvent Myevent;
        /// <summary>
        /// 单据加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FSUPPLYFILTER_Load(object sender, EventArgs e)
        {
           
            this.textBox1.Text = Model.FSUPPLY;
            GetSupplyInfo();///加载单据体信息
        }
        /// <summary>
        /// 查询按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GetSupplyInfo();///加载单据体信息
        }
        /// <summary>
        /// 供应商名称回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                GetSupplyInfo();///加载单据体信息
            }
        }
        /// <summary>
        /// 单据体点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl1_Click(object sender, EventArgs e)
        {
            int selectindex = this.gridView1.GetSelectedRows()[0];
            if (Myevent!=null)///判断事件是否注册
            {
                Myevent(this.gridView1.GetRowCellValue(selectindex, "供应商名称").ToString());
            }
            this.Close();

        }
        ///加载供应商资料
        public void GetSupplyInfo()
        {
            string str = string.Format("SELECT fnumber as 供应商编码,fname as 供应商名称 FROM t_Supplier where fname like '%{0}%'",this.textBox1.Text);
            ds = conn.GetData(str,"supply");
            gridControl1.DataSource = ds.Tables["supply"];
            this.gridView1.BestFitColumns();///自适应列宽

        }
    }
}