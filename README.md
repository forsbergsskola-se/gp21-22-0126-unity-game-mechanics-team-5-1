*Forsbergs Group Unity Project Jan - Feb 2022* 
## 2.5D Jam-Style Platformer 

In this project we aim to implement different Game Mechanics individually to then combine into one Game. The assignment is for each developer to design and build 2 different implementations of a game mechanic of their choosing. 



## Team Members
- [Johannes Danielsson](https://github.com/MustoLini)
- [Tobias Lundin](https://github.com/AlchemistWolf)
- [Naomi Ruokamo](https://github.com/gremdot)

## Mechanics & Implementations

### Naomi - Flight Mechanic
*I worked on two different flight mechanics. My idea for them was for one to be Player controlled and one that was not dependent on the Players input to give them a different feel and use cases. They are both triggered by individual powerups in the game.*

- *Flight_1_NaomiRuokamo.cs*- This is the mechanic that is not dependent of the players input. It pushes the player upwards for a set float **duration** with the help of a **Vector3** and **player.transform.position**. Including the duration there's also the float **floatSpeed** that can be changed and tweaked in the inspector for a faster ascent. This uses a bool called **isFloating** which is triggered by the **IEnumerator FloatPowerUp**.
- *Flight_2_NaomiRuokamo.cs*- This mechanic is dependent on player input. With Keycodes "W" and "S" the player can fly for a set float **duration**. This is achieved with **AddForce** on the Players Rigidbody. This mechanic also has **flightSpeed** and **dropSpeed** that can be tweaked. This uses a bool called **isFlying** which is triggered by the **IEnumerator FlyPowerUp**.

Both the mechanics use individual Coroutines that are essentially the same except for their bool names- they are both used to disable the PowerUp gameObjects MeshRenderer and BoxCollider. Then disable the Gravity on the Player, sets their isFloating/isFlying bools to true, Then WaitsForSeconds(duration) with the duration float they both have, then after the waiting has finised enables Gravity once more, sets the bools to false and finally destroys the gameObject. 
#

### Tobias - Explode Mechanic
*description*
#

### Johannes - Shooting Mechanic 
*description*
# 
