Proyecto de una API NET CORE para una biblioteca.La API permite agregar, modificar y eliminar libros.

<h2>Requerimientos</h2>
-.NET 6</br>
-SQL server 2019</br>

<h2>Instalación</h2>
- Clona este repositorio en tu computadora.</br>
- Crea una base de datos en SQL SERVER</br>
- Modifica la configuración de la base de datos en el archivo Program.cs para que apunte a tu base de datos.</br>
- Abrí el proyecto desde Visual Studio y corre el proyecto</br>

<h2>Uso</h2>
La API tiene los siguientes endpoints:

GET api/libro: Retorna la lista de libros en la biblioteca. </br>
GET api/libro/{id}: Retorna el libro con el id especificado.</br>
POST api/libro: Agrega un libro a la biblioteca.</br>
PUT api/libro/{id}: Actualiza el libro con el id especificado.</br>
DELETE api/libro/{id}: Elimina el libro con el id especificado.</br>
