using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    // DIRECTIONS: Get the objects to move back and forth.
    List<GameObject> ObjectsToMove { get; set; }
    List<Vector3> startPositions;
    List<Vector3> endPositions;

    float moveAmount = 0; // Don't change this line!
    float lerpAmount = 0; // Don't change this line!

    // Start is called before the first frame update
    void Start()
    {
        ObjectsToMove = GetComponent<MoveObjects>().ObjectsToMove; // Keep this line and don't change it.
        GetComponent<MoveObjects>().enabled = false; // Keep this line and don't change it.
        
        //DIRECTIONS: Uncomment the lines below and fix them
        //startPositions = new Something;
        //endPositions = new Something;
        //foreach(something in Something)
        //{
        //    someList.Add(something.transform.position); // one of these lists needs this kind of position...
        //    thisOtherList.Add(something.transform.position + new Vector3(0,0,10f)); // another one needs another...
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //DIRECTIONS: Uncomment the lines below and fix them
        //for (something; something.Count something; something)
        //{
        //    someList[something].transform.position = Vector3.Lerp(someOtherList[something], aThirdList[something], lerpAmount);
        //}

        //Don't change anything below here!
        lerpAmount += moveAmount;

        if (lerpAmount < 0 || lerpAmount > 1)
        {
            moveAmount = -moveAmount;
        }
        
    }
}
