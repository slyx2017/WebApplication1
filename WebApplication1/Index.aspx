<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:TextBox ID="txtTrackNumber" runat="server"></asp:TextBox>
        <asp:Button ID="btnTacking" runat="server" Text="调用" OnClick="btnTacking_Click" /><br />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
