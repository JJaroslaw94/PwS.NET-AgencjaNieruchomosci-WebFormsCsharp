<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Poszukiwanie.aspx.cs" Inherits="WebApplication1.Poszukiwanie" %>

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

                <div class="KontenerDomLabel2">  
                    <div class="DystansPionowy2">
                        Minimalna cena: 
                    </div>                    
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList>
                </div>
                <br />
                
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="KontenerDomLabel2">
                    <div class="DystansPionowy2">
                        Maksymalna cena: 
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True"></asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <br />

                <div class="KontenerDomLabel2">
                    <div class="DystansPionowy2">
                    Łazienki: 
                        </div>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True"></asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <br />

                <div class="KontenerDomLabel2">
                    <div class="DystansPionowy2">
                    Sypialnie: 
                        </div>
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True"></asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <br /> 

                <div class="KontenerDomLabel2">
                    <div class="DystansPionowy2">
                    Okręg: 
                        </div>
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True"></asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <br />
                <br />
                <br />
                <br />

                <div class="KontenerDomLabel2">
                    <div class="DystansPionowy2">
                    Sortować po: 
                        </div>
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True"></asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                        
                <br />
                <div>
                    <asp:Button ID="ButtonPosz1" runat="server" Text="Wróć" OnClick="ButtonPosz1_Click" />
                    <asp:Button ID="ButtonPosz2" runat="server" Text="Szukaj" OnClick="ButtonPosz2_Click" />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
