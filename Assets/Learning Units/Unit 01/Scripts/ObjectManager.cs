using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // DIRECTIONS: You do not need to write any new code for Unit 01, nor do you need to fix the scene, 
    // nor do you need to adjust project settings. You need to rearrange the lines of code, though;

    [SerializeField] List<GameObject> objects;

    MoveObjects objectMover;

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
