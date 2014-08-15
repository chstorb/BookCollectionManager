<%@ Page Title="Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="BCM.WebFormsApplication.BookList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2><%: Page.Title %></h2>
    </div>
    <div class="row">
        <div class="col-md-12">
            <section id="bookList">
                <asp:ListView ID="listViewBookList"
                    runat="server"
                    DataKeyNames="ID"
                    GroupItemCount="3"
                    ItemType="BCM.Model.Book"
                    SelectMethod="GetBooks">
                    <EmptyDataTemplate>
                        <table class="">
                            <tr>
                                <td>No data was returned.</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <EmptyItemTemplate>
                        <td />
                    </EmptyItemTemplate>
                    <GroupTemplate>
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <td runat="server">
                            <table class="">
                                <tr>
                                    <td>
                                        <a href="BookDetails.aspx?bookID=<%#:Item.ID%>">
                                            <img class="img-responsive" src="/Catalog/Images/Thumbs/<%#:Item.ImageUrl%>"
                                                width="100" alt="<%#:Item.Title%>" />
                                        </a>
                                        <%--
                                        <a href="<%#: GetRouteUrl("BookByTitleRoute", new { bookTitle = Item.Title }) %>">
                                            <image src='/Catalog/Images/Thumbs/<%#:Item.ImageUrl%>'
                                                width="100" height="75" border="1" />
                                        </a>
                                        --%>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <a href="BookDetails.aspx?bookID=<%#:Item.ID%>">
                                            <h4>
                                                <%#: Truncate( Item.Title, 25) %>
                                            </h4>
                                        </a>
                                        <%--
                                        <a href="<%#: GetRouteUrl("BookByTitleRoute", new { bookTitle = Item.Title}) %>">
                                            <%#:Item.Title%>
                                        </a>
                                        --%>
                                        <br />
                                        <span>
                                            <b>Price: </b><%#:String.Format("{0:C}", Item.ListPrice)%>
                                        </span>
                                        <br />
                                        <a href="AddToCart.aspx?bookID=<%#:Item.ID%>">
                                            <span class="BookListItem">
                                                <b>Add To Cart<b>
                                            </span>
                                        </a>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                            </p>
                        </td>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table class="" style="width: 100%;">
                            <tbody>
                                <tr>
                                    <td>
                                        <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                            <tr id="groupPlaceholder"></tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                </tr>
                                <tr></tr>
                            </tbody>
                        </table>
                    </LayoutTemplate>
                </asp:ListView>
            </section>
        </div>
    </div>
</asp:Content>
