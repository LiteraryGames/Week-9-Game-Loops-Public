using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWatcher : MonoBehaviour
{
    // DIRECTIONS: The goal is to have the red cubes move, one-by-one across the screen.
    // You do not need to add anything to this script, nor delete anything. You only need to move
    // a line of code. 

    // Check out the MoveOneByOne script in the Assets/Scripts/ folder for clues...

    [SerializeField] MoveOneByOne moveOneByOne;

    Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        
    }

    void OnDisable()
    {
        moveOneByOne.MoveNextObject();
    }
    void OnApplicationQuit()
    {
        
    }

    void OnDestroy()
    {
        
    }
}
