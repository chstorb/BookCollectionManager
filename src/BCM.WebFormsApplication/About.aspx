﻿<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="BCM.WebFormsApplication.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2><%: Page.Title %></h2>
    </div>
    <section>
        <h3 runat="server" id="headerMessage"><%-- Your application description page. --%></h3>
        <%-- 
        <p>Use this area to provide additional information.</p>
        --%>
    </section>
</asp:Content>
