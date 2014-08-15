<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BCM.WebFormsApplication.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2><%: Page.Title %></h2>
    </div>
    <section>
        <h3>The Book Collection Company</h3>        
        <address>
            One Microsoft Way<br />
            Redmond, WA 98052-6399<br />
            <abbr title="Phone">P:</abbr>
            425.555.0100
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
        </address>
    </section>
    <section style="margin-left: 120px; margin-top: 45px;">
        <hgroup>
            <h1>Contact Data</h1>
            <h2>You have data. We want it.</h2>
        </hgroup>
        <p>Your data:</p>
        <input type="text" required="required" />
        <input type="email" required="required" placeholder="you@domain.com" />
        <input type="url" placeholder="http://www.you.com" />
        <%--<input type="phone" pattern="\d\d\d\-\d\d\d\d"/>--%>
        <input type="submit" value="Send data" />
     </section>
</asp:Content>
