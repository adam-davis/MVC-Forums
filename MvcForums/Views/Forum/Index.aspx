<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ForumMain.master" 
Inherits="System.Web.Mvc.ViewPage<List<MvcForums.Models.Forum>>" %>


<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
<div id="forumListWrapper">
<!--Outputting HTML list of forums -->
<% foreach (MvcForums.Models.Forum forum in Model) 
   {%>
      <div id="forum<%= forum.id %>" >
      <a class="forumTitle" href="/Forum/View/<%= forum.id %>" ><%= forum.name %></a>
      <br />
     <span class="forumDescription"> <%= forum.description %></span>
      </div>

      <%
   }
   %>
   </div>
</asp:Content>
