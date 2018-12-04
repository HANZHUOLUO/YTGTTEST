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

namespace Quality
{
    public partial class IJLIST : DevExpress.XtraEditors.XtraForm
    {
        public IJLIST()
        {
            InitializeComponent();
        }
        int selecindex;
        /// <summary>
        /// 单据体点击事件（打开单据修改界面，获取行焦点进行删除、审核操作）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl1_Click(object sender, EventArgs e)
        {
            selecindex = gridView1.GetSelectedRows()[0];


        }

        private void IJLIST_Load(object sender, EventArgs e)
        {
            this.gridView1.BestFitColumns();
        }
    }
}