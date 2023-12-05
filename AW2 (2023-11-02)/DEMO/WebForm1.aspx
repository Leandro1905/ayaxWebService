<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DEMO.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>SIN AJAX</h1>
            DNI<br />
            <asp:TextBox ID="TxtDni" runat="server"></asp:TextBox>
            <br />
            <br />
            NOMBRE<br />
            <asp:Label ID="LblNombre" runat="server"></asp:Label>
            <br />
            <br />
            SEXO<br />
            <asp:Label ID="LblSexo" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="BUSCAR" Width="127px" />
        </div>
    </form>
</body>
</html>
