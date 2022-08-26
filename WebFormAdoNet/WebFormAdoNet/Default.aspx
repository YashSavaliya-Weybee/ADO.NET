<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 86px;
        }

        .auto-style3 {
            width: 13px;
        }

        .auto-style4 {
            width: 86px;
            height: 26px;
        }

        .auto-style5 {
            width: 13px;
            height: 26px;
        }

        .auto-style6 {
            height: 26px;
        }

        .auto-style7 {
            height: 23px;
        }
    </style>
    
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">ID</td>
                    <td class="auto-style3">:</td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name</td>
                    <td class="auto-style3">:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style3">:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">JoinDate</td>
                    <td class="auto-style5">:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtJoinDate" runat="server"></asp:TextBox>&nbsp;
                        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            Enter ID :&nbsp;
            <asp:TextBox ID="txtIDToDelete" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdateID" runat="server" Text="Update Data" OnClick="btnUpdateID_Click" />
            <br />
        </div>
        <div>
            <asp:Label ID="lblMessage" runat="server" EnableViewState="False"></asp:Label>
        </div>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblIDLeft" runat="server" EnableViewState="False"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lblIDRight" runat="server" EnableViewState="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNameLeft" runat="server" EnableViewState="False"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblNameRight" runat="server" EnableViewState="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmailLeft" runat="server" EnableViewState="False"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblEmailRight" runat="server" EnableViewState="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblJoinDateLeft" runat="server" EnableViewState="False"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblJoinDateRight" runat="server" EnableViewState="False"></asp:Label>
                </td>
            </tr>
        </table>
    </form>

    <script type="text/javascript">
        $(document).ready(function () {
            $(function () {
                $("#txtJoinDate").datepicker({ dateFormat: 'yy-mm-dd' });
            });
        });
    </script>
</body>
</html>
