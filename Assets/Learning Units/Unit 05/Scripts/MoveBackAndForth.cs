using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    // DIRECTIONS: Get the objects to move back and forth.
    List<GameObject> ObjectsToMove { get; set; }
    List<UnityEngine.Vector3> startPositions;
    List<UnityEngine.Vector3> endPositions;

    float moveAmount = 0.1f; // Don't change this line!
    float lerpAmount = 0; // Don't change this line!

    // Start is called before the first frame update
    void Start()
    {
        ObjectsToMove = GetComponent<MoveObjects>().ObjectsToMove; // Keep this line and don't change it.
        GetComponent<MoveObjects>().enabled = false; // Keep this line and don't change it.

        //DIRECTIONS: Uncomment the lines below and fix them
        startPositions = new List<UnityEngine.Vector3>();
        endPositions = new List<UnityEngine.Vector3>();
        foreach (GameObject obj in ObjectsToMove)
        {
            startPositions.Add(obj.transform.position); // one of these lists needs this kind of position...
            endPositions.Add(obj.transform.position + new UnityEngine.Vector3(0, 0, 10f)); // another one needs another...
        }
    }

    // Update is called once per frame
    void Update()
    {
        //DIRECTIONS: Uncomment the lines below and fix them
       // UnityEngine.Debug.Log("num objs: " + ObjectsToMove.Count);

        for (int i = 0; i < ObjectsToMove.Count ; i++)
        {
            ObjectsToMove[i].transform.position = UnityEngine.Vector3.Lerp(startPositions[i], endPositions[i], lerpAmount);
            // UnityEngine.Debug.Log(startPositions[i] + " end: " + endPositions[i]);
            //UnityEngine.Debug.Log(i);

        }

        //Don't change anything below here!
        lerpAmount += moveAmount;

        if (lerpAmount < 0 || lerpAmount > 1)
        {
            moveAmount = -moveAmount;
        }
        
    }
}
