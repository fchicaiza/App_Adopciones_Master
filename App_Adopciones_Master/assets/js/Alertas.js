
function timer() {

    let timerInterval
    Swal.fire({
        icon: 'error',
        html: '<div><h4> Ha alcanzado el límite de intentos permitidos (3) </h4></div>  <div><h5>Espere un momento para volver a intentarlo</h5> Reiniciendo en <b></b> milisegundos </div>',
        timer: 10000,
        timerProgressBar: true,
        allowOutsideClick: false,
        width: '40%',
        onBeforeOpen: () => {
            Swal.showLoading()
            timerInterval = setInterval(() => {
                Swal.getContent().querySelector('b')
                    .textContent = Swal.getTimerLeft()
            }, 100)
        },
        onClose: () => {
            clearInterval(timerInterval)
        }
    }).then((result) => {
        if (

            result.dismiss === Swal.DismissReason.timer
        ) {
            console.log('I was closed by the timer')
        }
    })

}

// completar formulario de usuario
function completar() {
    Swal.fire({
        icon: 'sucess',
        html: '<div><h2> Acceso Correcto</h2></div><div><h4>Por favor completa tu perfil para iniciar</h4></div>',
        width: '40%',
        confirmButtonColor: '#31A217',
        //confirmButtonText: '<h5>Iniciar Sesion</h5>'
    })
    //    .then(function () {
    //    window.location = "FormAsignarClave.aspx"
    //})
}
//Contraseña asignada

function claveasignada() {

    Swal.fire(
        '<h3>Usuario y contraseña generados correctamente!</h3>',
        '<h4>Ahora puedes ingresar al sistema</h4>',
        'success'

    )
}

function inactivo() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error de estado</h2></div><div><h3>El usuario con el que intenta ingresar está inactivo</h3></div>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'

    })
}

function noexiste() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error de usuario</h2></div><div><h4>El usuario con el que intenta ingresar no está en nuestra base de datos</h4></div>',
        footer: '<h4><div class="row">  <div class="col-sm-6"><a href="">Registrarse</a></div> </div></h4>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'

    })
}

function siexiste() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error!!</h2></div><div><h4>El correo elecctrónico ya está registrado en la base de datos</h4></div>',
        footer: '<h4><div class="row">  <div class="col-sm-6"><a href="Login.aspx">Login</a></div> </div></h4>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'

    })
}


function correcto() {

    Swal.fire(
        '<h3>Autenticación correcta!</h3>',
        '<h4>Bienvenido al sistema!</h4>',
        'success'

    )
}

function enviado() {
    Swal.fire({
        icon: 'sucess',
        html: '<div><h2> Envío completado satisfactoriamente</h2></div><div><h4>Por favor revisa tu bandeja de entrada y sigue las instrucciones para generar tus credenciales de acceso</h4></div>',
        width: '40%',
        confirmButtonColor: '#31A217',
        //confirmButtonText: '<h5>Iniciar Sesion</h5>'
    })
    //    .then(function () {
    //    window.location = "FormAsignarClave.aspx"
    //})
}
function noencontrado() {

    Swal.fire(
        'Correo no enviado!',
        'Direccion electrónica no encontrada en la base de datos',
        'error'
    )
}
function noenviado() {

    Swal.fire(
        'Correo no enviado!',
        'Se ha producido un error, intentelo mas tarde',
        'error'
    )
}
function nocoincide() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error de validación</h2></div><div><h4>Las contraseñas son diferentes</h4></div>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'

    })
}
function noregistrado() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error al registrar</h2></div><div><h4>El usuario ya se encuentra registrado</h4></div>',
        footer: '<h4><div class="row">  <div class="col-sm-6"><a href="">Iniciar Sesion</a></div> </div></h4>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'
    })
}

function registrado() {
    Swal.fire({
        icon: 'sucess',
        html: '<div><h2> Ha completado su registro</h2></div><div><h4>Su cuenta ha sido creada exitosamente</h4></div>',
        width: '40%',
        confirmButtonColor: '#31A217',
        confirmButtonText: '<h5>Iniciar Sesion</h5>'
    }).then(function () {
        window.location = "Login.aspx"
    })
}

function cedinvalida() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error de validación</h2></div><div><h4>La cédula que ingresaste no es válida o no existe</h4></div>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'
    })
}
function eliminar() {
    Swal.fire({
        title: 'Está seguro?',
        text: "El usuario no aparecerá en el listado de usuarios activos!",
        icon: 'warning',
        width: '40%',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, eliminar!'
    }).then((result) => {
        if (result.value) {
            Swal.fire(
                'Eliminado!',
                'El usuario ha sido eliminado.',
                'success'
            )
        }
    })
}
//General
function actualizado() {

    Swal.fire(
        '<h3>Actualización exitosa!</h3>',
        '<h4>Cambios guardados en la base de datos</h4>',
        'success'

    )
}

