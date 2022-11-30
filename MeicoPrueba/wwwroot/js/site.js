// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function SumarNum() {

    var firstNumberf = $('#firstNumber').val();
    var secondNumberf = $('#secondNumber').val();

    data = {};

    data.FirstNumber = firstNumberf;
    data.SecondNumber = secondNumberf;

    $.ajax({
        type: 'POST',
        url: '/Home/SumNum',
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(data),
        success: function (response) {
            console.log(response);
        },
        beforeSend: function () {
            alert("ModalCargando");
        }
    });
}