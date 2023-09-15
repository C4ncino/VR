
# VR

Aquí se encuentran las bases para el uso de VR con unity v21.3.17


## Prerequisitos

Tener [Unity Hub](https://unity.com/es/download) instalado e instalar la version de Unity 21.3.17 de unity para evitar conflictos por actualizaciones

## Instalación 

- Copia el repositorio

```bash
  git clone git@github.com:C4ncino/VR.git
```
- Abre Unity Hub y añade un proyecto

- Busca la carpeta del proyecto y seleccionala

- Abre el Porjecto
## Esctrucutura del proyecto

En caso de no necesitar abrir el proyecto la carpeta que se puede importar a otros proyectos se encuentra bajo la siguiente ruta

```
\Assets
--\Character
```
En la carpeta `Character` se encuentra todos los acrhivos necesarios para conectar el VR con el proyecto de esta forma no se tienen que importar assets de otras librerías, ya que ya cuenta con los assets de control de VR y de seguimiento de manos para los visores que lo soportan. 

Ademas dentro de la carpeta se encuentran los scripts generados adicionales y los modelos 3D de los personajes que se utilizaron

```
\Character
--\Characters
--\Scripts
```

## Archivos de Scripts

1. **MovementInput.cs**: Este script se encarga de gestionar la entrada del jugador para el movimiento del personaje.

2. **PhysicRig.cs**: Este script define un sistema de físicapara el jugaro.

3. **TestingInputSystem.cs**: Este script parece estar relacionado con pruebas o desarrollo del sistema de entrada del juego para probar la entrada de teclado.

4. **VRRig.cs**: Este script se encarga de poder añadir un modelo 3d de personaje al jugador.

## Archivos de Unity Input System

1. **PlayerInputs.inputactions**: Este archivo define las acciones de entrada del jugador en el juego.

## Archivos de UI

- **UI_Player.cs**: Este script se usa para controlar la UI del jugador.

## Apoyos

Por otro lado se puede tener ayuda extra mediante los siguientes tutoriales de [Valem en YouTube](https://www.youtube.com/@ValemTutorials/videos)


## Autor

[@C4ncino](https://www.github.com/C4ncino)
