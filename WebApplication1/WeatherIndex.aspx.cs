using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.cn.com.webxml.ws;

namespace WebApplication1
{
    public partial class WeatherIndex : System.Web.UI.Page
    {
        WeatherWS wwsi = new WeatherWS();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataSet ds_pro = new DataSet();
                ds_pro = wwsi.getRegionDataset();
                ddl_province.DataSource = ds_pro;
                ddl_province.DataValueField = "RegionID";
                ddl_province.DataTextField = "RegionName";
                ddl_province.DataBind();
                ddl_province.Items.Insert(0, new ListItem("--请选择--", ""));
            }

        }

        protected void btnWeather_Click(object sender, EventArgs e)
        {
            
           // ds=wwsi.getSupportCityDataset(ccode);
        }

        protected void ddl_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds_city = new DataSet();
            string citycode= ddl_province.SelectedValue;
            ddl_province.Items.FindByValue(citycode).Selected = true;
            ds_city = wwsi.getSupportCityDataset(citycode);
            ddl_city.DataSource = ds_city;
            ddl_city.DataValueField = "CityID";
            ddl_city.DataTextField = "CityName";
            ddl_city.DataBind();
        }

        protected void ddl_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ccode = ddl_city.SelectedValue;
            //ddl_city.Items.FindByValue(ccode).Selected = true;
            string whtml = "<table>";
            string[] weathers = wwsi.getWeather(ccode,"");
            for(int item=0;item< weathers.Length;item++)
            {
                if (weathers[item].Contains(".gif"))
                {
                    whtml += "<tr><td><img src='image/weather/" + weathers[item] + "'/></td></tr>";
                }
                else
                {
                    if (item == 2)
                        whtml += "<tr><td><img src='image/1/" + weathers[item] + ".jpg'/></td></tr>";
                    else
                        whtml += "<tr><td>" + weathers[item] + "</td></tr>";
                }
                
            }
            whtml += "</table>";
            Response.Write(whtml);
        }
    }
}