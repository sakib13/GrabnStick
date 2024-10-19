using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TMP_Text textUI;

    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;

        score = 0;
        textUI.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPoint()
    {
        score = score + 1;
        textUI.text = score.ToString();
    }

    
}
