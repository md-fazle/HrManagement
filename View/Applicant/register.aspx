<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="HrManagement.View.Applicant.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () { 
            $("#calbtn").click(function () {
                $("#Calendar2").toggle();
            });
        });
    </script>

    <title>Sign Up</title>

    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <style>
        body {
            margin: 0 auto;
            padding: 0px;
            background-image: url("../../Contants/img/11.jpg");
            background-repeat: no-repeat;
            background-size: 1960px 960px;
        }

        #wrapper {
        }

        #form {
            width: auto;
        }

        #pannelid {
            height: auto;
            margin: 0 auto;
        }

        #Calendar1 {
            display: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div id="wrapper" class="col-lg-12">



            <div id="center-form" style="width: 50%; height: auto; background-color: #00ffff; margin: 0 auto;">




                <div id="wholepannel" class="panel panel-primary col-md-12">
                    <div class="panel-heading" style="text-align: center; font-size: 125%">Registration Form</div>
                    <div class="panel-body" id="pannelid" style="margin: 0 auto;">

                        <div id="form">
                            <%--form code--%>

                            <legend>Login Information</legend>

                            <div class="form-group">

                                <label for="usr">CNIC:</label>
                                <asp:TextBox ID="txtcnic" runat="server" Class="form-control" required="required"></asp:TextBox>


                            </div>


                            <div class="form-group">
                                <label for="usr">Password</label>
                                <asp:TextBox ID="txtpassword" runat="server" Class="form-control" TextMode="Password" required="required"></asp:TextBox>

                            </div>
                            <div class="form-group">
                                <label for="usr">Confirm Password</label>
                                <asp:TextBox ID="txtcpassword" runat="server" Class="form-control" TextMode="Password" required="required"></asp:TextBox>

                                <p id="errorprint" style="color: red; font-weight: bold;"></p>
                            </div>

                        </div>







                        <fieldset>
                            <legend>Personal Information</legend>


                            <div class="form-group">
                                <label for="usr">Name:</label>
                                <asp:TextBox ID="txtusername" runat="server" Class="form-control" required="required"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="pwd">Contact:</label>
                                <asp:TextBox ID="txtcontact" runat="server" Class="form-control" required="required"></asp:TextBox>
                            </div>


                            <div class="form-group">
                                <label for="pwd">Email ID:</label>
                                <asp:TextBox ID="txtemailid" runat="server" Class="form-control" required="required"></asp:TextBox>
                            </div>



                            <div class="form-group">
                                <label for="pwd">Upload Image</label>

                                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />

                            </div>

                            <div class="form-group">
                                <label for="pwd">Date Of Birth</label>
                                 
                                <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#999999" />
                                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                    <TodayDayStyle BackColor="#CCCCCC" />
                                </asp:Calendar>
                                <span>
                                    <img style="width: 20px; height: 20px" id="calbtn" src="../../Contants/img/Calendar-icon.png" />
                                </span>
                            </div>


                            <div class="form-group">
                                <label for="pwd">Gender</label>

                                <asp:RadioButton ID="txtMale" GroupName="gender" runat="server" Checked="true" Text="Male" />
                                <asp:RadioButton ID="txtFemale" GroupName="gender" runat="server" Text="Female" />

                            </div>



                            <div class="form-group">
                                <asp:Button ID="Button1" runat="server" Text="NEXT->" Class="btn btn-success" OnClick="Button1_Click" OnClientClick="return passwordmatchfunc()" />

                            </div>


                        </fieldset>







                    </div>
                    <%--pannel content--%>
                </div>

                <%--form code--%>
            </div>

        </div>
        <%--wrapper end--%>
    </form>
</body>
</html>

