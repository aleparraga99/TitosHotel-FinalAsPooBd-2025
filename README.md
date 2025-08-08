TITO´S HOTEL

El proyecto forma parte de la instancia de final del espacio curricular de Programación Orientada a Objetos. Se trata de un sistema que sea capaz de gestionar reservas de un hotel.
Se requiere un ABM para las reservas, además de para otras entidades como Pasajero y Habitaciones (con sus respectivos ABM). Las entidades tienen que poseer su  propio CRUD

// Características 
El proyecto respeta una arquitectura MVC, siendo estas las capas principales además de una capa DAO para las respectivas entidades. 


// Tecnologías
Para este proyecto se utiliza el lenguage C# y el IDE Visual Studio. Además, para manejar la base de datos se usa SQL Server Management Studio

// Instalación
Link del repositorio en github:
 https://github.com/aleparraga99/TitosHotel-FinalAsPooBd-2025.git

// Configuración de la base de datos

 SqlConnection conexion = new SqlConnection("Data source = DESKTOP-TQ8IRKU\\SQLEXPRESS; Initial Catalog = TitosHotel; Integrated security = true");
