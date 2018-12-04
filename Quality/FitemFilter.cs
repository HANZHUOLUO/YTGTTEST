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
    public partial class FitemFilter : DevExpress.XtraEditors.XtraForm
    {
        public FitemFilter()
        {
            InitializeComponent();
        }
        DbCon conn = new DbCon();//实例化数据公共类
        DataSet ds;
        public delegate void fitemevent(string str,string str1);
        public event fitemevent myevent;
        /// <summary>
        /// 单据加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FitemFilter_Load(object sender, EventArgs e)
        {
           
            this.textBox1.Text = Model.FitemName;
            GetFitemInfo();///加载物料
        }
        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GetFitemInfo();
        }
        /// <summary>
        /// 物料回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                GetFitemInfo();

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
            if (myevent!=null)///查询事件是否注册
            {
                myevent(this.gridView1.GetRowCellValue(selectindex, "物料名称").ToString(), 
                    this.gridView1.GetRowCellValue(selectindex, "物料内码").ToString());
            }
            this.Close();
        }
        ///加载单据体
        public void GetFitemInfo()
        {
            string SelectStr = string.Format("SELECT FNumber as 物料编码,FName as 物料名称,FModel as 规格型号,FItemID as 物料内码 FROM t_ICItem   WHERE FName LIKE '%{0}%'", this.textBox1.Text.Trim());
            ds = conn.GetData(SelectStr,"item");
            gridControl1.DataSource = ds.Tables["item"];
            gridView1.BestFitColumns();//单据体自适应列宽 
            
        }
    }
}