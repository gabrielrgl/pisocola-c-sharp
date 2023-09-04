using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Pisocola.control;

namespace Pisocola.com.dao
{
    public class BaseDAO
    {
        protected string tableName;

        protected string columnParam;

        protected List<Object> GetList(string sql)
        {
            MySqlConnection c = MySqlConnectionConfig.GetConnection();
            c.Open();

            MySqlCommand cmd = new MySqlCommand(sql, c);
            MySqlDataReader dr = cmd.ExecuteReader();

            List<Object> list = new List<object>();

            try
            {
                Console.WriteLine("Connecting to MySQL...");
               
                while (dr.Read())
                {
                    Object obj = ProcessRow(dr);
                    list.Add(obj);
                }

                dr.Close();
                c.Close();
                Console.WriteLine("Done.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return list;
        }

        protected List<Dictionary<string, string>> GetListNoCast(string sql)
        {
            MySqlConnection c = MySqlConnectionConfig.GetConnection();
            c.Open();

            MySqlCommand cmd = new MySqlCommand(sql, c);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            try
            {
                Console.WriteLine("Connecting to MySQL...");

                while (dr.Read())
                {
                    list.Add(ProcessRowNoCast(dr));
                }

                dr.Close();
                c.Close();
                Console.WriteLine("Done.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.ToString());
            }

            return list;
        }

        protected Object GetItem(string sql)
        {
            List<Object> list = GetList(sql);

            if (list != null && list.Count > 0)
                return list[0];
            else
                return null;
        }

        protected Dictionary<string, string> GetItemNoCast(string sql)
        {
            List<Dictionary<string, string>> list = GetListNoCast(sql);

            if (list != null && list.Count > 0)
                return list[0];
            else
                return null;
        }

        protected int instertItem(string sql, Object[] objs)
        {

            int lastTableId = 0;

            try
            {
                string database = MySqlConnectionConfig.GetDatabase();

                MySqlConnection c = MySqlConnectionConfig.GetConnection();
                c.Open();

                Console.WriteLine("Connecting to MySQL...");

                sql = replaceValues(sql, objs);

                Console.WriteLine("SQL: " + sql);

                MySqlCommand cmd = new MySqlCommand(sql, c);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Close();

                cmd = new MySqlCommand("SELECT auto_increment - 1 LAST_ID FROM information_schema.tables WHERE table_name = '" + tableName + "' AND table_schema = '" + database + "'", c);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastTableId = Convert.ToInt32(dr["LAST_ID"]);
                }

                dr.Close();
                c.Close();

                Console.WriteLine("Done.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return lastTableId;
        }

        protected Object UpdateItem(string sql, Object[] paramObj, int idParam)
        {

            Object obj = null;

            try
            {
                MySqlConnection c = MySqlConnectionConfig.GetConnection();
                c.Open();

                Console.WriteLine("Connecting to MySQL...");

                sql = replaceValues(sql, paramObj);

                Console.WriteLine("SQL: " + sql);

                MySqlCommand cmd = new MySqlCommand(sql, c);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Close();
                c.Close();

                Console.WriteLine("Done.");

                obj = GetItem("SELECT * FROM " + tableName + " WHERE 1=1 AND " + columnParam + " = " + idParam);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return obj;
        }

        protected void DeleteItem(string sql, Object[] paramObj)
        {
            try
            {
                MySqlConnection c = MySqlConnectionConfig.GetConnection();
                c.Open();

                Console.WriteLine("Connecting to MySQL...");

                sql = replaceValues(sql, paramObj);

                Console.WriteLine("SQL: " + sql);

                MySqlCommand cmd = new MySqlCommand(sql, c);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Close();
                c.Close();

                Console.WriteLine("Done.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string replaceValues(string sql, Object[] objs)
        {

            Object value;
            string replace = "@";
            int strIndex;

            MatchCollection matches;

            foreach (Object obj in objs)
            {
                matches = Regex.Matches(sql, replace);
                value = obj;

                foreach (Match match in matches)
                {
                    strIndex = match.Index;

                    if (obj.GetType() != typeof(int) || obj.GetType() != typeof(float))
                    {
                        value = (string)"'" + obj + "'";
                    }
                    else
                    {
                        value = Convert.ToInt32(value).ToString();
                    }

                    sql = sql.Remove(strIndex, 1).Insert(strIndex, (string)value);

                    break;

                }

            }

            return sql;
        }

        protected virtual Object ProcessRow(MySqlDataReader data)
        {
            Console.WriteLine("ProcessRow nao Implementado");
            return null;
        }

        protected virtual Dictionary<string, string> ProcessRowNoCast(MySqlDataReader data)
        {
            Console.WriteLine("ProcessRowNoCast nao Implementado");
            return null;
        }

    }
}
