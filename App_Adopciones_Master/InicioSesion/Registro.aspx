<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="App_Adopciones_Master.InicioSesion.Registro" %>

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
	<link rel="apple-touch-icon" sizes="76x76" href="../assets/img/apple-icon.png"/>
	<link rel="icon" type="image/png" sizes="96x96" href="../assets/img/favicon.png"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div id="wrapper">
		<div class="vertical-align-wrap">
			<div class="vertical-align-middle">
				<div class="auth-box register">
					<div class="content">
						<div class="header">
							<div class="logo text-center"><img src="../assets/img/logo.png" alt="DiffDash"/></div>
							<p class="lead">Crear una cuenta</p>
						</div>
					
							<div class="form-group">
                                <label for="signup-email" class="control-label sr-only">DNI</label>
								<asp:TextBox  runat="server" class="form-control" id="txt_dni" placeholder="Cédula / RUC / Pasaporte"></asp:TextBox>
                              </div>


                                <div class="form-group">
                                <label for="signup-email" class="control-label sr-only">Nombres</label>
								<asp:TextBox  runat="server" class="form-control" id="txt_nombre" placeholder="Nombres"></asp:TextBox>
                                </div>

                                
                                <div class="form-group">
                                <label for="signup-email" class="control-label sr-only">Apellidos</label>
								<asp:TextBox  runat="server" class="form-control" id="txt_apellido" placeholder="Apellidos"></asp:TextBox>
                                </div>

                               <div class="form-group">
								<label for="signup-email" class="control-label sr-only">Email</label>
								<asp:TextBox TextMode="email" runat="server" class="form-control" id="txt_email" placeholder="Your email"></asp:TextBox>                                    
                                </div>

                               <div class="form-group">
								<label for="signup-password" class="control-label sr-only">Clave</label>
								<asp:TextBox runat="server" type="password" class="form-control" id="txt_clave" placeholder="Clave"></asp:TextBox>
							    </div>

                                
                                <div class="form-group">
								<label for="signup-password" class="control-label sr-only">Cofirmar Clave</label>
								<asp:TextBox runat="server" type="password" class="form-control" id="txt_rclave" placeholder="Cofirmar clave"></asp:TextBox>
							    </div>

                                  <div class="form-group">
								<label for="signup-password" class="control-label sr-only">Agregar foto de perfil</label>
								<asp:FileUpload ID="img_perfil" CssClass="form-control" runat="server" />
							    </div>

                                

							<asp:Button class="btn btn-primary btn-lg btn-block" runat="server" ID="btn_registro" OnClick="btn_registro_Click" Text="REGISTRAR"></asp:Button>
							<div class="bottom">
								<span class="helper-text">Ya tiene una cuenta? <a href="page-login.html">Login</a></span>
							</div>
				

					</div>
		
			</div>
		</div>
	</div>
	<!-- END WRAPPER -->
    </form>
</body>
</html>
