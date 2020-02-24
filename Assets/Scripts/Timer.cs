using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI clock;
    public float intal = 100f;
   
    // Start is called before the first frame update
    void Start()
    {
        clock = GetComponent<TextMeshProUGUI>();
        clock.text = intal.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
        intal -= 1 * Time.deltaTime;
        int con = (int)intal;

        if (con <= 0)
        {
            Controller.Gameover();
            con = 0;
        }

        clock.text = con.ToString();
        

    }
}
