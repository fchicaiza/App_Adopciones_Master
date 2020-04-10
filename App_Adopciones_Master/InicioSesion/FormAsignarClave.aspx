<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormAsignarClave.aspx.cs" Inherits="App_Adopciones_Master.InicioSesion.FormAsignarClave" %>

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
	<!-- SWEETALERT -->
    <link rel="stylesheet" href="../assets/css/sweetalert.css"/>
    <!-- ICONS -->
	<link rel="apple-touch-icon" sizes="76x76" href="../assets/img/apple-icon.png"/>
	<link rel="icon" type="image/png" sizes="96x96" href="../assets/img/favicon.png"/>
 
    <title>Iniciar Sesión</title>
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
							<p class="lead">Asignar usuario y clave</p>
						</div>


                               <div class="form-group">
								<label for="signup-email" class="control-label sr-only">Clave anterior</label>
								<asp:TextBox TextMode="Password" runat="server" class="form-control" id="txt_temp" placeholder="Clave temporal enviada a su email"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								<label for="signup-email" class="control-label sr-only">Clave nueva</label>
								<asp:TextBox  runat="server" class="form-control" id="txt_usuario" placeholder="Usuario"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								<label for="signup-email" class="control-label sr-only">Clave nueva</label>
								<asp:TextBox TextMode="Password" runat="server" class="form-control" id="txt_neva" placeholder="Clave nueva"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								<label for="signup-email" class="control-label sr-only">Confirmar Clave</label>
								<asp:TextBox TextMode="Password" runat="server" class="form-control" id="txt_conf" placeholder="Confirmar clave"></asp:TextBox>                                    
                                </div>
                                

							<asp:Button class="btn btn-primary btn-lg btn-block" runat="server" ID="btn_clave" OnClick="btn_clave_Click" Text="Registrar"></asp:Button>
							<div class="bottom">
								<span class="helper-text">Ya tiene una cuenta? <a href="Login.aspx">Login</a></span>
							</div>
				
                        </div>
					</div>
		
			</div>
		</div>
	</div>
         <!-- jQuery 2.2.3 -->
        <script src="../assets/jquery/jquery.min.js"></script>
        <!-- Bootstrap 3.3.6 -->
        <script src="../assets/vendor/bootstrap/js/bootstrap.min.js"></script>

        <!-- iCheck -->
        <script src="../assets/js/sweetalert.min.js"></script>
        <script src="../assets/js/Alertas.js"></script>
        <script src="../assets/js/SweetAlert2.js"></script>
	<!-- END WRAPPER -->
    </form>
   
</body>
</html>

