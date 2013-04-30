<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="serTI.Campania.Web.Inicio" %>

<!DOCTYPE html >

<html >
<head runat="server">

  <meta charset="utf-8" />

  <!-- Set the viewport width to device width for mobile -->
  <meta name="viewport" content="width=device-width" />

  <title>mK 10</title>
  
  <!-- Included CSS Files (Uncompressed) -->
  <!--
  <link rel="stylesheet" href="Styles/foundation.css">
  -->
  
  <!-- Included CSS Files (Compressed) -->
  <link rel="stylesheet" href="Styles/foundation.min.css">
  <link rel="stylesheet" href="Styles/app.css">

  <script src="Scripts/modernizr.foundation.js"></script>

</head>
<body>
    <form id="form1" runat="server">

	<header class="home"></header>
	<section id="homepage">
		<div class="row">
			<div class="six columns">
				<img class="logo_mk10" src="App_Themes/mk10/logo_home.png" alt="logo_home" width="440" height="308">
			</div>
			<div class="one column">
				<div class="home_divider_izq"></div>
			</div>
			<div class="three columns">
				<form class="log_spot">
					<ul>
						<li>
							<asp:TextBox  ID="tUsuario" runat=server Text="usuario"></asp:TextBox>
						</li>
						<li>
							<asp:TextBox ID="tContrasenia" runat=server  Text="contraseña"></asp:TextBox>
						</li>
						<li>
							<a class="btn_login" href="#">Iniciar Sesion</a>
						</li>
					</ul>
				</form>
			</div>
			<div class="one column">
				<div class="home_divider_der"></div>
			</div>
			
		</div>
	</section>

  
  
  <!-- Included JS Files (Uncompressed) -->
  <!--
  <script src="Scripts/jquery.js"></script><script src="Scripts/jquery.foundation.mediaQueryToggle.js"></script><script src="Scripts/jquery.foundation.forms.js"></script><script src="Scripts/jquery.foundation.reveal.js"></script><script src="Scripts/jquery.foundation.orbit.js"></script><script src="Scripts/jquery.foundation.navigation.js"></script><script src="Scripts/jquery.foundation.buttons.js"></script><script src="Scripts/jquery.foundation.tabs.js"></script><script src="Scripts/jquery.foundation.tooltips.js"></script><script src="Scripts/jquery.foundation.accordion.js"></script><script src="Scripts/jquery.placeholder.js"></script><script src="Scripts/jquery.foundation.alerts.js"></script><script src="Scripts/jquery.foundation.topbar.js"></script><script src="Scripts/jquery.foundation.joyride.js"></script><script src="Scripts/jquery.foundation.clearing.js"></script><script src="Scripts/jquery.foundation.magellan.js"></script>
  -->
  
  <!-- Included JS Files (Compressed) -->
  <script src="Scripts/jquery.js"></script>
  <script src="Scripts/foundation.min.js"></script>
  
  <!-- Initialize JS Plugins -->
  <script src="Scripts/app.js"></script>

  
    <script>
        $(window).load(function () {
            $("#featured").orbit();
        });
    </script> 
  

    </form>
</body>
</html>
