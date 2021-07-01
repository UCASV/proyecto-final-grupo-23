# Aspectos técnicos 
A continuación les explicaremos los aspectos técnicos sobre los software que utilizamos para realizar nuestro proyecto a detalle.

###  Software
El software que utilizamos para desarrollar nuestro proyecto fue **Microsoft Visual Studio**, es un IDE que se encuentra disponible para Windows y macOS. Lo cual cuenta con una variedad de lenguajes compatibles como C++, C#, Visual Basic .NET, Java, Python, Ruby y PHP, igual nos  brindan entornos de desarrollo web como ASP.NET, Django, etc.
En nuestro caso utilizamos **.NET** para poder realizar nuestro programa en la versión más actualizada que es la 5.0, con en formato  de **Windows Forms Apps.**


#### Sistema Operativo
El sistema operativo que se utilizamos todos los integrantes para el desarrollo del proyecto fue Windows con las versión 10.

#### Paquetes Externos 
Los paquetes externos que implementamos en el programa son los **nugets** lo cual fueron 3 con sus respectivas versiones recientes más estables:

-MySql.EntityFrameworkCore 5.0.3.1

-Microsoft.EntityFrameworkCore 5.0.7

-Microsoft.EntityFreameworkCore.Design 5.0.7


# Instalación 

### Visual Studio
Gracias a Microsoft fue que utilizamos **Visual Studio 2019** tiene su propia página web en el cual se encuentra su apartado de descarga , al ingresar al link “https://visualstudio.microsoft.com/es/downloads/” encontramos tres opciones para descargar el .exe que son Comunidad, Profesional y Enterprise. En nuestro caso instalamos el de la comunidad ya que ese IDE es el único con licencia gratuita y en cambio los demás tiene una prueba gratuita pero luego se le pedirá realizar un gasto ya que se paga la licencia. Ya dentro del Instalador el usuario podrá configurar los lenguajes y las herramientas que desea instalar para acceder a ellas 


### MySQL Comunity Server
Donde realizamos nuestra base de datos para el desarrollo del proyecto fue en **MySQL Comunity Server** con la versión de 8.0.25 y en el cual se puede acceder a la descarga en el siguiente link **https://dev.mysql.com/downloads/windows/installer/8.0.html**  lo cual instalamos la segunda opción. Al tener el instalador abierto tendremos que hacer cosas adicionales, comenzando donde nos pedirán el tipo de configuración adaptar para el caso de uso, el cual nosotros escogimos el **Custom**, luego tendremos que seleccionar los productos que utilizaremos con su respectiva versión 8.0.25,son 4 productos y las cuales se instalaron así:

1.MySQL Server -> MySQL Server

2.Aplications -> MySQL Workbench

3.Documentation -> MySQL documentation

4.Documentación -> Samples and Examples

Luego no se modifica lo demás que nos piden hasta que nos salga crear una contraseña, después de eso se verifica la conexión, el nombre del root y la contraseña que digitamos, finalmente se deja todo predeterminado hasta que se finalice el proceso de instalación.

### Base de datos existente
En el proyecto contamos con una base de datos creada por nosotros en el cual utilizamos una cadena de conexión al IDE de Visual Studio para vincularlo, ya que contaba con las tablas y valores hechas para solo desarrollarlo por código.


### Patron de diseño 
**Abstract  Factory** fue el patron que utilizamos ya que podemos trabajar con objetos teniendo distintas familias de manera que ellas no se lleguen a mezclar entre si y siempre exista la transparencia del tipo de familia concreta que se usa. Aunque existe un problema y es al momento de querer crear diferentes familias de objetos, dando ejemplos como llegar a crear interfaz grafica con distinta variedad(boton,ventana, combobox, etc)
