using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JTC.Common
{
    public class HttpRequestService
    {
        /// <summary>
        /// 发起一个HTTP请求（以GET方式）
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string HttpGet(string url)
        {
            string responseStr = "";
            try
            {
                WebRequest myWebRequest = WebRequest.Create(url);
                WebResponse myWebResponse = myWebRequest.GetResponse();
                Stream ReceiveStream = myWebResponse.GetResponseStream();

                if (ReceiveStream != null)
                {
                    StreamReader reader = new StreamReader(ReceiveStream, Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
                myWebResponse.Close();
                return responseStr;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
