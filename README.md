Problema 1:
Gestión de Inscripciones para un Gimnasio

Un gimnasio necesita gestionar las inscripciones de sus miembros. Cada miembro tiene un nombre, una fecha de inscripción y un plan de suscripción (mensual o anual). El gimnasio también tiene una lista de clases disponibles, pero los miembros no se inscriben a clases directamente.

Pregunta:

¿Es necesario utilizar persistencia para las clases disponibles en el gimnasio?

Rta: si, porque los usuarios no tienen registro de en que clases están.

Pregunta:

¿Se debe usar un Diccionario para los miembros del gimnasio?

Rta: No, porque no tienen un atributo que diferencie a cada miembro, ejemplo un código único.

Problema 2:
Sistema de Gestión de Mascotas en una Veterinaria

Una veterinaria necesita gestionar sus mascotas. Cada mascota tiene un nombre, una especie (perro, gato, etc.) y su historial médico. Los dueños de las mascotas no tienen cuentas individuales ni se les asigna un número de cliente.

Pregunta:

¿Es necesario aplicar encapsulamiento en la clase Mascota?

Rta: No, ya que en este caso las especies no tienen atributos distintos entre ellas, se puede utilizar la clase Mascota.

Pregunta:

¿Es necesario implementar persistencia para los dueños de las mascotas?

Rta: No, porque no se guarda información de ellos.

Problema 3:
Sistema de Reservas de Canchas Deportivas

Un club deportivo permite a los socios reservar canchas de tenis o fútbol por un número limitado de horas. Cada reserva debe incluir el nombre del socio, el tipo de cancha y la duración de la reserva. No hay tarifas ni precios asociados a la reserva.

Pregunta:

¿Se requiere el uso de un Enum para los tipos de cancha?

Rta: No, porque no hacemos nada más con la información además de guardarla.

Pregunta:

¿Es necesario usar una colección de tipo Pila para gestionar las reservas?

Rta: No, las reservas no deberían ser de tipo pila o tipo cola, ya que pueden agregarse reservas entre otras.

Problema 4:
Biblioteca Pública con Préstamos de Libros

Una biblioteca pública gestiona el préstamo de libros a sus usuarios. Cada libro tiene un título, autor, número de páginas y fecha de publicación. Los usuarios pueden prestar varios libros a la vez, y deben devolverlos en un plazo de dos semanas.

Pregunta:

¿Deberías utilizar un Array para gestionar los libros prestados por cada usuario?

Rta: No, ya que los libros se van a ir prestando y devolviendo, y un array no permite agregar o eliminar elementos.

Pregunta:

¿Se requiere persistencia para almacenar la información de los libros disponibles en la biblioteca?

Rta: Si, porque los usuarios no guardan información de los libros pedidos.

Bonus:
¿Cuál es la diferencia entre clase Abstracta y una Interfaz?

Rta:
Una clase abstracta hereda sus atributos y métodos a sus hijas, pero no es posible de instanciar por si sola.
Mientras que una interfáz es un contrato que tienen que seguir las clases que la implementen, no hereda sus métodos,
obliga a la clase a implementarlos.