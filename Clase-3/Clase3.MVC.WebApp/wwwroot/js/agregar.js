
document.addEventListener("DOMContentLoaded", function () {
    const boton = document.getElementById("enviar");

    if (!boton) {
        console.error("No se encontró el botón con id 'enviar'");
        return;
    }

    boton.addEventListener("click", function () {

        agregarVehiculo()

    });
        });

    function agregarVehiculo() {
        let marca = document.getElementById("marca").value;
        let modelo = document.getElementById("modelo").value;
        let precio = document.getElementById("precio").value;
        let km = document.getElementById("km").value;
        let foto = document.getElementById("foto").files[0];


        console.log(marca, modelo, precio, km)

        const formData = new FormData();

        formData.append("Marca", marca);
        formData.append("Modelo", modelo);
        formData.append("Precio", precio);
        formData.append("Kilometros", km);
        formData.append("FotoUrl", foto);

        const vehiculo = {
            Marca: marca,
            Modelo: modelo,
            Precio: parseInt(precio),
            Kilometros: parseInt(km)
        };



        fetch("/api/Concesionaria/AgregarVehiculo", {

            method: 'POST',
            
            body: formData,
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