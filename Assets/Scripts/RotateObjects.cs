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

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ObjectsToRotate.Count; i++)
        {
            ObjectsToRotate[i].transform.position = new Vector3(0, 0, i * 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (canWeRotate)
        {
            foreach (GameObject thisGameObject in ObjectsToRotate)
            {
                thisGameObject.transform.position += new Vector3(.01f, 0, 0);
            }
        }
    }

    public void StartMovement()
    {
        canWeRotate = true;
    }
}
