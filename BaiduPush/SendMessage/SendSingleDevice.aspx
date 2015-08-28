<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendSingleDevice.aspx.cs" Inherits="BaiduPush.SendMessage.SendSingleDevice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnSend" runat="server" Text="发送测试" OnClick="btnSend_Click" />
        </div>
    </form>
</body>
</html>
