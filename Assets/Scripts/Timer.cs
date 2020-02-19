using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI clock;
    private float intal = 400f;
    private float remain = 0f;
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
        clock.text = con.ToString();


    }
}
