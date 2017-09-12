using JTC.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.XPath;

namespace WebApplication1.Ashx
{
    /// <summary>
    /// comboboxData 的摘要说明
    /// </summary>
    public class comboboxData : IHttpHandler
    {
        HttpContext _context;
        string pathfile = "";
        public void ProcessRequest(HttpContext context)
        {
            _context = context;
            string param = context.Request.Params["options"];
            switch (param)
            {
                case "Add":
                    ComboBoxAddData(_context);
                    break;
                case"list":
                    ComboBoxJsonData(_context);
                    break;
                default:
                    break;
            }
        }
        #region 初始化加载数据
        //初始化Combobox
        private void ComboBoxJsonData(HttpContext _context)
        {
            XmlDocument xmlDoc = new XmlDocument();
            pathfile = _context.Server.MapPath("\\Auto\\autodata.xml");
            xmlDoc.Load(pathfile);
            XPathDocument pathdoc = new XPathDocument(pathfile);
            //获取根节点  
            XmlNode root = xmlDoc.SelectSingleNode("Users");
            XmlNodeOrder(xmlDoc, pathdoc, root);

            if (root.HasChildNodes)
            {
                string json = XmlToJson(root);
                _context.Response.Write(json);
            }
        }
        //把xml节点中按属性Count大小倒序排序
        private void XmlNodeOrder(XmlDocument xmlDoc, XPathDocument pathdoc, XmlNode root)
        {
            XPathNavigator nav = pathdoc.CreateNavigator();
            string xpath = String.Format("/Users/User");
            XPathExpression exp = nav.Compile(xpath);
            exp.AddSort("@Count", XmlSortOrder.Descending, XmlCaseOrder.None, "", XmlDataType.Text);
            XPathNodeIterator nodeIter = nav.Select(exp);

            root.RemoveAll();

            while (nodeIter.MoveNext())
            {
                XmlElement xe = xmlDoc.CreateElement("User");
                xe.SetAttribute("Name", nodeIter.Current.GetAttribute("Name", ""));
                xe.SetAttribute("Count", nodeIter.Current.GetAttribute("Count", ""));
                root.AppendChild(xe);
            }
            xmlDoc.Save(pathfile);
        }

        //xml数据转成json
        private static string XmlToJson(XmlNode root)
        {
            var json = "[";
            XmlNodeList xnlist = root.ChildNodes;

            int i = 1;
            foreach (XmlNode item in xnlist)
            {
                if (i <= 10)//获取top 10 条
                {
                    json += "{\"id\":\"" + item.Attributes["Name"].Value + "\",\"text\":\"" + item.Attributes["Name"].Value + "\"},";
                    i++;
                }
                else
                {
                    break;
                }
            }
            if (json.EndsWith(","))
            {
                json = json.Substring(0, json.Length - 1);
            }
            json = json + "]";
            return json;
        }
        #endregion

        #region 插入数据到xml
        //插入
        private void ComboBoxAddData(HttpContext _context)
        {
            AjaxMsgModel ajaxMsg = new AjaxMsgModel() { Statu = "error", Msg = "失败" };
            string name = _context.Request.Params["language"];
            XmlDocument xmlDoc = new XmlDocument();
            pathfile = _context.Server.MapPath("\\Auto\\autodata.xml");

            xmlDoc.Load(pathfile);

            //获取根节点  
            XmlNode root = xmlDoc.SelectSingleNode("Users");
            Dictionary<string, string> dicAttr = new Dictionary<string, string>();
            if (root.HasChildNodes)
            {
                int count = 0;
                int nodecount = root.ChildNodes.Count;
                int i = 0;
                foreach (XmlNode item in root.ChildNodes)
                {
                    if (item.Attributes["Name"].Value == name)
                    {
                        count = int.Parse(item.Attributes["Count"].Value);
                        count += 1;
                        dicAttr.Add("Name", name);
                        dicAttr.Add("Count", count.ToString());
                        root.RemoveChild(item);
                        break;
                    }
                    else
                    {
                        i++;
                        if (i == nodecount)
                        {
                            dicAttr.Add("Name", name);
                            dicAttr.Add("Count", "1");
                            break;
                        }
                    }
                }
            }
            else
            {
                dicAttr.Add("Name", name);
                dicAttr.Add("Count", "1");
            }
            CreateNode(xmlDoc, root, "User", dicAttr);
            xmlDoc.Save(pathfile);
            ajaxMsg.Statu = "ok";
            ajaxMsg.Msg = "成功";
            ajaxMsg.Data = "";
            string jsonstr = Newtonsoft.Json.JsonConvert.SerializeObject(ajaxMsg);
            _context.Response.Write(jsonstr);
        }

        /// <summary>    
        /// 创建节点及属性值    
        /// </summary>    
        /// <param name="xmldoc"></param>  xml文档  
        /// <param name="parentnode"></param>父节点    
        /// <param name="name"></param>  节点名  
        /// <param name="value"></param>  属性名
        /// <param name="value"></param>  属性值  
        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string nodeName, Dictionary<string, string> dicList)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, nodeName, null);
            parentNode.AppendChild(node);
            foreach (var item in dicList)
            {
                XmlAttribute xa = xmlDoc.CreateAttribute(item.Key);
                xa.Value = item.Value;
                node.Attributes.Append(xa);
            }

        }

        #endregion

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}