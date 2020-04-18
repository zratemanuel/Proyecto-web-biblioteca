$(function () {
    $('#datetimepicker1').datepicker({
        orientation: 'auto bottom',
        language: 'es',
        autoclose: true,
    });

    $("#FechaNacimiento").addClass("form-control")
        .mask("99/99/9999");
});