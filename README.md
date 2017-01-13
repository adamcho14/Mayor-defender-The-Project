# Mayor-defender-The-Project
Repository structure and decription: 
Mayor-defender-The-Project
- Assets
-- Materials
---> Definitions of all materials used by objects
-- Prefabs
---> Definitions of prebafs from which all the objects are instantiated
-- Scripts
---> My code is here: This is the code of the whole game. It is objects' behavior, connections between them etc.
-- Red Square.unity
---> This is the main scene. Its name comes from the first item ever placed into this scene. The item no longer exists.
- Project Settings
--> Various automatically generated settings and managers

Characters in the game and their behavior:
-> Sheriff: yellow body. Controlled by user. He moves to the right and left when arrow keys pressed. 
He shoots a projectile to the mouse position on space key pressed. When he's hit by another projectile, he falls down and the game is over.
-> Mayor: blue body. When he's hit by a projectile, he falls down and the game is over.
-> Bandit: red body. Released by the SPAWNER. He is supposed to shoot to the MAYOR when he reaches certain distance from him. 
YET, HE ONLY SHOOTS TO THE FRONT - TODO: This has to be fixed!

Other non-character objects in the game and their behavior:
-> Plane: on which the game is played.
-> Bullet: released by the BULLET SPAWN attached to the SHERIFF controlled by user or to a BANDIT when the BANDIT is close to the MAYOR. 
The BULLET and the other object are destroyed on collision. When the other object is either the MAYOR or the SHERIFF, the game is over.
-> Buildings: represented by two cubes on the sides of the plane.
-> Spawner: Releases bandits.
-> Bullet spawn: releases bullets.
-> Weapon: hope it looks nice.

Cameras:
-> Main camera: Perspective view. The closest to the MAIN CAMERA is the SHERIFF, then the MAYOR. 
The BANDITS can be seen on both sides of the MAIN CAMERA view.
-> Debug camera: Used to have different view on what's going on while debugging.
