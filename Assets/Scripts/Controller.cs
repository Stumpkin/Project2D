using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator ani;
    public Transform EthanTrans;
    public Rigidbody rb;
    public float speed = 3f;
    public float jumpSpeed = 12;
    public float fallSpeed = 5f;
    private int mod = 4;
    private bool grounded = true;
    private static bool gamesOver = false;
    private float timer = 10f;


    enum AnimationParameters
    {
        Blend
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            mod = 6;
        }

        else
        {
            mod = 4;
        }

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
           
            float raw = Time.deltaTime * 100;
            float jumpMod = (Time.deltaTime < 0.65) ? .6f : 1.2f;
            
            rb.velocity += Vector3.up * 12f;
            grounded = false;
        }

       
        if (rb.velocity.y == 0)
        {
            grounded = true;
        }

        if (rb.velocity.y > 0)
        {
            rb.velocity += Vector3.up * -fallSpeed * Time.deltaTime;
        }
        
        if (gamesOver)
        {
            rb.velocity += Vector3.up * 1000;
        }
        
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float forwardMovement = Input.GetAxis("Horizontal");

        if (forwardMovement != 0)
        {
            float yR = (forwardMovement < 0) ? -90 : 90;
            Vector3 input = new Vector3(0, yR, 0);
            EthanTrans.eulerAngles = input;
            rb.velocity = new Vector3(speed * forwardMovement * mod, rb.velocity.y, rb.velocity.z);

        }

        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }

        ani.SetFloat(AnimationParameters.Blend.ToString(), Mathf.Abs(forwardMovement));

    }
    
    public static void Gameover()
    {
        gamesOver = true;
        Debug.Log("GAME OVER");
    }
    
}
