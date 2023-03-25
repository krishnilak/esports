<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayerDashboard.aspx.cs" Inherits="WebApplication3.Views.Player.PlayerDashboard" %>

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
                <h3>Player Dashboard</h3>
            </div>
        </div>
        <div>
            <form id="form1" runat="server">
                <div>
                    <div class="row">
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/profile.jfif" class="card-img-top" height="300">
                                <div class="card-body">
                                    <h5 class="card-title">Profile</h5>
                                    <a href="#" class="btn btn-primary">Manage My Profile</a>
                                </div>
                            </div>
                        </div>
                         <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/player2.png" class="card-img-top" height="300">
                                <div class="card-body">
                                    <h5 class="card-title">Players</h5>
                                    <p class="card-text">View player details</p>
                                    <a href="#" class="btn btn-primary">View Players</a>
                                </div>
                            </div>
                        </div>
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/teams.png" class="card-img-top" height="300">
                                <div class="card-body">
                                    <h5 class="card-title">Teams</h5>
                                    <p class="card-text">View team status</p>
                                    <a href="#" class="btn btn-primary">Team Status</a>
                                </div>
                            </div>
                        </div>
                       
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/tr3.jpg" class="card-img-top" height="300">
                                <div class="card-body">
                                    <h5 class="card-title">Tropies</h5>
                                    <a href="#" class="btn btn-primary">View Tropies and Register</a>
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
