## proyecto de ASP.NET Core 2.2 con MySQL como base de datos 

Me daba una serie de errores que he ido preguntando en el foro de [msdn](https://social.msdn.microsoft.com/Forums/es-ES/3513b716-05a2-4a3a-855b-c59305c670ea/quiero-desarrollar-un-proyecto-aspnet-core-21-con-diferentes-bases-de-datos-postgresql-mysql-y?forum=aspnetmvces)
Por cierto ayudan en los errores que tiene uno dentro del código de las aplicaciones que estes programando.

Una de las sugerencias que me hace es cambiar las tablas que haydentro de Identity concretamnete las que me estan dando problemas que son:

* IdentityUser
* IdentityRole
* IdentityUserClaim
* IdentityUserToken
* IdentityUserLogin
* IdentityRoleClaim
* IdentityUserRole

De esos hay que usar: 

* IdentityUser
* IdentityRole
* IdentityUserLogin
* IdentityUserRole

Lo que no tengo muy claro como se usan por eso pongo esta documentación y de paso preguntarle al que me contesto a mis preguntas en el foro de msdn.

[asp.net identity personalización del modelo de identidad](https://docs.microsoft.com/es-es/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-2.2)

## Solución del problema la tengo debajo 

El problema se soluciona como he dejado estos archivos podréis verlos en: 

[ApplicationDbContext](https://github.com/techcomputerworld/domotica-mysql/blob/master/Domotica-mysql/Data/ApplicationDbContext.cs)

[Startup.cs](https://github.com/techcomputerworld/domotica-mysql/blob/master/Domotica-mysql/Startup.cs)

Algo importante es las clases que tengo dentro de: 

[AplicationUser.cs](https://github.com/techcomputerworld/domotica-mysql/blob/master/Domotica-mysql/Data/CustomIdentity/ApplicationUser.cs) 

Esta clase son varias clases como podéis ver que las he puesto en el mismo fichero, esto no es una buena practica de 
programación pero lo he hecho así porque hacen lo mismo modificar Identity propiamente dicho a nuestras necesidades.

Esto lo he hecho con ayuda del MVP Sergio Parra y Leandro Tuttini de MSDN.

### Pruebas 

He probado con MySQL ahora falta probar estas mismas clases con PostgreSQL si os animáis ya sabéis, yo creo que es buena idea probar con PostgreSQL a mi me parece mejor motor de base de datos que MySQL.

### Pruebas con éxito

Ya funciona la aplicación con MySQL como base de datos en el proyecto. 

### Problemas resueltos

La página de usuarios da un problema que no sé resolver, algo que siempre pasa en el desarrollo de software y la poca experiencia que tengo con este Framework ASP.NET Core 2.2.

Realmente lo que quiero es arreglar el problema que he puesto en pastebin y no se que hacer porque estoy usando para la base de datos una estructura algo diferente de Identity y tengo sin más remedio que usar mis propios objetos.

No sé como arreglarlo este problema la verdad porque tengo que seguir usando mis objetos para que funcione 
la DB MySQL.

[UsuariosController.cs](https://github.com/techcomputerworld/domotica-mysql/blob/master/Domotica-mysql/Areas/Usuarios/Controllers/UsuariosController.cs)

[Pastebin fallo UsuariosController.cs](https://pastebin.com/rcGagzeg)

[ASP.NET Core](https://techcomputerworld.com/asp-net-core-con-mysql-se-puede-conectar/) 

### Problemas no resueltos

Quiero crear un paginador que al final voy a probar con PagedList.Mvc para poder paginar los usuarios, aunque podré usarlo realmente con todo lo que necesite paginar. 

El paginador que estaba usando en el otro proyecto que es de un curso no funciona bien al menos en mi proyecto y no quiero perder mucho tiempo en ver que esta fallando por eso voy a usar PagedList.Mvc.

### Poner en marcha este proyecto

Descargáis el programa que esta en una versión temprana de desarrollo y necesitáis una base de datos MySQL en donde queráis yo por ejemplo la he puesto en una máquina virtual con Virtualbox donde he instalado, SQL Server, PostgreSQL y MySQL para desarrollar creo que es lo más comodo.

El fichero app

## Web del proyecto 

[https://techcomputerworld.com](https://techcomputerworld.com) 

Una empresa de desarrollo de software a medida.





