document.getElementById("files").onchange = function (e) {
    // Creamos el objeto de la clase FileReader
    let reader = new FileReader();

    // Leemos el archivo subido y se lo pasamos a nuestro fileReader
    reader.readAsDataURL(e.target.files[0]);

    // Le decimos que cuando este listo ejecute el código interno
    reader.onload = function () {
        let preview = document.getElementById('imageRegistrar'),
            image = document.getElementById("imageRegistro");

        image.src = reader.result;

        preview.innerHTML = '';
        preview.append(image);
    };
}