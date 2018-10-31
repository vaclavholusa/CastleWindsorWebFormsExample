<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CastleWindsorWebFormsExample.Default" %>
<%@ Register Src="~/UserControls/DateBox.ascx" TagPrefix="uc" TagName="DateBox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
    <fieldset>
        <legend>Page</legend>
        <p><%= DateTimeProvider.Now %></p>
    </fieldset>

    <uc:DateBox runat="server" />
</asp:Content>