function Insertado() {

    Swal.fire(
        '<h3>Inserción exitosa!</h3>',
        '<h4>Se han insertado los datos correctamente</h4>',
        'success'

    )
}

function eliminarProducto() {
    Swal.fire({
        title: 'Está seguro?',
        text: "El producto no aparecerá en el listado de producto activos!",
        icon: 'warning',
        width: '40%',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, eliminar!'
    }).then((result) => {
        if (result.value) {
            Swal.fire(
                'Eliminado!',
                'El producto ha sido eliminado.',
                'success'
            )
        }
    })
}

function eliminarProveedor() {
    Swal.fire({
        title: 'Está seguro?',
        text: "El proveedor no aparecerá en el listado de proveedores activos!",
        icon: 'warning',
        width: '40%',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, eliminar!'
    }).then((result) => {
        if (result.value) {
            Swal.fire(
                'Eliminado!',
                'El proveedor ha sido eliminado.',
                'success'
            )
        }
    })
}
// RUC
function rucinvalido() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error de validación</h2></div><div><h4>El número de Ruc que ingresaste no es válida o no existe</h4></div>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'
    })
}

function noactualizado() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error al actualizar</h2></div><div><h4>Se ha producido un error al conectar con la base de datos</h4></div>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'
    })
}

//Empresa
function eliminarempresa() {
    Swal.fire({
        title: 'Está seguro?',
        text: "La empresa no aparecerá en el listado de empresas activas!",
        icon: 'warning',
        width: '40%',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, eliminar!'
    }).then((result) => {
        if (result.value) {
            Swal.fire(
                'Eliminación exitosa!',
                'La empresa ha sido eliminado.',
                'success'
            )
        }
        window.location = "ListarEmpresa.aspx";
    })
}

function empnoregistrada() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error al registrar</h2></div><div><h4>La empresa ya se encuentra registrada</h4></div>',
        footer: '<h4><div class="row">  <div class="col-sm-6"><a href="">Iniciar Sesion</a></div> </div></h4>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'
    })
}

function empregistrada() {
    Swal.fire({
        icon: 'sucess',
        html: '<div><h2>Registro exitoso</h2></div><div><h4>La empresa se ha registrado en la base de datos</h4></div>',
        width: '40%'
    }).then(function () {
        window.location = "ListarEmpresa.aspx";
    })
}
function empeliminada() {
    Swal.fire({
        icon: 'sucess',
        html: '<div><h2>Eliminación Exitosa</h2></div><div><h4>La empresa se ha eliminado en la base de datos</h4></div>',
        width: '40%'
    }).then(function () {
        window.location = "ListarEmpresa.aspx";
    })
}

function empnoeliminada() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error al eliminar la empresa</h2></div><div><h4>Error al conectar con la base de datos, no se ha realizado la emliminación</h4></div>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'
    })
}

// DEpartamentos

function eliminardpto() {
    Swal.fire({
        title: 'Está seguro?',
        text: "El departamento no aparecerá en el listado de departamentos activos de la empresa!",
        icon: 'warning',
        width: '40%',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, eliminar!'
    }).then((result) => {
        if (result.value) {
            Swal.fire(
                'Eliminación exitosa!',
                'El departamento ha sido eliminado.',
                'success'
            )
        }
        window.location = "ListarDepartamentos.aspx";
    })
}

function dptoeliminado() {
    Swal.fire({
        icon: 'sucess',
        html: '<div><h2>Eliminación Exitosa</h2></div><div><h4>El departamento se ha eliminado en la base de datos</h4></div>',
        width: '40%'
    }).then(function () {
        window.location = "ListarDepartamentos.aspx";
    })
}

function dptonoeliminado() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error al eliminar el departamento</h2></div><div><h4>Error al conectar con la base de datos, no se ha realizado la emliminación</h4></div>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'
    })
}

function dptoregistrado() {
    Swal.fire({
        icon: 'sucess',
        html: '<div><h2>Registro exitoso</h2></div><div><h4>El departamento se ha registrado en la base de datos</h4></div>',
        width: '40%'
    }).then(function () {
        window.location = "ListarDepartamentos.aspx";
    })
}

function dptonoregistrado() {
    Swal.fire({
        icon: 'error',
        html: '<div><h2> Error al registrar departamento</h2></div><div><h4>Error al conectar con la base de datos, no se ha realizado la icerción</h4></div>',
        width: '40%',
        confirmButtonColor: '#C72E2E',
        confirmButtonText: '<h5>Intentar otra vez</h5>'
    })
}

// Cargos
