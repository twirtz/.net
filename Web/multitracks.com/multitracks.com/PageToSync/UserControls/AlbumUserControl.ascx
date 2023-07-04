<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AlbumUserControl.ascx.cs" Inherits="PageToSync_UserControls_AlbumUserControl" %>

<div class="media-item">
	<a class="media-item--img--link" href="#" tabindex="0">
		<asp:Image runat="server" ID="albumImg" class="media-item--img"/>
		<span class="image-tag">Master</span>
	</a>
	<a class="media-item--title" href="#" tabindex="0"><asp:Label runat="server" ID="albumTitle" /></a>
	<a class="media-item--subtitle" href="#" tabindex="0"><asp:Label runat="server" ID="artistName" /></a>
</div>