# Week-9-Game-Loops-Public

## I'm Getting off the Bus!

Students who have had their fill of Unity can do some writing this week instead of the coding below. Type up a "one pager": a single spaced mini-essay that fits on a sheet a paper (attach your one pager as a PDF, please). Work closely with the readings and your experience playing Bennett Foddy's _Getting Over It_. Here are your writing constraints: you must quote from either Freud or Juul and then mix in one or two quotes from Foddy. The whole should address the aesthetics of frustration. What are we doing when we play and fail? Why are we playing if it's not fun? Draw on Foddy's in-game monologue, his blog posts ([this](http://www.foddy.net/2017/01/eleven-flavors-of-frustration/) one on frustration is interesting), or his various public interviews. 

## I'm Staying on the Bus!

## Slides

https://myuva-my.sharepoint.com/:p:/g/personal/jcb2h_virginia_edu/Eea2dlsI9YVArIEl_MjhcTEBubFVVA0LvlisdzQsfHIk0g?e=AhfJ1f

## Level

For all Learning Units EXCEPT Unit 02, the scripts in the Learning Unit (and NOT any scripts outside the Learning Unit) have directions in them and need some kind of fixing. 

In Unit 02, no scripts need fixing, but something else needs to be fixed...

## Bosses

### Bowser

Create a ten by ten cube of cubes (ten cubes wide by ten cubes deep by ten cubes tall), with each cube visible. Have the cubes rotating such that Cube 00 rotates slowly, while Cube 99 rotates quickly, with the other cubes somewhere in between in sequence (slower to faster).

You should not create this by hand, but instead do it programmatically. You will need one additional piece of code we have not covered-- GameObject.Instantiate()

To use this piece of code, you would do the following
```
[SerializeField] GameObject singleCube; // Drag the cube from your scene into this field as 
// a reference in the Inspector

Start()
{
    GameObject newCube = Instantiate(singleCube); // This will create a new cube
    newCube.transform.position = etc etc etc; // You can now refer to this new cube and do stuff with it. 
}
```

NOTE: the above is NOT the solution, but will help you figure out the solution. 

### Hornet

Construct the 3D cube matrix from Bowser, but instead of having the cubes rotate at different speeds, have them spin in a "wave" such that they look like this:

1. Each cube on one 10x10 side of the cube starts to spin, slowly at first, then faster, reaching full speed then slowing down to a stop. 
2. As the 10x10 side is reaching full speed, the next 10x10 group of cubes starts to spin the same way. 
3. The effect should be like a wave going through the crowd in a stadium, but with spinning cubes. 

Try to think how to do this programatically instead of manually. 

You might need the following methods: https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html and / or https://docs.unity3d.com/ScriptReference/Vector3.Slerp.html

BONUS: Accomplish the same, but use Coroutines instead of Update(): https://docs.unity3d.com/ScriptReference/Coroutine.html

### Demon of Hatred

Construct the 3D cube matrix from Bowser, but... bigger. Make the cubes rotate at different speeds, and each one orbit a central point at a speed relative to its proximity. Increase the size of the 3D matrix (i.e. moar cubes) until your computer begins to struggle. Note how many cubes you have. 

Now download the DOTS package and convert your gameobjects to Entities. Run the same simulation and see how many entity cubes you can have working at the same time. https://unity.com/dots 

https://learn.unity.com/tutorial/entity-component-system
