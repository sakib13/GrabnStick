using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 3.0f;
    public string nextSceneName;
    void Start()
    {
        StartCoroutine(EndSceneAfterTime());
    }

    IEnumerator EndSceneAfterTime()
    {
        // Wait for the specified amount of time
        yield return new WaitForSeconds(timer);

        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}
