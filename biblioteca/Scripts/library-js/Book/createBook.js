$(document).ready(function () {

    jQuery.validator.addMethod("numbersonly", function (value, element) {
        return this.optional(element) || /^[0-9]+$/i.test(value);
    }, "Sólo se permiten números");

    // mZarate : -- Validaciones generales para el formulario "Create Book" --
    $('#createBookForm').validate({
        rules: {
            Titulo: {
                required: true,
                minlength: 4
            },
            Autor: {
                required: true,
            },
            Editorial: {
                required: true
            },
            Anio: {
                required: true,
                numbersonly: true,
                maxlength: 4
            },
            Tipo: {
                required: true
            }
        },
        messages: {
            Titulo: {
                required: "El título del libro es requerido",
                minlength: "Debe ingresar al menos (4) caracteres"
            },
            Autor: {
                required: "Debe seleccionar un autor"
            },
            Editorial: {
                required: "La editorial del libro es requerida"
            },
            Anio: {
                required: "El año de publicación es requerido",
                maxlength: "Debe ingresar un máximo de (4) caracteres"
            },
            Tipo: {
                required: "Debe seleccionar un tipo de libro"
            }
        },
        highlight: function (element) {
            $(element).css('background', '#ffdddd');
        },
        unhighlight: function (element) {
            $(element).css('background', '#ffffff');
        }
    });

});