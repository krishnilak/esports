<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="WebApplication3.Views.Player.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../../Assets/Lib/css/bootstrap.min.css" />
</head>
<body>
    <div class="container-fluid">
        <div class="row mt-5 mb-5">
            <div style="height: 60px; background-color: darkblue">
            </div>
            <div style="height: 30px"></div>
            <div style="background-color: darkblue; font-palette: light"></div>
            <h3>My Profile</h3>
        </div>
        <div>
            <form id="form1" runat="server">
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label">Player ID </label>
                           <asp:Label ID="pid" runat="server" class="form-control"></asp:Label>
                                   </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Player Name </label>
                            <asp:TextBox ID="pname" runat="server" class="form-control" name="playerName"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Mobile Number </label>
                            <asp:TextBox ID="pmobile" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Email Address </label>
                            <asp:TextBox ID="pemail" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Status </label>
                            <asp:TextBox ID="pstatus" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Base Price </label>
                            <asp:TextBox ID="pbaseprice" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                 
                </div>
            </form>
        </div>
    </div>
</body>
</html>
