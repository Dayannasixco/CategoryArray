<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="from2.aspx.cs" Inherits="Array4976088.from2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <br />
            <asp:Label ID="Label1" runat="server" Text="Create Category Array"></asp:Label>
            <br />
            <asp:TextBox ID="txtIndex" runat="server" Width="147px"></asp:TextBox>
            <br />
            <asp:Button ID="btnLookup" runat="server" Onclick="BtnCreateArray_Click" Text="Lookup" Width="85px" />

            <asp:Label ID="lblCategory" runat="server" Text="Raquets"></asp:Label>

        </div>
    </form>
</body>
</html>
