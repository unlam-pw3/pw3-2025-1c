
document.addEventListener("DOMContentLoaded", function () {
    const boton = document.getElementById("enviar");
   
    if (!boton) {
        console.error("No se encontró el botón con id 'enviar'");
        return;
    } else {
        console.log("se encontro");
    }

boton.addEventListener("click", function () {

    let marca = document.getElementById("marca").value;
    let modelo = document.getElementById("modelo").value;
    let precio = document.getElementById("precio").value;
    let km = document.getElementById("km").value;

    console.log(marca,modelo,precio,km)


    const vehiculo = {
        Marca: marca,
        Modelo: modelo,
        Precio: parseInt(precio),
        Kilometros: parseInt(km)
    };



    fetch("/api/Concesionaria/AgregarVehiculo", {

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

});

});