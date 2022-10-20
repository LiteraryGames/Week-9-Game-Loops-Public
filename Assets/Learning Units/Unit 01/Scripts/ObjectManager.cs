using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // DIRECTIONS: You do not need to write any new code for Unit 01, nor do you need to fix the scene, 
    // nor do you need to adjust project settings. You need to rearrange the lines of code, though;
    // The goal is for the red cubes to spread out in a line and move across the screen.

    [SerializeField] List<GameObject> objects;

    MoveObjects objectMover;
    /*Unity calls Awake only once during the lifetime of the script instance. A script's lifetime lasts until the Scene that contains it is unloaded. 
     * If the Scene is loaded again, Unity loads the script instance again, so Awake will be called again. 
     * If the Scene is loaded multiple times additively, Unity loads several script instances, so Awake will be called several times (one on each instance).
     */
    void Awake()
    {
        objectMover = GetComponent<MoveObjects>();
        objectMover.ObjectsToMove = objects;
        objectMover.StartMovement();

    }
    // Start is called before the first frame update
    void Start()
    {
    }
}
