using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Quality
{
    class DbCon
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter sda;
        DataSet ds;
        ///打开数据库连接
        public SqlConnection GetCon()
        {///测试用本机ip + "\\MSSQLSERVER12"KINGDEE\\MSSQLSERVER12
            string str = string.Format("server={3};database={0};uid={1};pwd={2}", Model.AccId, Model.Uid, Model.Pwd,Model.IpAdress + "\\MSSQLSERVER12");
            con = new SqlConnection(str);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        ////关闭数据库连接
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }

        }
        ///执行CANMAND语句
        public SqlCommand InsertStr(string str)
        {
            GetCon();
            cmd = new SqlCommand(str, GetCon());
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            CloseCon();
            return cmd;
        }
        ///创建dataset对象
        public DataSet GetData(String str, String TableId)
        {
            GetCon();
            sda = new SqlDataAdapter(str, GetCon());
            ds = new DataSet();
            sda.Fill(ds, TableId);
            CloseCon();
            return ds;
        }
        /// <summary>
        /// 读取表中信息
        /// </summary>
        /// <param name="SQLstr"></param>
        /// <returns></returns>
        public SqlDataReader getcom(string SQLstr)
        {
            GetCon();   //打开与数据库的连接
            SqlCommand My_com = con.CreateCommand(); //创建一个SqlCommand对象，用于执行SQL语句
            My_com.CommandText = SQLstr;    //获取指定的SQL语句
            sdr = My_com.ExecuteReader(); //执行SQL语名句，生成一个SqlDataReader对象
            return sdr;
        }
    }
}
