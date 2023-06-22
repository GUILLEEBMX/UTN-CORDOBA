

async function loadTable() {


    try {

        let response = await fetch('https://localhost:7070/api/people');
        response = await response.json();

        const cuerpoTabla = document.querySelector('tbody');

        response = response.forEach((x) => {
            const fila = document.createElement('tr')
            fila.innerHTML += `<td>${x.name}</td>`
            fila.innerHTML += `<td>${x.secondName}</td>`
            fila.innerHTML += `<td>${x.age}</td>`

            cuerpoTabla.append(fila)
        });

        cuerpoTabla.append(fila)

    } catch (err) {

        console.log(err);

    }


}


async function loadDropDown() {

    const result = document.getElementById("dropdown");

    response = response.forEach((x) => {
        const fila = document.createElement('tr')
        fila.innerHTML += `<td>${x.name}</td>`
        fila.innerHTML += `<td>${x.secondName}</td>`
        fila.innerHTML += `<td>${x.age}</td>`

        cuerpoTabla.append(fila)
    });

}


