Problema 1:
Gesti�n de Inscripciones para un Gimnasio

Un gimnasio necesita gestionar las inscripciones de sus miembros. Cada miembro tiene un nombre, una fecha de inscripci�n y un plan de suscripci�n (mensual o anual). El gimnasio tambi�n tiene una lista de clases disponibles, pero los miembros no se inscriben a clases directamente.

Pregunta:

�Es necesario utilizar persistencia para las clases disponibles en el gimnasio?

Rta: si, porque los usuarios no tienen registro de en que clases est�n.

Pregunta:

�Se debe usar un Diccionario para los miembros del gimnasio?

Rta: No, porque no tienen un atributo que diferencie a cada miembro, ejemplo un c�digo �nico.

Problema 2:
Sistema de Gesti�n de Mascotas en una Veterinaria

Una veterinaria necesita gestionar sus mascotas. Cada mascota tiene un nombre, una especie (perro, gato, etc.) y su historial m�dico. Los due�os de las mascotas no tienen cuentas individuales ni se les asigna un n�mero de cliente.

Pregunta:

�Es necesario aplicar encapsulamiento en la clase Mascota?

Rta: No, ya que en este caso las especies no tienen atributos distintos entre ellas, se puede utilizar la clase Mascota.

Pregunta:

�Es necesario implementar persistencia para los due�os de las mascotas?

Rta: No, porque no se guarda informaci�n de ellos.

Problema 3:
Sistema de Reservas de Canchas Deportivas

Un club deportivo permite a los socios reservar canchas de tenis o f�tbol por un n�mero limitado de horas. Cada reserva debe incluir el nombre del socio, el tipo de cancha y la duraci�n de la reserva. No hay tarifas ni precios asociados a la reserva.

Pregunta:

�Se requiere el uso de un Enum para los tipos de cancha?

Rta: No, porque no hacemos nada m�s con la informaci�n adem�s de guardarla.

Pregunta:

�Es necesario usar una colecci�n de tipo Pila para gestionar las reservas?

Rta: No, las reservas no deber�an ser de tipo pila o tipo cola, ya que pueden agregarse reservas entre otras.

Problema 4:
Biblioteca P�blica con Pr�stamos de Libros

Una biblioteca p�blica gestiona el pr�stamo de libros a sus usuarios. Cada libro tiene un t�tulo, autor, n�mero de p�ginas y fecha de publicaci�n. Los usuarios pueden prestar varios libros a la vez, y deben devolverlos en un plazo de dos semanas.

Pregunta:

�Deber�as utilizar un Array para gestionar los libros prestados por cada usuario?

Rta: No, ya que los libros se van a ir prestando y devolviendo, y un array no permite agregar o eliminar elementos.

Pregunta:

�Se requiere persistencia para almacenar la informaci�n de los libros disponibles en la biblioteca?

Rta: Si, porque los usuarios no guardan informaci�n de los libros pedidos.

Bonus:
�Cu�l es la diferencia entre clase Abstracta y una Interfaz?

Rta:
Una clase abstracta hereda sus atributos y m�todos a sus hijas, pero no es posible de instanciar por si sola.
Mientras que una interf�z es un contrato que tienen que seguir las clases que la implementen, no hereda sus m�todos,
obliga a la clase a implementarlos.