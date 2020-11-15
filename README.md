# DetectorObstaculos

## Autor: Adrián González Hernández
### signatura: Inteligencia Artificial
### Lenguaje: C#
### Herramientas: .NET Framework, Visual Studio

Para ejecutar el código, debe abrirse visual Studio, compilar desde la barra superior y abrir la ruta de compilación. En su defecto, si se está usando W10 Pro, puede ejecutarse el archivo ya compilado
presente en la carpeta obj del directorio del proyecto.


## Ficheros

### Program.cs
Fichero donde se encuentra la función main, que únicamente abre la interfaz gráfica

### Simulator.cs
Clase principal del programa. Aquí se encuentran las funciones heurísticas y el Algoritmo A*

### NodeA.cs
Clase del Nodo utilizado en el algoritmo A*

### Home.cs
Interfaz gráfica de la Home del programa. Funciones de toma de datos

### Result.cs
Interfaz de a ventana de resultados

### ObstacleSelector.cs
Interfaz para escribir los obstáculos de forma manual

### Obstacuos.txt
Aquí se pueden introducir los obstáculos para cargar desde fichero

#### El resto de ficheros son utilizados para el diseño de las interfaces o bibliotecas del framework
