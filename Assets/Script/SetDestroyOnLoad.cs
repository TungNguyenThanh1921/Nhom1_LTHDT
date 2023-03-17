using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);  
    }

    private void OnLevelWasLoaded(int level)
    {

        GameObject[] canvas = GameObject.FindGameObjectsWithTag("Canvas");
        if (canvas.Length > 1)
        {
            Destroy(canvas[1]);
        }
    }
}
