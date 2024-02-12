using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using H3OpgaveETL1.Client.Code;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace H3OpgaveETL1.Client.Code
{
    public class Transform
    {
       public DataTable ConvertJsonToDataTable(string json)
        {
            // Du skal bruge Newtonsoft.Json
            JObject jsonObject = JObject.Parse(json);
            DataTable? dt = jsonObject["records"].ToObject<DataTable>();
            return dt;
        }

        public string ConvertJsonToString(string json) 
        {
            StringBuilder stringBuilder = new StringBuilder();

            DataTable? dt = ConvertJsonToDataTable(json);

            if (dt.Columns.Count == 0) return null;

            foreach (DataColumn col in dt.Columns)
            {
                if (col != null)
                {
                    // Enclose the column name in quotes and escape any internal quotes
                    stringBuilder.Append("\"" + col.ToString().Replace("\"", "\"\"") + "\"");
                }

                stringBuilder.Append(",");
            }

            if (dt.Columns.Count > 0)
            {
                stringBuilder.Length--;
            }

            stringBuilder.AppendLine();

            foreach (DataRow row in dt.Rows) 
            { 
                foreach(var rowColumn in row.ItemArray) 
                {
                    if (rowColumn != null)
                    {
                        // Enclose the column name in quotes and escape any internal quotes
                        stringBuilder.Append("\"" + rowColumn.ToString().Replace("\"", "\"\"") + "\"");
                    }

                    stringBuilder.Append(",");
                }

                if (dt.Columns.Count > 0)
                {
                    stringBuilder.Length--;
                }

                stringBuilder.AppendLine();

            }
            return stringBuilder.ToString();
        }
    }
}
