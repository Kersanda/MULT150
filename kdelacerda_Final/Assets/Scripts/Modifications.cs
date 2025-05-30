/*

Gauntlet Runner
Modify:

1 - directional light (colour, intensity, etc)
    Adjusted the color, location, and intensity of the directional light. 
2 - fog
    Added fog - made it a bit thick/dense, and blue-ish in color. 
3 - skybox (atmosphere thickness, sky tint, exposure, etc)
    Added a skybox - I made two skyboxes - "Sky" which I used Panaramic and used the given player texture to 
    create an interesting looking sky, that actually looks interesting when in game mode. 
    The "SkyboxNotUsed" is a skybox that I think looks cool when you are in the game edit mode, but looks quite
    boring from the gameplay view, due to how the camera is angled. Wasn't too sure if I could use the player 
    texture per the grading criteria, so made both, and applied the one that gives it a cooler look from playing. 

 ~ obstacle prefab ~
4 - convert to complex object comprised of 3 or more shapes
Hints:
Spikes, rocks, crates, etc
5 - use gameobject hierarchy to keep it organised
    Made an electric fence, has 5 peices to it. 
6 - apply at least 2 new textures
    Imported a wooden texture for the fence, created a shader for the electrical wires. 
7 - add particle system component and customise at least 3 parameters
    Changed duration, start lifetime and size. Changed the color. Shaped adjusted. Size decrease over lifetime. 
    Emission rate over time adjusted. The particle systems are on the wires themselves, not on the overall combined 
    prefab object. Each wire is just slightly different in size or lifespan. 

 ~ powerup prefab ~
8 - modify light component (colour, range, intensity, etc)
    Donut powerup - added red light and adjusted intensity, added red particle effects. Adjusted particle start size,
    duration, color, shape. 
    
 ~ wall ~
9 - convert a wall to prefab, create a variant, and use the variant to replace the other wall in the scene
    Dragged my wall into prefabs, created a variant. 
10 - modify wall material tint colour so that the 2 walls are different colours
    Created a duplicate of the wall material, and applied my new wall material to the variant. Gave it a
    different shader. I like the shaders with cutouts, so I can see my skybox.
*/