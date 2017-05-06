<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="txtUsuarirutoa" runat="server"></asp:TextBox>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <asp:BulletedList ID="listaUsuarios" runat="server"></asp:BulletedList>
    </div>
    </form>
</body>
</html>
