<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="App_Adopciones_Master.InicioSesion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge, chrome=1"/>
	<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0"/>
	<!-- VENDOR CSS -->
	<link rel="stylesheet" href="../assets/vendor/bootstrap/css/bootstrap.min.css"/>
	<link rel="stylesheet" href="../assets/vendor/font-awesome/css/font-awesome.min.css"/>
	<!-- MAIN CSS -->
	<link rel="stylesheet" href="../assets/css/main.css"/>
	<!-- FOR DEMO PURPOSES ONLY. You should remove this in your project -->
	<link rel="stylesheet" href="../assets/css/demo.css"/>
	<!-- GOOGLE FONTS -->
	<link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700" rel="stylesheet"/>
	<!-- ICONS -->
	<link rel="apple-touch-icon" sizes="76x76" href="assets/img/apple-icon.png"/>
	<link rel="icon" type="image/png" sizes="96x96" href="assets/img/favicon.png"/>

    <title>Iniciar Sesión</title>
</head>
<body>
    <form id="form1" runat="server">

      <div id="wrapper">
		<div class="vertical-align-wrap">
			<div class="vertical-align-middle">
				<div class="auth-box">
					<div class="content">
						<div class="header">
							<div class="logo text-center"><img src="../assets/img/logo.png" alt="DiffDash"/></div>
							<p class="lead">Login to your account</p>
						</div>
					
							<div class="form-group">
								<label for="signin-email" class="control-label sr-only">Email</label>
								<asp:TextBox runat="server"  class="form-control" id="txt_usuario" placeholder="Correo o Usuario"></asp:TextBox>
							</div>
							<div class="form-group">
								<label for="signin-password" class="control-label sr-only">Password</label>
								<asp:TextBox runat="server" TextMode="password" class="form-control" id="txt_clave" placeholder="Clave"></asp:TextBox>
							</div>
							<div class="form-group clearfix">
								<label class="fancy-checkbox element-left">
									<input type="checkbox"/>
									<span>Recordar Clave</span>
								</label>
								<span class="helper-text element-right">No tienes una cuenta? <a href="page-register.html">Registrarse</a></span>
							</div>
							<asp:Button type="submit" class="btn btn-primary btn-lg btn-block" OnClick="btn_login_Click" runat="server" Id="btn_login" Text="Ingresar"></asp:Button>
							<div class="bottom">
								<span class="helper-text"><i class="fa fa-lock"></i> <a href="page-forgot-password.html">Olvidó su clave?</a></span>
							</div>
					
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- END WRAPPER -->
    </form>
</body>
</html>

