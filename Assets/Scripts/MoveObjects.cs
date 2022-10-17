using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    // These objects are given to this Component from another Component, so 
    // don't change this Property!
    public List<GameObject> ObjectsToApplyForceOnto { get; set; } // we'll talk more about 
    // Properties in a future week

    bool canWeMove;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ObjectsToApplyForceOnto.Count; i++)
        {
            ObjectsToApplyForceOnto[i].transform.position = new Vector3(0, 0, i * 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (canWeMove)
        {
            foreach (GameObject thisGameObject in ObjectsToApplyForceOnto)
            {
                thisGameObject.transform.position += new Vector3(.01f, 0, 0);
            }
        }
    }

    public void StartMovement()
    {
        canWeMove = true;
    }
}
