<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagePlayes.aspx.cs" Inherits="WebApplication3.Views.Admin.ManagePlayes" %>

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
            <h3>Manage Players</h3>
        </div>
        <div>
            <form id="form1" runat="server">
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label">Player ID </label>
                            <asp:TextBox ID="pid" runat="server" class="form-control"></asp:TextBox>
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
                        <div class="mt-3 d-grid">
                            <div class="row">
                                <div class="col">
                                    <asp:Button Text="Add Player" runat="server" class="btn-primary" OnClick="addPlayerClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="Delete Player" runat="server" class="btn-danger" OnClick="deletePlayerClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="Set Base Price" runat="server" class="btn-warning" OnClick="setBasePriceClick" />
                                </div>
                            </div>
                            <div class="row" style="height: 10px"></div>
                            <div class="row">
                                <div class="col">
                                    <asp:Button Text="Set Status" runat="server" class="btn-warning" OnClick="setStatusClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="View Player Details" runat="server" class="btn-success" OnClick="viewPlayerDetailsClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="Update Player" runat="server" class="btn-warning" OnClick="updatePlayerClick" />
                                </div>
                            </div>
                        </div>
                    </div>
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
