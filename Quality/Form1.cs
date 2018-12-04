using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using k3Login;
namespace Quality
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model model = new Model();
        DbCon con = new DbCon();
        DataSet ds;
        SqlDataReader sra;
        #region k3登录组件
        /// <summary>
        /// k3登录组件以及获取登录字符串
        /// </summary>
        public void KingdeeLogin()
        {
            k3Login.ClsLogin login = new k3Login.ClsLoginClass();
            if (login.CheckLogin() == true)
            {
                string str;
                str = login.PropsString;
                Model.IpAdress = str.Substring(str.IndexOf("IP") + 3, str.IndexOf("K3Version") - (str.IndexOf("IP") + 4));///获取IP地址
                Model.Uid = str.Substring(str.IndexOf("ID") + 3, str.IndexOf("Password") - (str.IndexOf("ID") + 4));///获取数据库登录用户
                Model.Pwd = str.Substring(str.IndexOf("Password") + 9, str.IndexOf("Data") - (str.IndexOf("Password") + 10));///获取数据库登陆密码
                Model.AccId = str.Substring(str.IndexOf("Catalog") + 8, str.IndexOf("}") - (str.IndexOf("Catalog") + 8));///获取数据库实体名称
                Model.Uninterid = str.Substring(str.IndexOf("UserID") + 7, str.IndexOf("DBMS") - (str.IndexOf("UserID") + 8));///获取登陆用户内码
                Model.AccName = login.AcctName;///获取账套信息
                Model.Uname = login.UserName;///获取用户名
                toolStripStatusLabel1.Text = "当前账套：" + Model.AccName + "  ||  ";
                toolStripStatusLabel2.Text = "   当前登录用户：" + Model.Uname + "  ||  ";


            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
            #endregion

        }
        #region 切换账套事件
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            KingdeeLogin();///加载K3登陆界面事件
        }
   
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "统计试样委托单新增")
            {
                TJINSERT tjinsert = new TJINSERT();
                ///设置不是顶级窗体
                tjinsert.TopLevel = false;
                ///将窗体放入面板中
                panel4.Controls.Clear();
                panel4.Controls.Add(tjinsert);
                //显示
                tjinsert.Show();
            }
            else if (treeView1.SelectedNode.Text == "统计试样委托单列表")
            {
                IJLIST ijlist = new IJLIST();
                //设置不是顶级窗体
                ijlist.TopLevel = false;
                //将窗体放入面板
                panel4.Controls.Clear();
                panel4.Controls.Add(ijlist);
                ijlist.Show();
            }
        }
    }
}
