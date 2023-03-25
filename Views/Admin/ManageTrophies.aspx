<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageTrophies.aspx.cs" Inherits="WebApplication3.Views.Admin.ManageTrophies" %>

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
            <h3>Manage Tropies</h3>
        </div>
        <div>
            <form id="form1" runat="server">
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label">Trophy ID </label>
                            <asp:TextBox ID="trid" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Trophy Name </label>
                            <asp:TextBox ID="trname" runat="server" class="form-control" name="playerName"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Venue</label>
                            <asp:TextBox ID="trvenue" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">No Of Teams</label>
                            <asp:TextBox ID="trno" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="mt-3">
                            <label for="" class="form-label">Date</label>
                            <asp:TextBox ID="trdate" runat="server" class="form-control"></asp:TextBox>
                        </div>

                        <div class="mt-3 d-grid">
                            <div class="row">
                                <div class="col">
                                    <asp:Button Text="Add Trophy" runat="server" class="btn-primary" OnClick="addTrophyClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="Delete Trophy" runat="server" class="btn-danger" OnClick="deleteTrophyClick" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="View Trophy Details" runat="server" class="btn-success" OnClick="viewTrophyDetailsClick" />
                                </div>
                            </div>
                            <div class="row" style="height: 10px"></div>
                            <div class="row">
                                <div class="col">
                                    <asp:Button Text="Update Trophy" runat="server" class="btn-warning" OnClick="updateTrophyClick" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="col-md-8">
                            <asp:GridView ID="trophy_tbl" runat="server" />
                        </div>
                        <div style="height: 90px;"></div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
