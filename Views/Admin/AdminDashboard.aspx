<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="WebApplication3.Views.Admin.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../../Assets/Lib/css/bootstrap.min.css" />
</head>
<body>
    <div>
        <div class="container-fluid">
            <div class="row mt-5 mb-5">
                <div style="height: 60px; background-color: darkblue">
                </div>
                <div style="height: 30px"></div>
                <div style="background-color: darkblue; font-palette: light"></div>
                <h3>Administrator Dashboard</h3>
            </div>
        </div>
        <div>
            <form id="form1" runat="server">
                <div>
                    <div class="row">
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/tr3.jpg" class="card-img-top" height="300">
                                <div class="card-body">
                                    <h5 class="card-title">Tropies</h5>
                                    <asp:Button Text="Manage Tropies" runat="server" class="btn-primary" OnClick="btn_tropies" />
                                </div>
                            </div>
                        </div>
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/teams.png" class="card-img-top" height="300">
                                <div class="card-body">
                                    <h5 class="card-title">Teams</h5>
                                    <p class="card-text">Team Maxium price can be set by the administrator</p>
                                    <asp:Button Text="Manage Teams" runat="server" class="btn-primary" OnClick="btn_teams" />                                </div>
                            </div>
                        </div>
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/player2.png" class="card-img-top" height="300">
                                <div class="card-body" id="btn_players">
                                    <h5 class="card-title">Players</h5>
                                    <p class="card-text">Player base price can be set by the administrator<p>
                                         <asp:Button Text="Manage Players" runat="server" class="btn-primary" OnClick="btn_players" />   
                                </div>
                            </div>
                        </div>
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/reports.jpg" class="card-img-top" height="300">
                                <div class="card-body">
                                    <h5 class="card-title">Reports</h5>
                                     <asp:Button Text="Generate Reports" runat="server" class="btn-primary" OnClick="btn_reports" />      
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
