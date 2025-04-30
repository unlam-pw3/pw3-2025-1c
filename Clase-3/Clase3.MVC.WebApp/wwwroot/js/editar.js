window.addEventListener("load", function () {

    let boton = document.getElementById("modificar");

    boton.addEventListener("click", function () {

        editar()

    }) 
});

function editar() {

    let marca = document.getElementById("marca").value;
    let modelo = document.getElementById("modelo").value;
    let precio = document.getElementById("precio").value;
    let km = document.getElementById("km").value;
    let id = document.getElementById("Id").value;


    const vehiculo = {
        Marca: marca,
        Modelo: modelo,
        Precio: parseInt(precio),
        Kilometros: parseInt(km),
        Id: id
    };
    console.log(vehiculo);

    fetch("/api/Concesionaria/Editar", {

        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(vehiculo),
    }).then(response => {

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        }
        return response.text();
    }).then(data => {
        console.log('Datos enviados exitosamente:', data);
        window.location.href = '/Home/Index';

    })
        .catch(error => {
            console.error('Error al enviar datos:', error);
        });
    
}