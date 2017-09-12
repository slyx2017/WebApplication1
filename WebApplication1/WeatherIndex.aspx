<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherIndex.aspx.cs" Inherits="WebApplication1.WeatherIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblWeather" runat="server" Text=""><br /></asp:Label><asp:Button ID="btnWeather" runat="server" Text="调用" OnClick="btnWeather_Click" /><br />
        <asp:DropDownList ID="ddl_province" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_province_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:DropDownList ID="ddl_city" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_city_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
