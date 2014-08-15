<%@ Page Title="BCM" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BCM.WebFormsApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div class="jumbotron">
            <h1>Welcome</h1>
            <p class="lead">Book Collection Manager can help you to find used books.</p>            
        </div>

        <div class="row">
            <div class="col-md-12">
                <h2>Books</h2>
                <p>
                    We're all about used books. You can order any of our books today. Each book listing has detailed information to help you choose the right book.
                </p>
                <p>
                    <%--<a class="btn btn-default" href="~/BookList">Choose book &raquo;</a>--%>
                    <asp:HyperLink runat="server" ID="hyperLinkBookList" ViewStateMode="Disabled">Choose book &raquo</asp:HyperLink>
                </p>
            </div>
        </div>
    </section>
</asp:Content>
