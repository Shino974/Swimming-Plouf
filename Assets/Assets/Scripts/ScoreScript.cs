using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;
    int score = 0;
    public Text score_txt;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        score_txt.text = "Score: " + score.ToString();
    }

    public void Addpoint()
    {
        score += 1;
        score_txt.text = "Score: " + score.ToString();
    }

    public int getscore()
    {
        return score;
    }
}