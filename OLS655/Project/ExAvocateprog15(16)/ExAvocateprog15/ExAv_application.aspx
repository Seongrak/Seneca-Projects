<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExAv_application.aspx.cs" Inherits="ExAvocateprog15.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 375px;
        }
        .auto-style3 {
            width: 375px;
            height: 24px;
        }
        .auto-style4 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">First Name: </td>
                <td>
                    <asp:Label ID="lbFirst" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Last Name: </td>
                <td class="auto-style4">
                    <asp:Label ID="lbLast" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Number of Pending Applications:</td>
                <td>
                    <asp:Label ID="lbNum" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlMonth" runat="server" OnSelectedIndexChanged="ddlMonth_SelectedIndexChanged">
                        <asp:ListItem Value="1">January</asp:ListItem>
                        <asp:ListItem Value="2">Feburary</asp:ListItem>
                        <asp:ListItem Value="3">March</asp:ListItem>
                        <asp:ListItem Value="4">April</asp:ListItem>
                        <asp:ListItem Value="5">May</asp:ListItem>
                        <asp:ListItem Value="6">June</asp:ListItem>
                        <asp:ListItem Value="7">July</asp:ListItem>
                        <asp:ListItem Value="8">August</asp:ListItem>
                        <asp:ListItem Value="9">September</asp:ListItem>
                        <asp:ListItem Value="10">October</asp:ListItem>
                        <asp:ListItem Value="11">November</asp:ListItem>
                        <asp:ListItem Value="12">December</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:GridView ID="GvEx" runat="server" OnRowCommand="GvEx_RowCommand" Width="561px" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="ExAvId" HeaderText="ExID" />
                            <asp:BoundField DataField="Description" HeaderText="Description" />
                            <asp:BoundField DataField="MaximumApplicants" HeaderText="MaxNum" />
                            <asp:ButtonField CommandName="Apply" Text="Apply" ButtonType="Button" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="lbError" runat="server" Text="It is not available!!" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="btnPending" runat="server" Text="Return to Pending Applications" OnClick ="btn_pending_Click"/>
    </form>
</body>
</html>
