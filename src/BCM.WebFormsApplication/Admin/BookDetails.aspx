<%@ Page Title="Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="BCM.WebFormsApplication.Admin.BookDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2><%: Title %>.</h2>
    </div>
    <div class="row">
        <div class="col-md-12">
            <section id="bookDetails">
                <asp:FormView ID="formViewBookDetails" 
                    runat="server" 
                    ItemType="BCM.Model.Book" 
                    DataKeyNames="ID"                    
                    SelectMethod="GetBookById" 
                    RenderOuterTable="false"
                    EmptyDataText="No data was found."
                    AllowPaging="false">
                    <ItemTemplate>
                        <div class="form-horizontal">
                            <div class="form-group">
                                <div class="col-md-3">
                                    <img src="/Catalog/Images/<%#:Item.ImageUrl %>" style="border: solid; height: 300px" alt="<%#:Item.Title %>" />
                                </div>
                                <div class="col-md-9">
                                    <h3><%#:Item.Title %></h3>
                                    <hr />
                                    <p>
                                        <%#: String.Format("{0:c}", Item.ListPrice) %>
                                    </p>
                                </div>
                            </div>
                            <hr />
                            <div class="form-group">
                                <div class="col-md-12">
                                    <h4>Productinformation</h4>
                                    <b>Book Number:</b>&nbsp;<%#:Item.ID %>
                                    <asp:Label runat="server" ID="labelLanguage" Visible="false" Text="Language" />
                                    <asp:Label runat="server" Visible="true" Text="<%#:Item.Language %>" />
                                </div>
                            </div>
                            <hr />
                            <div class="form-group">
                                <div class="col-md-12">
                                    <h4>Description</h4>
                                    <%#:Item.Notes %>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:FormView>
            </section>
        </div>
    </div>
</asp:Content>
