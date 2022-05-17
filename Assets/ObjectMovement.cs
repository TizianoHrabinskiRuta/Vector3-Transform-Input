using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Movement;
    public Vector3 Rotation;
    public Vector3 ScaleAmount;
    public GameObject Cube;
    void Start()
    {
        Cube.transform.position = Movement;
        Cube.transform.eulerAngles = Rotation;
        Cube.transform.localScale = ScaleAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
