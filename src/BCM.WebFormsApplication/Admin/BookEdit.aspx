<%@ Page Title="Edit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookEdit.aspx.cs" Inherits="BCM.WebFormsApplication.Admin.BookEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h2><%: Title %></h2>
    </div>
    <div class="row">
        <div class="col-md-12">
            <section id="bookEdit">
                <asp:FormView
                    ID="formViewBookEdit"
                    runat="server"
                    ItemType="BCM.Model.Book"
                    DataKeyNames="ID"
                    SelectMethod="GetBookById"
                    UpdateMethod="UpdateBook"
                    RenderOuterTable="false"
                    EmptyDataText="No data was found."
                    AllowPaging="false">

                    <EditItemTemplate>

                        <div class="form-horizontal">

                            <br />
                            <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
                            <br />

                            <div class="form-group">
                                <asp:Label ID="labelBookId" runat="server" CssClass="col-md-2 control-label" Text="Book ID" />
                                <div class="col-md-10">
                                    <asp:TextBox ID="ID" runat="server" Text='<%#:BindItem.ID%>' CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="labelTitle" runat="server" CssClass="col-md-2 control-label">Title</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="Title" Text='<%#:BindItem.Title%>' runat="server" CssClass="form-control"></asp:TextBox>
                                    <%--<asp:RequiredFieldValidator ID="requiredFieldValidator1" runat="server" Text="* Book Title required." ControlToValidate="textBoxTitle" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="col-md-offset-2 col-md-10">
                                    <asp:LinkButton ID="UpdateButton" runat="server"
                                        CausesValidation="True" CommandName="Update"
                                        Text="Update" CssClass="btn btn-default">

                                    </asp:LinkButton>
                                </div>
                            </div>

                        </div>

                        <asp:LinkButton ID="UpdateCancelButton" runat="server"
                            CausesValidation="False" CommandName="Cancel"
                            Text="Back to List" PostBackUrl="~/Admin/BookIndex.aspx">

                        </asp:LinkButton>

                    </EditItemTemplate>

                </asp:FormView>

            </section>
        </div>
    </div>
</asp:Content>
