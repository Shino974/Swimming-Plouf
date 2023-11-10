using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndText : MonoBehaviour
{
    public Text score_txt;

    // Start is called before the first frame update
    void Start()
    {
        score_txt.text = "Score: " + ScoreScript.instance.getscore();
    }
}
