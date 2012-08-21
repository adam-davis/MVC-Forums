<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ForumMain.Master"
 Inherits="System.Web.Mvc.ViewPage<MvcForums.Models.UserValidationModel>" %>


<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <% Html.EnableClientValidation(); %>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        <div id="loginArea">
        <fieldset>
            <legend>Login</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.UserName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.UserName) %>
                <%: Html.ValidationMessageFor(model => model.UserName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Password) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(model => model.Password) %>
                <%: Html.ValidationMessageFor(model => model.Password) %>
            </div>
              <input type="submit" value="Login!" />
              </fieldset>
                <% } %>
    <%: Html.ActionLink("Register a new account", "Register", "Account") %>
 
    
    </div>
</asp:Content>
