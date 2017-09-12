<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 319px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;height:100%">
            <tr>
                <td class="auto-style1">
                    <asp:Panel ID="Panel1" runat="server" Width="303px">
                        <table style="width:99%;">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Choose  a Background Image "></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="205px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="Panel2" runat="server" Width="524px">
                    </asp:Panel>
                </td>
                <td>&nbsp;</td>
            </tr>
         </table>
    
    </div>
    </form>
</body>
</html>
