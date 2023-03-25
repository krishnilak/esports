<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Lib/css/bootstrap.min.css"/>
</head>
<body>
    <div class="container-fluid">
        <div class="row mt-5 mb-5">

        </div>
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <form id="form1" runat="server">
                    <div class="row"></div>
                    <div>
                        <image src="../Assets/images/Member-Login-Button.png" />
                    </div>
                    <div class="row"></div>
                    
                    <div class="mt-3">
                        <label for="" class="form-label">  User Name </label>    
                        <input type="text" placeholder="User Name" autocomplete="off" class="form-control" id="usernameTxt" name="UserName" />

                    </div>

                     <div class="mt-3">
                        <label for="" class="form-label">  Password </label>
                        <input type="text" placeholder="Password" autocomplete="off" class="form-control" id="passwordTxt" name="Password" />

                    </div>
                    <div class="mt-3 d-grid">
                        <asp:Button Text="Login" runat="server" class="btn-primary" OnClick="Unnamed1_Click" BorderColor="#666699" />
                    </div>

                </form>
            </div>
            <div class="col"></div>
        </div>
    </div>
    
</body>
</html>
