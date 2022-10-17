using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    // These objects are given to this Component from another Component, so 
    // don't change this Property!
    public List<GameObject> ObjectsToRotate { get; set; } // we'll talk more about 
    // Properties in a future week

    bool canWeRotate;

    void Awake()
    {
        ObjectsToRotate = GetComponent<MoveObjects>().ObjectsToMove;
        canWeRotate = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canWeRotate)
        {
            foreach (GameObject thisGameObject in ObjectsToRotate)
            {
                thisGameObject.transform.Rotate(.1f, 0, 0);
            }
        }
    }

    public void StartMovement()
    {
        canWeRotate = true;
    }
}
