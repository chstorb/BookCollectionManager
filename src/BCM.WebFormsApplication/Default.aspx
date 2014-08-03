<%@ Page Title="BCM" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BCM.WebFormsApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h1>Welcome</h1>
        <p class="lead">Book Collection Manager can help you to find used books.</p>
    </div>

    <%--    
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-large">Learn more &raquo;</a></p>
    </div> 
    --%>

    <div class="row">
        <div class="col-md-4">
            <h2>Books</h2>
            <p>
                We're all about used books. You can order any of our books today. Each book listing has detailed information to help you choose the right book.
            </p>
            <p>
                <%--<a class="btn btn-default" href="~/BookList">Choose book &raquo;</a>--%>
                <asp:HyperLink runat="server" ID="hyperLinkBookList" ViewStateMode="Disabled">Choose book &raquo</asp:HyperLink>

            </p>
        </div>
        <%--
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        --%>
        <%--
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
        --%>
    </div>

</asp:Content>
