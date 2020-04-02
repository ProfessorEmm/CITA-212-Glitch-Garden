using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {
    [SerializeField] int intTimeToWait = 4;
    int intCurrentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        intCurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (intCurrentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(intTimeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(intCurrentSceneIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
