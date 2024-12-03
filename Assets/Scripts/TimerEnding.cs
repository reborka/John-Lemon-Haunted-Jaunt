using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerEnding : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
       IEnumerator ReloadAfterTime()
        {
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene(0);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
