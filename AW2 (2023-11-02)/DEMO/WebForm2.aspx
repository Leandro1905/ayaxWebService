<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DEMO.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <h1>CON AJAX</h1>
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
                    <br />
                    <br />
                    <asp:Label ID="LblMensaje" runat="server"></asp:Label>
                 </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
