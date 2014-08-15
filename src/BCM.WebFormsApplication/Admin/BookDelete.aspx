<%@ Page Title="Delete" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDelete.aspx.cs" Inherits="BCM.WebFormsApplication.Admin.BookDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2><%: Title %></h2>
    </div>
    <div class="row">
        <div class="col-md-12">
            <section id="bookDelete">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="LabelRemoveBook" runat="server">Book:</asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownRemoveBook" runat="server" ItemType="BCM.Model.Book"
                                SelectMethod="GetBooks" AppendDataBoundItems="true"
                                DataTextField="Title" DataValueField="ID">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <p></p>
                <asp:Button ID="RemoveBookButton" runat="server" Text="Remove Book" OnClick="RemoveBookButton_Click" CausesValidation="false" />
                <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
            </section>
        </div>
    </div>
</asp:Content>
