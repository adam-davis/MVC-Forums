<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcForums.Models.ForumViewModel>" %>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Name) %>
                <%: Html.ValidationMessageFor(model => model.Name) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Description) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(model => model.Description)%>
                <%: Html.ValidationMessageFor(model => model.Description)%>
            </div>
            

            <p>
                <input type="submit" value="Add Forum" />
            </p>
        </fieldset>

    <% } %>