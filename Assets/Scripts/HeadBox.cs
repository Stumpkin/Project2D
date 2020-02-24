using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBox : MonoBehaviour
{
    public Transform Target2D;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Target2D.position.x + .4f, Target2D.position.y + 2.5f, Target2D.position.z);
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "Breakables")
        {
            SCORE.Increment();
            Destroy(trigger.gameObject);
        }
    }
}
