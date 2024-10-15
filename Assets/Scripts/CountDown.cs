using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] float remainingTime;
    
    void Start()
    {
        //StartCoroutine(EndSceneAfterTime());
    }
    void Update()
    {
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);




    }
   
}