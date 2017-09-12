using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace JTC.Common
{
    public static class DataTableToJsonHelper
    {
        /// <summary>
        /// 把DataTable里的数据转换成Json数据格式
        /// </summary>
        /// <param name="table">DataTable</param>
        /// <returns>string</returns>
        public static string DataTableToJson(DataTable table)
        {
            var JsonString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JsonString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JsonString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JsonString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JsonString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JsonString.Append("}");
                    }
                    else
                    {
                        JsonString.Append("},");
                    }
                }
                JsonString.Append("]");
            }
            return JsonString.ToString();
        }

        /// <summary>
        /// 把DataTable里的数据转换成Json数据格式
        /// </summary>
        /// <param name="table">DataTable</param>
        /// <returns>string</returns>
        public static string DataTableToJsonAll(DataTable table, int rowsnum, int columnnum)
        {
            var JsonString = new StringBuilder();
            if (rowsnum != 0)
            {
                JsonString.Append("{");
                JsonString.Append("\"rowsnum\":" + rowsnum + ",");
                JsonString.Append("\"columnnum\":" + columnnum + ",");
                JsonString.Append("\"columns\":[");
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    if (c < table.Columns.Count - 1)
                    {
                        JsonString.Append("{");
                        JsonString.Append("\"field\":\"" + table.Columns[c].ColumnName.ToString() + "\",\"title\":\"" + table.Columns[c].ColumnName.ToString() + "\"");
                        JsonString.Append("},");
                    }
                    else if (c == table.Columns.Count - 1)
                    {
                        JsonString.Append("{");
                        JsonString.Append("\"field\":\"" + table.Columns[c].ColumnName.ToString() + "\",\"title\":\"" + table.Columns[c].ColumnName.ToString() + "\"");
                        JsonString.Append("}");
                    }
                }
                JsonString.Append("],");
            }
            if (table.Rows.Count > 0)
            {
                JsonString.Append("\"rows\":[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JsonString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JsonString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JsonString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JsonString.Append("}");
                    }
                    else
                    {
                        JsonString.Append("},");
                    }
                }
                JsonString.Append("]");
                if (rowsnum != 0)
                {
                    JsonString.Append("}");
                }
            }
            return JsonString.ToString();
        }

        public static string Dataset2Json(DataSet ds, int total = -1)
        {
            StringBuilder json = new StringBuilder();

            foreach (DataTable dt in ds.Tables)
            {
                //{"total":5,"rows":[  
                json.Append("[");
                json.Append("{\"total\":");
                if (total == -1)
                {
                    json.Append(dt.Rows.Count);
                }
                else
                {
                    json.Append(total);
                }
                json.Append(",\"rows\":[");
                json.Append(DataTable2Json(dt));
                json.Append("]}");
                json.Append("]");
            }
            return json.ToString();
        }

        /// <summary>    
        /// dataTable转换成Json格式    
        /// </summary>    
        /// <param name="dt"></param>    
        /// <returns></returns>    
        public static string DataTable2Json(DataTable dt)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName);
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(dt.Rows[i][j].ToString());
                    jsonBuilder.Append("\",");
                }
                if (dt.Columns.Count > 0)
                {
                    jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                }
                jsonBuilder.Append("},");
            }
            if (dt.Rows.Count > 0)
            {
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            }
            jsonBuilder.Append("]");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// 将DataTable中的数据转换成JSON格式
        /// </summary>
        /// <param name="dt">数据源DataTable</param>
        /// <param name="displayCount">是否输出数据总条数</param>
        /// <param name="totalcount">JSON中显示的数据总条数</param>
        /// <returns></returns>
        public static string CreateJsonParameters(DataTable dt, bool displayCount, int totalcount)
        {
            StringBuilder JsonString = new StringBuilder();
            //Exception Handling        

            if (dt != null)
            {
                JsonString.Append("{ ");
                JsonString.Append("\"rows\":[ ");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    JsonString.Append("{ ");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j < dt.Columns.Count - 1)
                        {
                            //if (dt.Rows[i][j] == DBNull.Value) continue;
                            if (dt.Columns[j].DataType == typeof(bool))
                            {
                                JsonString.Append("\"JSON_" + dt.Columns[j].ColumnName + "\":" +
                                                  dt.Rows[i][j].ToString().ToLower() + ",");
                            }
                            else if (dt.Columns[j].DataType == typeof(string))
                            {
                                JsonString.Append("\"JSON_" + dt.Columns[j].ColumnName + "\":" + "\"" +
                                                  dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\",");
                            }
                            else
                            {
                                JsonString.Append("\"JSON_" + dt.Columns[j].ColumnName + "\":" + "\"" + dt.Rows[i][j] + "\",");
                            }
                        }
                        else if (j == dt.Columns.Count - 1)
                        {
                            //if (dt.Rows[i][j] == DBNull.Value) continue;
                            if (dt.Columns[j].DataType == typeof(bool))
                            {
                                JsonString.Append("\"JSON_" + dt.Columns[j].ColumnName + "\":" +
                                                  dt.Rows[i][j].ToString().ToLower());
                            }
                            else if (dt.Columns[j].DataType == typeof(string))
                            {
                                JsonString.Append("\"JSON_" + dt.Columns[j].ColumnName + "\":" + "\"" +
                                                  dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\"");
                            }
                            else
                            {
                                JsonString.Append("\"JSON_" + dt.Columns[j].ColumnName + "\":" + "\"" + dt.Rows[i][j] + "\"");
                            }
                        }
                    }
                    /*end Of String*/
                    if (i == dt.Rows.Count - 1)
                    {
                        JsonString.Append("} ");
                    }
                    else
                    {
                        JsonString.Append("}, ");
                    }
                }
                JsonString.Append("]");

                if (displayCount)
                {
                    JsonString.Append(",");

                    JsonString.Append("\"total\":");
                    JsonString.Append(totalcount);
                }

                JsonString.Append("}");
                return JsonString.ToString().Replace("\n", "");
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 把DataTable里的数据转换成Json数据格式 DataTableToJsonEasyUI
        /// </summary>
        /// <param name="table">DataTable</param>
        /// <param name="total">int</param>
        /// <param name="columnnum">int</param>
        /// <returns>string</returns>
        public static string DataTableToJsonEasyUI(DataTable table, int total, int columnnum)
        {
            var JsonString = new StringBuilder();
            JsonString.Append("{");
            JsonString.Append("\"total\":" + total + ",");
            if (columnnum != 0)
            {
                JsonString.Append("\"columnnum\":" + columnnum + ",");
                JsonString.Append("\"columns\":[");
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    if (c < table.Columns.Count - 1)
                    {
                        JsonString.Append("{");
                        JsonString.Append("\"field\":\"" + table.Columns[c].ColumnName.ToString() + "\",\"title\":\"" + table.Columns[c].ColumnName.ToString() + "\"");
                        JsonString.Append("},");
                    }
                    else if (c == table.Columns.Count - 1)
                    {
                        JsonString.Append("{");
                        JsonString.Append("\"field\":\"" + table.Columns[c].ColumnName.ToString() + "\",\"title\":\"" + table.Columns[c].ColumnName.ToString() + "\"");
                        JsonString.Append("}");
                    }
                }
                JsonString.Append("],");
            }
            JsonString.Append("\"rows\":[");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                JsonString.Append("{");
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (j < table.Columns.Count - 1)
                    {
                        JsonString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                       
                    }
                    else if (j == table.Columns.Count - 1)
                    {
                        JsonString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        JsonString.Append(",\"state\": \"closed\"");
                    }
                   
                }
                //string strId = id.ToString();
                //int lastIdInt = int.Parse(strId.Substring(strId.Length - 1, 1));//取得id的最后一位数字 判断大于0没有子节点，等于0有子节点
                //if (lastIdInt > 0)
                //{
                //    parentJson += ",\"state\": \"open\"";
                //}
                //else
                //{
                //    parentJson += ",\"state\": \"closed\"";
                //}
                if (i == table.Rows.Count - 1)
                {
                    JsonString.Append("}");
                }
                else
                {
                    JsonString.Append("},");
                }
            }
            JsonString.Append("]");
            JsonString.Append("}");
            return JsonString.ToString();
        }


        public static IList DataTableToJsonList(DataTable dt)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, object> result = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    result.Add(dc.ColumnName, dr[dc]);
                }
                list.Add(result);
            }
            return list;
        }

        public static string CreateErrorJson(string errorMsg, int totalcount)
        {
            StringBuilder JsonString = new StringBuilder();
            //Exception Handling        
            JsonString.Append("[");
            JsonString.Append("{");
            JsonString.Append("\"");
            JsonString.Append("msg");
            JsonString.Append("\":\"");
            JsonString.Append(errorMsg);
            JsonString.Append("\",");
            JsonString.Append("\"");
            JsonString.Append("total");
            JsonString.Append("\":\"");
            JsonString.Append(totalcount);
            JsonString.Append("\",");
            JsonString.Append("}");
            JsonString.Append("]");

            return JsonString.ToString();
        }

    }
}
