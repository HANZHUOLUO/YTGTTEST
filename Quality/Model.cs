using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quality
{
    class Model
    {
        public static string IpAdress = "";///获取IP地址
        public static string AccName = "";///获取账套名称
        public static string AccId = "";///获取账套id
        public static string Uid = "";///获取数据库登录用户名
        public static string Uname = "";///获取K3登录名
        public static string Pwd = "";///获取数据库登陆密码
        public static string Uninterid = "";///获取K3登录用户名密码
        DbCon Con = new DbCon();///实例化数据操作类对象
        public static string FSUPPLY = "";//获取供应商
        public static string FitemName = "";//获取物料名称
        public static string fitemid = "";///获取物料内码

        ///获取单据编码
        public String GetFbillNo(string str)
        {
            string fbillno = "";
            string sql = string.Format("exec GETZJBILLNO {0}", str);
            SqlDataReader sra = Con.getcom(sql);
            if (sra.HasRows)
            {
                sra.Read();
                fbillno = sra[0].ToString();

            }
            return fbillno;
        }
    }
}
