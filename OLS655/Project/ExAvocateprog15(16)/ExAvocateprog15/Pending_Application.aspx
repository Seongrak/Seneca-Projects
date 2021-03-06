﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pending_Application.aspx.cs" Inherits="ExAvocateprog15.Pending_Application" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 413px;
        }
        .auto-style3 {
            width: 413px;
            height: 11px;
        }
        .auto-style4 {
            height: 11px;
        }
        .hiddencol { 
            display: none; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">First Name:</td>
                <td class="auto-style4">
                    <asp:Label ID="lb_Firstname" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name:</td>
                <td>
                    <asp:Label ID="lb_Lastname" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">No. of Pending Application</td>
                <td>
                    <asp:Label ID="lb_pApp" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
 
                    <asp:GridView ID="GrdV_App" runat="server" OnRowCommand="GrdV_App_RowCommand" Width="561px" AutoGenerateColumns="False" OnSelectedIndexChanged="GrdV_App_SelectedIndexChanged">
                        <Columns>
                            <asp:ButtonField CommandName="Withdraw" Text="Withdraw" ButtonType="Button" />
                            <asp:BoundField DataField="ExAvId" HeaderText="ExID"  ItemStyle-CssClass="hiddencol" HeaderStyle-CssClass="hiddencol"/>
                            <asp:BoundField DataField="Description" HeaderText="Description" />
                            <asp:BoundField DataField="MaximumApplicants" HeaderText="Month" />
                            <asp:ButtonField CommandName="Withdraw" Text="Withdraw" ButtonType="Button" />
                            
                        </Columns>
                    </asp:GridView>
                    <asp:Label ID="label_Error" runat="server" style="color: #FF0000"  Text="Sorry No Training Application Available!!"  Visible="False"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:Button ID="App_btn" runat="server" Text="Application Page" OnClick="App_btn_Click" />
        </p>
        <p>
            <asp:Button ID="logout_btn" runat="server" Text="Logout" OnClick="logout_btn_Click" />
        </p>
    </form>
</body>
</html>
