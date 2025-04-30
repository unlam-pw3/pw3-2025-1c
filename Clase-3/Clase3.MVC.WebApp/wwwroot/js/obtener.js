

window.addEventListener("load", function () {

    obtenerDatos()
});



document.getElementById("buscador").addEventListener("keyup", function (event) {
    buscador(event)

});

function buscador(event) {
    let texto = event.target.value;

    const tabla = document.getElementById("tabla");
    tabla.innerHTML = "";
    if (texto == "") {
        obtenerDatos()
        return
    }

    fetch(`/api/Concesionaria/Buscar?buscar=${texto}`, {

        method: 'GET'
    })
        .then(response => {
            if (!response.ok) {
                throw new Error(`Error: ${response.status}`);
            }
            return response.json();
        })
        .then(vehiculos => {



            vehiculos.forEach(auto => {
             
                const fila = document.createElement("tr");

                fila.innerHTML = `
                    <td>${auto.marca}</td>
                    <td>${auto.modelo}</td>
                    <td>$${auto.precio}</td>
                  
                    <td>${auto.kilometros}</td>
                    <td><img src="${auto.url}" alt="Foto del auto" style="width:100px; height:auto;" /></td>
                 
                    <td>
                        <a class="btn btn-edit" href="/Vehiculos/Editar?id=${auto.id}">Editar</a>
                        <button class="btn btn-delete eliminar" data-id="${auto.id}">Eliminar</button>
                    </td>
                `;

                tabla.appendChild(fila);
            })

        })
        .catch(error => {

            console.error("Ocurrio un error:" + error)


        });

}

function obtenerDatos() {
    let tabla = document.getElementById("tabla");

    fetch('/api/Concesionaria/ObtenerVehiculos')
        .then(response => {
            if (!response.ok) {
                throw new Error(`Error: ${response.status}`);
            }
            return response.json();
        })
        .then(vehiculos => {
            vehiculos.forEach(auto => {
                const fila = document.createElement("tr");

                fila.innerHTML = `
                    <td>${auto.marca}</td>
                    <td>${auto.modelo}</td>
                    <td>$${auto.precio}</td>
                    <td>${auto.kilometros}</td>
                     <td><img src="${auto.url}" alt="Foto del auto" style="width:100px; height:auto;" /></td>
                    <td>
                        <a class="btn btn-edit" href="/Vehiculos/Editar?id=${auto.id}">Editar</a>
                        <button class="btn btn-delete eliminar" data-id="${auto.id}">Eliminar</button>
                    </td>
                `;

                tabla.appendChild(fila);
            });


            document.querySelectorAll('.eliminar').forEach(button => {
                button.addEventListener('click', function () {
                    const id = this.getAttribute('data-id');
                    console.log("id: " + id);

                    fetch(`/api/Concesionaria/Eliminar?id=${id}`, {
                        method: 'DELETE'
                    })
                        .then(response => {
                            if (!response.ok) {
                                console.log(`Error: ${response.status}`);
                            }
                            return response.text();
                        })
                        .then(vehiculo => {
                            console.log("Vehículo eliminado:", vehiculo);

                            this.closest("tr").remove();
                        })
                        .catch(error => {
                            console.error('Error al eliminar el vehículo:', error);
                        });
                });
            });
        })


        .catch(error => {
            console.error('Error al obtener los vehículos:', error);
        });

}