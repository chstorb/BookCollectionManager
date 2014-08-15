<%@ Page Title="Index" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookIndex.aspx.cs" Inherits="BCM.WebFormsApplication.Admin.BookIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2><%: Title %>.</h2>
    </div>
    <div class="row">
        <div class="col-md-12">
            <section id="bookIndex">
                <p>
                    <%--<asp:HyperLink NavigateUrl="~/Admin/BookCreate" Text="Crate New" runat="server" />--%>
                    <asp:LinkButton runat="server" ID="linkButtonCreateNew" Text="Create New" CommandName="Create" OnCommand="buttonCreateNew_Command" />
                </p>
                <asp:GridView
                    ID="gridViewBookIndex"
                    runat="server"
                    AutoGenerateColumns="False"
                    ShowFooter="True"
                    GridLines="Vertical"
                    CellPadding="4"
                    ItemType="BCM.Model.Book"
                    SelectMethod="GetBooks"
                    CssClass="table table-striped table-bordered">
                    <HeaderStyle CssClass="" />
                    <AlternatingRowStyle CssClass="" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="Location" HeaderText="Location" />
                        <asp:BoundField DataField="ListPrice" HeaderText="Unit Price" DataFormatString="{0:C}" />
                        <asp:TemplateField HeaderText="">
                            <ItemTemplate>
                                <asp:LinkButton ID="linkButtonBookEdit" runat="server" Text="Edit" CommandArgument="<%# Item.ID %>" CommandName="Edit" OnCommand="linkButtonBookEdit_Command" />
                                | 
                                <asp:LinkButton ID="linkButtonBookDetails" runat="server" Text="Details" CommandArgument="<%# Item.ID %>" CommandName="Details" OnCommand="linkButtonBookDetails_Command" />
                                | 
                                <asp:LinkButton ID="linkButtonBookDelete" runat="server" Text="Delete" CommandArgument="<%# Item.ID %>" CommandName="Delete" OnCommand="linkButtonBookDelete_Command" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </section>
        </div>
    </div>
</asp:Content>
