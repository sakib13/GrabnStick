using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] float remainingTime;
    public TextMeshProUGUI gameOver;
    
    
    void Start()
    {

    }
    void Update()
    {
        remainingTime -= Time.deltaTime;
        timer.text = remainingTime.ToString("F0");

        if (remainingTime < 1)
        {
            gameOver.gameObject.SetActive(true);
        }

    }
   

}