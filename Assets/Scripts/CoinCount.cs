using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    private TextMeshProUGUI score;
    private static int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        score = GetComponent<TextMeshProUGUI>();
        score.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = count.ToString();
    }

    public static void Increment()
    {
        count += 1;
    }
}
