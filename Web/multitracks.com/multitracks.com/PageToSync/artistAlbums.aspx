<%@ Page Language="C#" AutoEventWireup="true" CodeFile="artistAlbums.aspx.cs" Inherits="artistAlbums" %>
<%@ Register TagPrefix="uc" TagName="SongUC" Src="./UserControls/SongUserControl.ascx" %>
<%@ Register TagPrefix="uc" TagName="AlbumUC" Src="./UserControls/AlbumUserControl.ascx" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<!-- set the viewport width and initial-scale on mobile devices -->
	<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" />

	<!-- set the encoding of your site -->
	<meta charset="utf-8">
	<title>MultiTracks.com</title>
	<!-- include the site stylesheet -->
	
	<link media="all" rel="stylesheet" href="./css/index.css">
</head>
	<body class="premium standard u-fix-fancybox-iframe">
		<form runat="server">
			<noscript>
				<div>Javascript must be enabled for the correct page display</div>
			</noscript>

			<!-- allow a user to go to the main content of the page -->
			<a class="accessibility" href="#main" tabindex="21">Skip to Content</a>

			<div class="wrapper mod-standard mod-gray">
				<div class="details-banner">
					<div class="details-banner--overlay"></div>
					<div class="details-banner--hero">
						<asp:Image class="details-banner--hero--img" runat="server" ID="heroImage" alt="Bethel Music" />
					</div>
					<div class="details-banner--info">
						<a href="#" class="details-banner--info--box">
								<asp:Image class="details-banner--info--box--img" runat="server" ID="artistImage" alt="alt" />
						</a>
						<h1 class="details-banner--info--name"><a class="details-banner--info--name--link" href="#"><asp:Label runat="server" ID="artistTitle"></asp:Label></a></h1>
					</div>
				</div>

				<nav class="discovery--nav">
					<ul class="discovery--nav--list tab-filter--list u-no-scrollbar">
						<li class="discovery--nav--list--item tab-filter--item">
							<a class="tab-filter" href="./artistDetails.aspx">Overview</a>
						</li>
						<li class="discovery--nav--list--item tab-filter--item">
							<a class="tab-filter" href="./artistSongs.aspx">Songs</a>
						</li>
						<li class="discovery--nav--list--item tab-filter--item is-active">
							<a class="tab-filter" href="./artistAlbums.aspx">Albums</a>
						</li>
					</ul> <!-- /.browse-header-filters -->
				</nav>

				<div class="discovery--container u-container">
							<main class="discovery--section">
								<div class="discovery--space-saver">
									<section class="standard--holder">
										<div class="discovery--section--header">
											<h2>Albums</h2>
											</div><!-- /.discovery-select -->

										<div class="discovery--grid-holder">

											<div class="ly-grid ly-grid-cranberries">

												<asp:Repeater runat="server" ID="albums" OnItemDataBound="AlbumRepeater_ItemDataBound">
													<ItemTemplate>
														<uc:AlbumUC ID="album" runat="server" />
													</ItemTemplate>
												</asp:Repeater>

											</div><!-- /.grid -->
										</div><!-- /.discovery-grid-holder -->
									</section><!-- /.songs-section -->
								</div>
							</main><!-- /.discovery-section -->
				</div><!-- /.standard-container -->
			</div><!-- /.wrapper -->


			

			<a class="accessibility" href="#wrapper" tabindex="20">Back to top</a>
		</form>
	</body>
</html>
