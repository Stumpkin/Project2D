using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Cam : MonoBehaviour
{

    public Transform Target2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Target2D.position.x + 2.5f, Target2D.position.y + 3, transform.position.z);
    }
}
