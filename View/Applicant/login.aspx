<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HrManagement.View.Applicant.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        body {
            margin:0 auto;
            padding:0px;
            background-color: aqua;
            background-image: url("../../Contants/img/11.jpg");
        }

        .page {
            width: 100%;
            height: 100%;
        }

        .login{
            width: 400px;
            margin: 0 auto;
            margin-top: 0px;
            height: 200px;
            background:;
            background-color: white;
            border:;
            border-radius: 8px;
            margin-top: 208px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <div class="login">
                <table style="width: 100%;">
                    <tr>
                        <td style="padding: 20px;">CNIC</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                        </td>

                    </tr>
                    <tr>
                        <td  style="padding: 20px;">PASSWORD</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                        </td>

                    </tr>
                    <tr>
                        <td style="padding-top:20px; padding-left:20px">
                            <asp:Button ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" />

                        </td>

                    </tr>

                </table>

            </div>
        </div>

    </form>
</body>
</html>
