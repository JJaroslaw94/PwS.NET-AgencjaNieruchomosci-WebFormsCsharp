<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dom.aspx.cs" Inherits="WebApplication1.Dom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/Css1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="CentrowanieStrony">
            <div class="LewaStronaZObrazkiem" style="background-image: url('IMG/budynki.png'); background-repeat: repeat-y">
                
            </div>
            <div class="NaglowekStrony">
                <h1 id="NaglowekStronyDomu" runat="server">Dom - bląd</h1>
            </div>
            <div class ="SeparatorNaglowka"></div>
            <div class="TrescStrony">
                <div class="KontenerDomLabel2">
                <asp:Label ID="Label1" class="CentrowanieLewa" runat="server" Text="Label"></asp:Label>
                <div class="DystansPionowy"></div>
                <asp:Label ID="Label7" class="CentrowaniePrawa" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                <div class="KontenerDomLabel2">
                <asp:Label ID="Label2" class="CentrowanieLewa" runat="server" Text="Label"></asp:Label>
                <div class="DystansPionowy"></div>
                <asp:Label ID="Label8" class="CentrowaniePrawa" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                <div class="KontenerDomLabel2">
                <asp:Label ID="Label3" class="CentrowanieLewa" runat="server" Text="Label"></asp:Label>
                <div class="DystansPionowy"></div>
                <asp:Label ID="Label9" class="CentrowaniePrawa" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                <div class="KontenerDomLabel2">
                <asp:Label ID="Label4" class="CentrowanieLewa" runat="server" Text="Label"></asp:Label>
                <div class="DystansPionowy"></div>
                <asp:Label ID="Label10" class="CentrowaniePrawa" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                <div class="KontenerDomLabel2">
                <asp:Label ID="Label5" class="CentrowanieLewa" runat="server" Text="Label"></asp:Label>
                <div class="DystansPionowy"></div>
                <asp:Label ID="Label11" class="CentrowaniePrawa" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                <div class="KontenerDomLabel2">
                <asp:Label ID="Label6" class="CentrowanieLewa" runat="server" Text="Label"></asp:Label>
                <div class="DystansPionowy"></div>
                <asp:Label ID="Label12" class="CentrowaniePrawa" runat="server" Text="Label"></asp:Label>
                </div>    
                <br />
                <div class="KontenerDomLabel2">
                    <asp:Label ID="Label13" class="CentrowaniePrawa" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
