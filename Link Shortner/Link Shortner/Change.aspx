<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Change.aspx.cs" Inherits="Link_Shortner.Change" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Enter new password.</h1>
        <p>OLD PASSWORD:<br /><asp:TextBox ID="TextBoxOldPass" runat="server" TextMode="Password" Height="31px"  Width="180px"></asp:TextBox>
        </p>
        <p>NEW PASSWORD:<br />
            <asp:TextBox ID="TextBoxNewPass" TextMode="Password" runat="server"></asp:TextBox>
        </p>
        <p>REPEAT NEW PASSWORD:<br />
            <asp:TextBox ID="TextBoxNewPass1" TextMode="Password" runat="server" Height="30px" Width="176px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ChangePassButt" runat="server" OnClick="Button1_Click1" Text="Change" />
        </p>

    </div>
</asp:Content>
