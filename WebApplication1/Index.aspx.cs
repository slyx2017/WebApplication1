using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JTC.Common;
using System.Xml;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTacking_Click(object sender, EventArgs e)
        {
            sfExpressService.ExpressServiceClient service = new sfExpressService.ExpressServiceClient();
            lblMsg.Text = "";
            string track_number = txtTrackNumber.Text;//"444003077898";
            string checkword = "j8DzkIFgmlomPt0aLuwU";
            string xml = "<Request service='RouteService' lang='zh-CN'><Head>BSPdevelop</Head><Body><RouteRequest tracking_type='1' method_type='1' tracking_number='{0}'/></Body></Request>";
            //string xml = "<Request service='RouteService' lang='zh-CN'><Head>BSPdevelop</Head><Body><RouteRequest tracking_type='1' method_type='1' tracking_number='444003077898'></RouteRequest></Body></Request>";
            string strXml = string.Format(xml, track_number);
            string verifyCode = "";
            string xmlck = strXml + checkword;
            verifyCode= Encrypt.MD5ToBase64String(xmlck);
            string param = service.sfexpressService(strXml, verifyCode);
            XmlDocument xDoc = StringPlus.ConvertStringToXmlDocument(param);
            XmlNodeList xnList = xDoc.SelectNodes("//Response//Head");
            string flag = "";
            if (xnList.Count > 0)
            {
                XmlNode xn = xnList.Item(0);
                flag=xn.InnerText;
            }
            if (flag == "OK")
            {
               Response.Write(ResponseResult());
            }
            else
            {
                lblMsg.Text = param;
            }
        }

        public static string ResponseResult()
        {
            return "<Response service='RouteService'><Head>OK</Head><Body><RouteResponse mailno='444003077898'><Route accept_time='2015-01-04 10:11:26' accept_address='深圳' remark='已收件' opcode='50'/><Route accept_time='2015-01-05 17:41:50' remark='此件签单返还的单号为 123638813180' opcode='922'/><RouteResponse mailno='444003077899'><Route accept_time='2015-01-04 10:11:26' accept_address='深圳' remark='已收件' opcode='50'/><Route accept_time='2015-01-05 17:41:50' remark='此件签单返还的单号为 123638813181' opcode='922'/></RouteResponse></Body><Response>";
        }
    }
}