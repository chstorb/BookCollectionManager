                            <div class="form-group">
                                <asp:Label ID="labelCategory" runat="server" CssClass="col-md-2 control-label">Category</asp:Label>
                                <div class="col-md-10">
                                    <asp:DropDownList ID="dropDownCategory" runat="server"
                                        ItemType="BCM.Model.Category"
                                        SelectMethod="GetCategories"
                                        DataTextField="Name"
                                        DataValueField="ID"
                                        CssClass="form-control">
                                    </asp:DropDownList>
                                    <%--<asp:RequiredFieldValidator ID="requiredFieldValidator0" runat="server" ControlToValidate="dropDownCategory"
                                        CssClass="text-danger" ErrorMessage="The catetory field is required." />--%>
                                </div>
                            </div>


                            <div class="form-group">
                                <asp:Label ID="labelNotes" runat="server" CssClass="col-md-2 control-label">Notes</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="Notes" TextMode="MultiLine" Text='<%#:BindItem.Notes%>' runat="server" CssClass="form-control"></asp:TextBox>
                                    <%--<asp:RequiredFieldValidator ID="requiredFieldValidator2" runat="server" Text="* Notes required." ControlToValidate="textBoxNotes" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="labelPrice" runat="server" CssClass="col-md-2 control-label">Price</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="Price" Text='<%#:BindItem.ListPrice%>' runat="server" CssClass="form-control"></asp:TextBox>
                                    <%--<asp:RequiredFieldValidator ID="requiredFieldValidator3" runat="server" Text="* Price required." ControlToValidate="textBoxPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regularExpressionValidator1" runat="server" Text="* Must be a valid price without currency symbol." ControlToValidate="textBoxPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>--%>
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="labelUploadImage" runat="server" CssClass="col-md-2 control-label">Image File</asp:Label>
                                <div class="col-md-10">
                                    <asp:FileUpload ID="ImageUrl" Text='<%#:BindItem.ImageUrl%>' runat="server" />
                                    <%--<asp:RequiredFieldValidator ID="requiredFieldValidator4" runat="server" Text="* Image path required." ControlToValidate="fileUploadImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="col-md-offset-2 col-md-10">
                                    <input type="submit" value="Save" class="btn btn-default" />
                                </div>
                            </div>

                            <div>
                                <asp:LinkButton runat="server" ID="linkButtonBack" Text="Back to List" CommandName="Back" OnCommand="linkButtonBack_Command" />
                            </div>

