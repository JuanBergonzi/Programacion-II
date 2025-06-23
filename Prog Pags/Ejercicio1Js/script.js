function limpiarFormulario(formId) {
    document.getElementById(formId).reset();
}

function guardar() {
      const nombre = document.getElementById("Nombre").value.trim();
      const apellido = document.getElementById("Apellido").value.trim();
      const errores = [];

      if (nombre === "") {
        alert("El campo 'Nombre' es obligatorio.");
        errores++ ;
      }
      if (apellido === "") {
        alert("El campo 'Apellido' es obligatorio.");
        errores++ ;
      }

      if (nombre.length > 10) {
        alert("El nombre no puede tener más de 10 caracteres.");
        errores++ ;
      }

      const divErrores = document.getElementById("errores");
      if (errores.length > 0) {
        divErrores.innerHTML = errores.join("<br>");
        divErrores.style.display = "block";
    } else {
        divErrores.style.display = "none";
        alert("Se registró exitosamente");
    }
}



function edad() {
  const fechaNacimiento = document.getElementById("FechaNacimiento").value;

        if (!fechaNacimiento) {
          document.getElementById("Edad").value = "";
          return;
        }

        const hoy = new Date();
        const nacimiento = new Date(fechaNacimiento);

        let anios = hoy.getFullYear() - nacimiento.getFullYear();

        if (nacimiento.getDate()) {
          anios--;
        }

        document.getElementById("Edad").value = anios;
}
