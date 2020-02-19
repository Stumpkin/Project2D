using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Cam : MonoBehaviour
{
    public float speed = .25f;
    Vector3 move2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move2D = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.Translate(move2D);

    }
}
