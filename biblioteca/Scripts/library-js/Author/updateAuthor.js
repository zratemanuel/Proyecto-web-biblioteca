$(document).ready(function () {
    jQuery.validator.addMethod("lettersonly", function (value, element) {
        return this.optional(element) || /^[ña-z\s]+$/i.test(value);
    }, "Sólo se permiten letras");

    // mZarate : -- Validaciones generales para el formulario "Update Author" --

    $('#updateAuthorForm').validate({
        rules: {
            Nombre: {
                required: true,
                minlength: 4
            },
            Nacionalidad: {
                required: true,
                lettersonly: true,
                minlength: 2
            },
            FechaNacimiento: {
                required: true
            }
        },
        messages: {
            Nombre: {
                required: "El nombre del autor es requerido",
                minlength: "Debe ingresar al menos (4) caracteres"
            },
            Nacionalidad: {
                required: "La nacionalidad del autor es requerida",
                lettersonly: "Sólo se permiten letras",
                minlength: "Debe ingresar al menos (2) caracteres"
            },
            FechaNacimiento: {
                required: "La fecha de nacimiento es requerida"
            }
        },
        highlight: function (element) {
            $(element).css('background', '#ffdddd');
        },
        unhighlight: function (element) {
            $(element).css('background', '#ffffff');
        },
        errorPlacement: function (error, element) {
            let placement = '.container-fluid-no-padding';
            if ($(placement).find(element).length) {
                $(placement).append(error)
            } else {
                error.insertAfter(element);
            }
        }
    });
});