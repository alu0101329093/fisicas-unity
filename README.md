# Introducción a los scripts y física en Unity

## Creación de diferentes escenarios con físicas

### Ninguno de los objetos será físico

Un escenario normal con solo un plano, una esfera flotando y un cubo flotando.
![](/fisicas-a.png)

### La esfera tiene físicas, el cubo no

Aquí se puede ver que como le hemos dado físicas a la esfera esta tiene gravedad y además colisiona.
![](/fisicas-b.gif)

### La esfera y el cubo tienen físicas

Ahora como el cubo tiene físicas tambien cae.
![](/fisicas-c.gif)

### La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo

Al aumentar la masa de un objeto esto solo cambia como reacciona este al chocar con otro objeto y no al caer pero se puede ver en el `Inspector` que la gavedad de la esfera esta a 10.
![](/fisicas-d.gif)

### La esfera tiene físicas y el cubo es de tipo IsTrigger

La esfera al ser un `trigger` podemos detectar como el cubo la atraviesa y se muestra por consola.
![](/fisicas-e.gif)

### La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas

Al ser un objeto `trigger` la esfera y además tener físicas esta cae sin parar ya que el ser `trigger` desactiva las colisiones con las cosas pero si las detecta. Podemos ver como detecta que atraviesa el plano.
![](/fisicas-f.gif)

### La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ

Se puede ver que como la esfera tiene más masa esta empueja más al cubo cuando se chocan entre si. Además como el cubo tiene bloqueado la rotación en el plano XZ aunque se quede en el borde del plano aguantando con una punta es incapaz de caerse ya que no puede rotar.
![](/fisicas-g.gif)

## Control de un cubo con un script como si fuera un CharacterControllers

### Añadir movimiento al cubo

A través del script `CharacterController` accedemos a los ejes virtuales `Horizontal` y `Vertical` y con estos modificamos el `Transform` del cubo con `Translade`.
![](/controller-a.gif)

### Añadir un variable velocidad

A través de añadir un variable para la velocidad podemos modificar está más facilmente.
![](/controller-b.gif)

### Añadir rotación sobre el eje OY

Para agregar rotación necesitamos crear un nuevo eje virtual,luego detectarlo y utilizarlo junto con `Rotate`.
![](/controller-c.gif)

## Añadir varios scripts para realizar varias acciones

### Se deben incluir varios cilindros sobre la escena. Cada vez que el objeto jugador colisione con alguno de ellos, deben aumentar su tamaño y el jugador aumentar puntuación

Para esto debemos crear un cilindro al que le añadiremos un script que detecte `OnCollisionEnter` y cuando este colisione con un objeto con la tag player crezca. Además al jugador se le hara algo igual pero se incrementara su variable `points` en vez de crecer.
![](/actions-a.gif)

### Agregar cilindros de tipo A, en los que además, si el jugador pulsa la barra espaciadora lo mueve hacia fuera de él

Para esto agregamos un script a los cilindros que si usamos el espacio modifique el transform en función de la direccion del jugador.
![](/actions-b.gif)

### Se deben incluir cilindros que se alejen del jugador cuando esté próximo

Este cilindro es un poco más dificil, ya que para empezar tendremos que ponerle un objeto vacio dentro al cual le añadiremos un `Sphere Collider` con `isTrigger`. A este objeto deberemos añadirle un script en el que con `OnTriggerStay` moverá el `Transform` del padre respecto al `Transform` player. El radio del `Sphere Collider` será el radio de huida.
![](/actions-c.gif)

### Ubicar un tercer objeto que sea capaz de detectar colisiones y que se mueva con las teclas: I, L, J, M

Esto se puede lograr creando ejes virtuales como `Horizontal` y `Vertical`, pero añadiendoles un 2 al nombre y cambiando las respectivas teclas. Tras esto cambiamos el script `CharacterController` para poder eleguir una id para los ejes virtuales.
![](/actions-d.gif)

### Debes ubicar cubos que que aumentan de tamaño cuando se le acerca una esfera y que disminuye cuando se le acerca el jugador.

Primero debemos crear un script en el que si algo toca el cubo con `OnTriggerEnter` y tiene la tag de `Sphere` este se reducira, mientras que si tiene la tag `Cube` aumentará.
![](/actions-e.gif)
