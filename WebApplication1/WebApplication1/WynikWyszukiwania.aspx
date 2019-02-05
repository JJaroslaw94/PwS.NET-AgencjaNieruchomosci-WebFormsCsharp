<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WynikWyszukiwania.aspx.cs" Inherits="WebApplication1.WynikWyszukiwania" %>

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

                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                <br />
                
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText ="Index">
                                <ItemTemplate >
                                    <asp:LinkButton ID="WybranyPracownik" Text=<%# Eval("HLCN") %> runat="server" CommandArgument='<%# Eval("LISTING_ID") %>' OnClick="WybranyPracownik_Click" /> 
                                </ItemTemplate>
                            </asp:TemplateField>
                        <asp:BoundField DataField="HOUSE_PRICE" HeaderText="Cena" />
                        <asp:BoundField DataField="BATHROOMS" HeaderText="Łazienki" />
                        <asp:BoundField DataField="BEDROOMS" HeaderText="Sypialnie" />                            
                    </Columns>                   
                </asp:GridView>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Wróć" OnClick="Button1_Click" />

            </div>
        </div>
    </form>
</body>
</html>
