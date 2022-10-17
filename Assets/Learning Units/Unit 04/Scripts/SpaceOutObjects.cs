using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOutObjects : MonoBehaviour
{
    // DIRECTIONS: The goal of this Unit is to get the objects to space out evenly

    // Start is called before the first frame update
    void Start()
    {
        // DIRECTION: Uncomment the lines below, then fix them...
        //GameObject objectsToSpaceOut = GetComponent<MoveObjects>().ObjectsToMove;
        
        //for (something; something something objectsToSpaceOut.Count; something)
        //{
        //    somethingsomething.transform.position = new Vector3(something * 2f,0,0);
        //}

        GetComponent<MoveObjects>().enabled = false; // Keep this line. We've got these objects from this 
        // Component, and we don't need it anymore
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
