﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="BCM.WebFormsApplication.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead">
        <h1>Shopping Cart</h1>
    </div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="BCM.Model.CartItem" SelectMethod="GetShoppingCartItems"
        CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="Book.ID" HeaderText="ID" SortExpression="Book.ID" />
            <asp:BoundField DataField="Book.Title" HeaderText="Title" />
            <asp:BoundField DataField="Book.ListPrice" HeaderText="Price (each)" DataFormatString="{0:C}" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Item Total">
                <ItemTemplate>
                    <%#: String.Format("{0:C}", ((Convert.ToDouble(Item.Quantity)) *  Convert.ToDouble(Item.Book.ListPrice)))%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Remove Item">
                <ItemTemplate>
                    <asp:CheckBox ID="Remove" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Order Total: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <br />
    <table>
        <tr>
            <td>
                <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
            </td>
            <td>
                <asp:ImageButton ID="CheckoutImageBtn" runat="server"
                    ImageUrl="https://www.paypal.com/en_US/i/btn/btn_xpressCheckout.gif"
                    Width="145" AlternateText="Check out with PayPal"
                    OnClick="CheckoutBtn_Click"
                    BackColor="Transparent" BorderWidth="0" />
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
