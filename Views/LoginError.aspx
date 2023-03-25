<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginError.aspx.cs" Inherits="WebApplication3.Views.LoginError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Invalid Credentials
    </title>
    <link rel="stylesheet" href="../Assets/Lib/css/bootstrap.min.css" />
</head>
<body>
    <div class="container-fluid">
        <div class="row mt-5 mb-5">
        </div>
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <form id="form1" runat="server">
                    <div>
                        <div style="text-align: center">
                            <h5>Invalid Username or Password</h5>
                        </div>
                        <div height="120"></div>
                        <div style="align-content: center">
                            <img src="../Assets/images/invalidUser.jpg" height="450" />
                        </div>
                        <div height="120"></div>
                        <div class="mt-3 d-grid">
                            <asp:Button Text="Proceed to Login" runat="server" class="btn-primary" BorderColor="#666699" OnClick="Unnamed1_Click" />
                        </div>
                    </div>
                </form>
            </div>
            <div class="col"></div>
        </div>
    </div>
</body>
</html>
