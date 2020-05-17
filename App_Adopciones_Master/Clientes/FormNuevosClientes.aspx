<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormNuevosClientes.aspx.cs" Inherits="App_Adopciones_Master.Clientes.FormNuevosClientes" %>

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
 
    <title>Información Clientes</title>
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
							<p class="lead">Información del usuario</p>
						</div>


                               <div class="form-group">
								
								<asp:TextBox  runat="server" class="form-control" id="txt_dni" placeholder="Cédula / Ruc / Pasaporte"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								
								<asp:TextBox  runat="server" class="form-control" id="txt_nombres" placeholder="Nombres"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								
								<asp:TextBox runat="server" class="form-control" id="txt_apellidos" placeholder="Apellidos"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								
								<asp:TextBox TextMode="Number" runat="server" class="form-control" id="txt_telefono" placeholder="Teléfono"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								
								<asp:TextBox runat="server" class="form-control" id="txt_cllp" placeholder="Calle principal"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								
								<asp:TextBox TextMode="Number"  runat="server" class="form-control" id="txt_num" placeholder="Número de casa o lote"></asp:TextBox>                                    
                                </div>

                                <div class="form-group">
								
								<asp:TextBox  runat="server" class="form-control" id="txt_clls" placeholder="Calle Secundaria"></asp:TextBox>                                    
                                </div>
                                
                                                
						<div class="form-group">
							<label >Foto de perfil</label>
							<asp:FileUpload  runat="server" CssClass="btn" type="file" id="img_up" data-default-file="assets/img/uploaded-file.jpg"/>
						</div>
					
							    <asp:Button class="btn btn-primary btn-lg btn-block" runat="server" ID="btn_guardar" OnClick="btn_guardar_Click" Text="Guardar"></asp:Button>
							    <div class="bottom">
								<span class="helper-text"> <a href="Login.aspx">Salir</a></span>
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
        <script src="../assets/vendor/dropify/js/dropify.min.js"></script>
	    <script src="../assets/scripts/common.js"></script>
	<!-- END WRAPPER -->
        <script>
	$(function() {
		$('.dropify').dropify();

		var drEvent = $('#img_up').dropify();
		drEvent.on('dropify.beforeClear', function(event, element) {
			return confirm("Do you really want to delete \"" + element.file.name + "\" ?");
		});

		drEvent.on('dropify.afterClear', function(event, element) {
			alert('File deleted');
		});

		$('.dropify-fr').dropify({
			messages: {
				default: 'Glissez-déposez un fichier ici ou cliquez',
				replace: 'Glissez-déposez un fichier ou cliquez pour remplacer',
				remove: 'Supprimer',
				error: 'Désolé, le fichier trop volumineux'
			}
		});
	});
	</script>
    </form>
   
</body>
</html>

