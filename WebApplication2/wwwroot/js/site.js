//Registro
$('#senha, #repetirsenha').on('keyup', function () {
    if ($('#senha').val() == $('#repetirsenha').val()) {
        $('#message').html('Matching').css('color', 'green');
    } else
        $('#message').html('Not Matching').css('color', 'red');
});

$('#email, #repetiremail').on('keyup', function () {
    if ($('#email').val() == $('#repetiremail').val()) {
        $('#message').html('Matching').css('color', 'green');
    } else
        $('#message').html('Not Matching').css('color', 'red');
});


function repetirsenha() {
    alert(document.getElementById("senha"));
    var senha;
    var senha2;
        senha2 =document.getElementById("repetirsenha");
         senha = document.getElementById("senha");
  
    if (senha == senha2) {
        
        document.getElementById("repetirsenha").classList.add('form-control is-valid');
    } else {
        senha.classList.add('form-control is-invalid');
        senha2.classList.add('form-control is-invalid');
    }

}

function repetiremail() {

    var senha = document.getElementById("email");
    var senha2 = document.getElementById("repetiremail");

    if (senha == senha2) {
        senha.classList.('form-control is-valid');
        document.getElementById("repetiremail").classList.add('form-control is-valid');
    } else {
        document.getElementById("email").classList.add('form-control is-invalid');
        document.getElementById("repetiremail").classList.add('form-control is-invalid');
    }


}


function alerta() {
    alert();
}



// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
