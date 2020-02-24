using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SCORE : MonoBehaviour
{
    private TextMeshProUGUI score;
    private static int scoreCount;
    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
        score = GetComponent<TextMeshProUGUI>();
        score.text = scoreCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreCount.ToString();
    }

    public static void Increment()
    {
        scoreCount += 100;
    }
}
