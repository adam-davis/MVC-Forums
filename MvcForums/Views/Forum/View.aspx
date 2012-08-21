<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ForumMain.master" Inherits="System.Web.Mvc.ViewPage<MvcForums.Models.Forum>" %>



<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
<div id="forumWrapper">
<div id="forumHeader">
<%= Html.Encode(Model.name) %>
</div>
<div id="forumOptions">
<form method="get" action="/Forum/Post/<%= Model.id %>">
<button class="forumOptionButton" >New Post....</button>
</form>
</div>
<% if(Model.Thread.Count == 0){ %>
Forum has no posts....

<% } %>

</div>
</asp:Content>
