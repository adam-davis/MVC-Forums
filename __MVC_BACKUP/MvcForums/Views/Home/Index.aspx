<%@ Page Language="C#" MasterPageFile="~/Views/Shared/ForumMain.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <link rel="Stylesheet" href="../../Content/Site.css"  type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainBody" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <div id="loginArea">
    <form action="Login" method="post">
    <label class="formLabel" id="lblUserName">User Name:</label>
    <input id="userName" class="singleLineTextInput" name="txtUserName" />
    <br />
    <label class="formLabel" id="lblPassword">Password: </label>
    <input id="password" class="singleLineTextInput" name="txtPassword" />
    <br />
    <button id="btnLoginSubmit" runat="server" Text="Login">Login</button>
    </form>
    <%: Html.ActionLink("Register a new account", "Register", "Account") %>
    </div>
    

</asp:Content>
