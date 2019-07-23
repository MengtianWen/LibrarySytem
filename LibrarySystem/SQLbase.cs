using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;  //与数据库有关
using System.Windows.Forms;


namespace LibrarySystem
{
    class SQLbase
    {
        //获取连接数据库的方法
        public static SqlConnection getConn()
        {
            SqlConnection conn = null;
            try
            {
                //首先创建指定连接属性的字符串
                //server指本地数据库，用.给它赋值；user指连接数据库的用户名；pwd指对应的密码；database指所要连接的数据库名称
                string connStr = "server=.;user=wenmengtian;pwd=wenmengtian;database=dbLibrary";
                //利用这个字符创创建一个SQL连接
                conn = new SqlConnection(connStr);
            }
            catch (SqlException e)
            {
                MessageBox.Show("数据库连接失败。\n" + e.Message, "消息");
            }
            return conn;
        }

        //关闭SqlConnection的方法
        public static void close(SqlConnection conn)
        {
            if(conn!=null||conn.State==System.Data.ConnectionState.Open)
            {
                try { conn.Close();conn = null; }
                catch(SqlException e) { MessageBox.Show("数据库异常" + e.Message, "消息"); }
            }
        }
        //关闭SqlCommand的方法
        public static void close(SqlCommand cmd)
        {
            if(cmd!=null)
            {
                try { cmd.Clone(); cmd = null; }
                catch(SqlException e) { MessageBox.Show("数据库异常" + e.Message, "消息"); }
            }
        }        
        //关闭SqlDataReader的方法
        public static void close(SqlDataReader dataReader)
        {
            if (dataReader != null)
            {
                try { dataReader.Close(); dataReader = null; }
                catch (SqlException e) { MessageBox.Show("数据库异常" + e.Message, "消息"); }
            }
        }
        //添加数据的命令操作
        public static void insert(string insertStr)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = SQLbase.getConn();
                conn.Open();
                cmd = new SqlCommand(insertStr, conn);
                int result = cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("数据添加成功！", "消息");
                }
                else
                {
                    MessageBox.Show("数据添加失败！", "消息");
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show("数据库异常" + e.Message, "消息");
            }
            finally
            {
                SQLbase.close(cmd);
                SQLbase.close(conn);
            }
        }
    }
}
