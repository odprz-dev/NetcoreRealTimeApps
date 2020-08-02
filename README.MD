# Aplicaciones en tiempo real

## .Net Core

El proyecto de netcore provee mediante hubs y endpoints envio de datos en tiempo real utilizando SignalR. Encontraremos 2 hubs, el primero es usado para enviar información aleatoria cada cierto intervalo de tiempo mediante una funcionalidad dedicada. El segundo permite la comunicacion de 2 o mas clientes para la transmisión de mensajes entre estos clientes permitiendo funcionar como un servicio de mensajeria.

## Angular

Se utiliza angular como capa de presentación. Angular se conectara por medio de un protocolo de websoket al servidor, quien mediante un canal bidireccional sera receptor de los mensajes que los clientes envien y este mismo se encargará de transmitir los mensajes a todos los clientes. El cliente de mensajeria lo nombraremos Chat-App!.

Por otro lado en el segundo ejemplo recibiremos los valores transmitidos por el servidor, para realizar una grafica que se actualice en tiempo real, la comunicación aquí será unidireccional ya que solo recibira informacion enviada desde el servidor y  el cliente no envia´ra ninguna información.

## Compilación

Para correr la aplicación será necesario verificar que  tanto el servidor y el cliente tengan configurados correctamente los puertos, ya que de otro modo se bloqueará la comunicación debído al **CORS**. 

La configuracion de la ruta del cliente se realiza en el  **Satrtup.cs**  `services.AddCors` añadir en el metodo `WitOrigins()`

Angular correrá sobre el puerto por defecto **4200**.

Por defecto el servidor corre mediante protocolo SSL en el puerto: **44339**


