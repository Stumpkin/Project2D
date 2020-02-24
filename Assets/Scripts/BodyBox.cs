using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBox : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Hazard")
        {
            Controller.Gameover();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Coin")
        {
            CoinCount.Increment();
            SCORE.Increment();
            Destroy(col.gameObject);
        }
        
        if (col.gameObject.tag == "GOAL")
        {
            Debug.Log("CLEARED");
            Destroy(col.gameObject);
        }
    }
}
