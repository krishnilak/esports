<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageTeams.aspx.cs" Inherits="WebApplication3.Views.Admin.ManageTeams" %>

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
            <h3>Manage Teams</h3>
        </div>
        <div>
            <form id="form1" runat="server">
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label">Team ID </label>
                            <asp:TextBox ID="tid" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Team Name </label>
                            <asp:TextBox ID="tname" runat="server" class="form-control" name="playerName"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Team Owner ID</label>
                            <asp:TextBox ID="townerid" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Email Address </label>
                            <asp:TextBox ID="temail" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">MaxPrice</label>
                            <asp:TextBox ID="tmaxprice" runat="server" class="form-control"></asp:TextBox>
                        </div>
                       
                        <div class="mt-3 d-grid">
                            <div class="row">
                                <div class="col">
                                    <asp:Button Text="Add Team" runat="server" class="btn-primary" OnClick="addTeamClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="Delete Team" runat="server" class="btn-danger" OnClick="deleteTeamClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="Set Max Price" runat="server" class="btn-warning" OnClick="setMaxPriceClick" />
                                </div>
                            </div>
                            <div class="row" style="height: 10px"></div>
                            <div class="row">
                                <div class="col">
                                    <asp:Button Text="View Team Details" runat="server" class="btn-success" OnClick="viewTeamDetailsClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="Update Team" runat="server" class="btn-warning" OnClick="updateTeamClick" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="col-md-8">
                            <asp:GridView ID="team_tbl" runat="server" />
                        </div>
                        <div style="height: 90px;"></div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>


