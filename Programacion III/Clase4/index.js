//SI O SI BOOSTRAP 
//SI O SI RESPONSIVO
//SI O SI SCRIPT
//SI O SI CLASES
//CSS
//JS PARA VALIDACIONES - EFECTOS - REDIRECCION


// validateFields();

function validateFields() {

    // const name = document.getElementById("txtNombre");
    const secondName = document.getElementById("txtApellido");
    const sexo = document.getElementsByName("sexo");
    const description = document.getElementById("txtDescripcion");
    const sports = document.getElementById("deporte");



    if (secondName.value.length == 0 || description.value.length == 0) {

        alert('Los campos vacios son requeridos...');

        return false;

    }


    let checked = false;

    for (let index = 0; index < sexo.length; index++) {

        if (sexo[index].checked) {

            checked = true;
            break;
        }

    }


    //  checked = sexo.map(x => sexo[x].checked ? true : false);


    if (!checked) {

        alert('Debe seleccionar una opcion');

        return false;


    }

    return true;

}



function save() {


    validateFields() ? Swal.fire({
        title: 'Success',
        text: 'Persona Registrada Correctamente',
        icon: 'success',
        confirmButtonText: 'Cool'
    }) : Swal.fire({
        title: 'Error!',
        text: 'Do you want to continue',
        icon: 'error',
        confirmButtonText: 'Cool'
    });



}