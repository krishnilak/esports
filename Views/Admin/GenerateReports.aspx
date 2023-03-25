<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateReports.aspx.cs" Inherits="WebApplication3.Views.Admin.GenerateReports" %>

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
                <h3>Reports</h3>
            </div>
        </div>
        <div>
            <form id="form2" runat="server">
                <div>
                    <div class="row">
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/tr3.jpg" class="card-img-top" height="300" />
                                <div class="card-body">
                                    <asp:Button Text="Generate Tropies Reports" runat="server" class="btn-primary" OnClick="trophyReportClick" />
                                </div>
                            </div>
                        </div>
                        <div class="col">
                            <div class="card" style="width: 18rem; background-color: lightblue;">
                                <img src="../../Assets/images/teams.png" class="card-img-top" height="300" />
                                <div class="card-body">
                                    <asp:Button Text="Generate Teams Reports" runat="server" class="btn-primary" OnClick="teamReportClick" />
                                </div>
                            </div>
                            </div>
                            <div class="col">
                                <div class="card" style="width: 18rem; background-color: lightblue;">
                                    <img src="../../Assets/images/player2.png" class="card-img-top" height="300" />
                                    <div class="card-body" id="btn_players">
                                        <asp:Button Text="Generate Players Reports" runat="server" class="btn-primary" OnClick="playerReportClick" />
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
