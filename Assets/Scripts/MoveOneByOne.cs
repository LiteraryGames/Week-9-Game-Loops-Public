using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOneByOne : MonoBehaviour
{
    // LOOK HERE!
    // Do not move, change, or add anything in this script!
    public List<GameObject> ObjectsToMove { get; set; }

    GameObject currentObjectToMove;

    int currentIndexOfObjectToMove = 0;

    Vector3 currentObjectStartPosition;

    // Start is called before the first frame update
    void Start()
    {
        ObjectsToMove = GetComponent<MoveObjects>().ObjectsToMove; // We're just grabbing the list of objects
        GetComponent<MoveObjects>().enabled = false; // We only wanted the list of objects from this
        // component, then we'll disable it because we're moving these objects a different way. 

        for (int i = 0; i < ObjectsToMove.Count; i++)
        {
            ObjectsToMove[i].transform.position = new Vector3(0, 0, i * 2f);
        }
        currentObjectStartPosition = ObjectsToMove[currentIndexOfObjectToMove].transform.position; // We grab the 
        // position of the first object we want to move. 
    }

    // Update is called once per frame
    void Update()
    {
        ObjectsToMove[currentIndexOfObjectToMove].transform.Translate(.01f, 0, 0);

        if (Vector3.Distance(ObjectsToMove[currentIndexOfObjectToMove].transform.position, currentObjectStartPosition) > 10)
        {
            ObjectsToMove[currentIndexOfObjectToMove].SetActive(false);
        }
    }

    public void MoveNextObject()
    {
        if (currentIndexOfObjectToMove < ObjectsToMove.Count - 1)
        {
            currentIndexOfObjectToMove++;
            currentObjectStartPosition = ObjectsToMove[currentIndexOfObjectToMove].transform.position;
        }
    }
}
