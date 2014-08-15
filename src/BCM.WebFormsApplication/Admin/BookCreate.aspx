<%@ Page Title="Create" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookCreate.aspx.cs" Inherits="BCM.WebFormsApplication.Admin.BookCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2><%: Title %>.</h2>
    </div>
    <div class="row">
        <div class="col-md-12">
            <section id="bookCreate">
                <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
                <asp:FormView runat="server" ID="formViewBookCreate"
                    ItemType="BCM.Model.Book"
                    InsertMethod="formViewBookCreate_InsertItem"
                    DefaultMode="Insert"
                    RenderOuterTable="false"
                    OnItemInserted="formViewBookCreate_ItemInserted">
                    <InsertItemTemplate>
                        <fieldset>
                            <ol>
                                <asp:DynamicEntity runat="server" Mode="Insert" />
                            </ol>
                            <asp:Button ID="buttonInsert" runat="server" Text="Insert" CommandName="Insert" />
                            <asp:Button ID="buttonCancel" runat="server" Text="Cancel" CausesValidation="false" OnClick="buttonCancel_Click" />
                        </fieldset>
                    </InsertItemTemplate>
                </asp:FormView>

                <%--<table>
                    <tr>
                        <td>
                            <asp:Label ID="LabelAddCategory" runat="server">Category:</asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownAddCategory" runat="server"
                                ItemType="BCM.Model.Category"
                                SelectMethod="GetCategories" DataTextField="Name"
                                DataValueField="ID">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelAddTitle" runat="server">Title:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddBookTitle" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Book Title required." ControlToValidate="AddBookTitle" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelAddNotes" runat="server">Notes:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddBookNotes" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* Notes required." ControlToValidate="AddBookNotes" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelAddPrice" runat="server">Price:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddBookPrice" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* Price required." ControlToValidate="AddBookPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without currency symbol." ControlToValidate="AddBookPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelAddImageFile" runat="server">Image File:</asp:Label></td>
                        <td>
                            <asp:FileUpload ID="BookImage" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Image path required." ControlToValidate="BookImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
                <p></p>
                <asp:Button ID="AddBookButton" runat="server" Text="Add Book" OnClick="AddBookButton_Click" CausesValidation="true" />
                <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>--%>
            </section>
        </div>
    </div>
</asp:Content>
