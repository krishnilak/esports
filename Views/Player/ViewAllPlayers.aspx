<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllPlayers.aspx.cs" Inherits="WebApplication3.Views.Player.ViewAllPlayers" %>

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
            <h3>View Players</h3>
        </div>
        <div>
            <form id="form1" runat="server">
                <div class="row">
                 
                    <div class="col">
                        <div class="col-md-8">
                            <asp:GridView ID="players_tbl" runat="server" />
                        </div>
                        <div style="height: 90px;"></div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
