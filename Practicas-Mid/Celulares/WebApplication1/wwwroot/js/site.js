document.addEventListener('DOMContentLoaded', () => {
    const modalEliminar = document.getElementById('modalEliminar');
    const formEliminar = document.getElementById('formEliminar');

    modalEliminar.addEventListener('show.bs.modal', function (event) {
        const button = event.relatedTarget;
        const id = button.getAttribute('data-id');
        const marca = button.getAttribute('data-marca');
        const modelo = button.getAttribute('data-modelo');

        document.getElementById('celularId').value = id;
        document.getElementById('celularMarca').textContent = marca;
        document.getElementById('celularModelo').textContent = modelo;
    });

    formEliminar.addEventListener('submit', function (e) {
        e.preventDefault();

        const id = document.getElementById('celularId').value;
        console.log("Intentando eliminar celular con ID:", id);

        if (!id) {
            alert("Error: ID no válido.");
            return;
        }

        fetch(`https://localhost:7110/api/Celulares/${id}`, {
            method: 'DELETE'
        })
            .then(response => {
                if (response.ok) {
                    console.log("Eliminado correctamente");
                    location.reload();
                } else {
                    console.error("Error en el DELETE:", response.status);
                    alert("No se pudo eliminar el celular (ver consola).");
                }
            })
            .catch(error => {
                console.error("Error en fetch:", error);
                alert("Error al conectar con el servidor.");
            });
    });
});