using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisocola.com.model
{
    class Parameter
    {
        private int idParameter; 
        private string idTopic;
        private string nmParameter;
        private string vlValue;
        private DateTime dtInsert;

        public int GetIdParameter()
        {
            return idParameter;
        }

        public void SetIdParameter(int idParameter)
        {
            this.idParameter = idParameter;
        }

        public string GetIdTopic()
        {
            return idTopic;
        }

        public void SetIdTopic(string idTopic)
        {
            this.idTopic = idTopic;
        }

        public string GetNmParameter()
        {
            return nmParameter;
        }

        public void SetNmParameter(string nmParameter)
        {
            this.nmParameter = nmParameter;
        }

        public string GetVlValue()
        {
            return vlValue;
        }

        public void SetVlValue(string vlValue)
        {
            this.vlValue = vlValue;
        }

        public DateTime GetDtInsert()
        {
            return dtInsert;
        }

        public void SetDtInsert(DateTime dtInsert)
        {
            this.dtInsert = dtInsert;
        }
    }
}
