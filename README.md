# Week-9-Game-Loops-Public

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
