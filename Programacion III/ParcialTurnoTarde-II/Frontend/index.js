
async function validateAllFields() {

    const form = document.querySelector('form');

    form.addEventListener('submit', function (event) {
        event.preventDefault();

        const nombre = document.getElementById('txtNombre').value;
        const apellido = document.getElementById('txtApellido').value;
        const email = document.getElementById('txtEmail').value;
        const edad = document.getElementById('txtEdad').value;

        if (!nombre.length || !apellido.length || !email.length || !edad.length) {
            Swal.fire({
                title: 'Error!',
                text: 'Los campos no pueden estar vacíos. Por favor, revísalos.',
                icon: 'error',
                confirmButtonText: 'Aceptar'
            });
        } else {
            actualizarDocente();
        }
    });



}

async function actualizarDocente() {

    // const nombre = document.getElementById('txtNombre').value;
    // const apellido = document.getElementById('txtApellido').value;
    // const email = document.getElementById('txtEmail').value;
    // const edad = document.getElementById('txtEdad').value;

    const id = await cargarDatos();

    const request = {
        "id": id,
        "nombre": document.getElementById('txtNombre').value,
        "apellido": document.getElementById('txtApellido').value,
        "edad": document.getElementById('txtEdad').value,
        "email": document.getElementById('txtEmail').value
    }



    let result = await fetch('https://localhost:7241/api/docentes/' + id, {
        body: JSON.stringify(request),
        method: 'put',
        headers: {
            'Content-Type': 'application/json'
        }

    });

    result = await result.json();

    if (!result.error) {

        Swal.fire({
            title: 'Éxito!',
            text: 'El docente se actualizó correctamente.',
            icon: 'success',
            confirmButtonText: 'Aceptar'
        }).then((result) => {
            if (result.isConfirmed) {
                form.submit();
            }
        });
    } else {
        Swal.fire({
            title: 'Error!',
            text: 'Ha ocurrido un error!!!',
            icon: 'error',
            confirmButtonText: 'Aceptar'
        });
    }




}

async function cargarDatos() {

    let result = await fetch('https://localhost:7241/api/docentes/27', {
        method: 'get',
        headers: {
            'Content-Type': 'application/json'
        }

    });

    result = await result.json();

    document.getElementById('txtNombre').value = result.nombre;
    document.getElementById('txtApellido').value = result.apellido;
    document.getElementById('txtEmail').value = result.email;
    document.getElementById('txtEdad').value = result.edad;
    document.getElementById('txtNivel').value = result.nivel;

    return result.id;
}