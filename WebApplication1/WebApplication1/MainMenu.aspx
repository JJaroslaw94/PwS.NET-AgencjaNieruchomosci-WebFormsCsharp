<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="WebApplication1.MainMenu" %>

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
                <h1>Nieruchomości</h1>
            </div>
            <div class ="SeparatorNaglowka"></div>
            <div class="TrescStrony">
                <br />
                <br />
                <asp:LinkButton ID="LinkButtonMMdoPrzeszukiwania" runat="server" OnClick="LinkButtonMMdoPrzeszukiwania_Click">Przejście do przeszukiwania ofert </asp:LinkButton>
                <br />
                <br />
                Wpisz znany ci indeks nieruchomości poniżej i kliknij dalej               
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Dalej" OnClick="Button1_Click" />
            </div>
        </div>
        <div class="custompopup" id="divThankYou" runat="server">
        <p>
            <asp:Label ID="lblmessage" runat="server"></asp:Label>
        </p>
        <asp:Button ID="ButtonPopUp" CssClass="classname leftpadding" runat="server" Text="Ok" OnClick="ButtonPopUp_Click1" />
    </div>
        <div class="custompopup" id="divFailAut1" runat="server">
        <p>
            <asp:Label ID="Labelfailaut1" runat="server"></asp:Label>
        </p>
        <asp:Button ID="Button2" CssClass="classname leftpadding" runat="server" Text="Ok" OnClick="ButtonPopUp_Click2" />
    </div>
    </form>
</body>
</html>
