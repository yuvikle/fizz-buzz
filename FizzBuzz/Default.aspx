<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FizzBuzz._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Fizz Buzz Finder</h1>
        <div id="divError" runat="server" visible="false" class="alert alert-danger" role="alert">
          <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
        </div>
        <form>
            <div class="form-group">
                <label>Input Arrays</label>
                <asp:TextBox ID="txtInput" runat="server" CssClass="form-control"
                    ToolTip="Enter comma separated values"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary btn-lg" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
        </form>
        <div class="row">
            <asp:GridView ID="gvResult" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Input" DataField="Input" ItemStyle-Width="50" />
                    <asp:TemplateField HeaderText="Result">
                        <ItemTemplate>
                            <div id="divOutput" runat ="server" style="width:100%; height:100%"><%# DataBinder.Eval(Container.DataItem, "Output") %></div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <AlternatingRowStyle BackColor="WhiteSmoke" />
            </asp:GridView>
        </div>
    </div>

</asp:Content>
