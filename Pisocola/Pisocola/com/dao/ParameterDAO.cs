using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Pisocola.com.model;

namespace Pisocola.com.dao
{
    class ParameterDAO : BaseDAO
    {
        private static ParameterDAO instance;

        public static ParameterDAO GetInstance()
        {
            if (instance == null)
                instance = new ParameterDAO();

            return instance;
        }

        public ParameterDAO()
        {
            tableName = "parameter";
            columnParam = "ID_TOPIC";
        }

        public List<Object> GetParameters()
        {
            return GetList("SELECT * FROM " + tableName);
        }

        public List<Object> GetParameterByTopic(string idTopic)
        {
            return GetList("SELECT * FROM " + tableName + " WHERE 1=1 AND ID_TOPIC = '" + idTopic + "'");
        }

        public Parameter GetParameterByTopicAndName(string idTopic, string nmParameter)
        {
            return (Parameter) GetItem("SELECT * FROM " + tableName + " WHERE 1=1 AND ID_TOPIC = '" + idTopic + "' AND NM_PARAMETER = '" + nmParameter + "'");
        }

        protected override Dictionary<string, string> ProcessRowNoCast(MySqlDataReader data)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            
            for (int count = 0; count < data.FieldCount; count++)
            {
                d.Add(data.GetName(count), Convert.ToString(data.GetValue(count)));
            }

            return d;
        }

        protected override Object ProcessRow(MySqlDataReader data)
        {
            Parameter parameter = new Parameter();

            parameter.SetIdParameter((int)data["ID_PARAMETER"]);
            parameter.SetIdTopic((string) data["ID_TOPIC"]);
            parameter.SetNmParameter((string) data["NM_PARAMETER"]);
            parameter.SetVlValue((string)data["VL_VALUE"]);
            parameter.SetDtInsert((DateTime)data["DT_INSERT"]);

            return parameter;
        }
    }
}
