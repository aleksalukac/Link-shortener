<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Link_Shortner._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Enter the password and later hyperlink and folder you want to create.</h1>
        <p>PASSWORD:<br /><asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Height="31px" OnTextChanged="TextBox2_TextChanged" Width="180px"></asp:TextBox>
        </p>
        <p>FOLDER:<br />
            <asp:TextBox ID="TextBoxFolder" runat="server"></asp:TextBox>
        </p>
        <p>LINK:<br />
            <asp:TextBox ID="TextBoxLink" runat="server" Height="30px" Width="176px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Create" />
        </p>

    </div>

</asp:Content>
