using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public int iLevelToLoad;
    public string sLevelToLoad;
    public bool useIntegerToLoadLevel = false;
    public static LoadLevel instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject col = collision.gameObject;

        if (col.name == "Player")
        {
            //LoadScence();
            PopupController.instance.ShowSelectedFloor();
        }
    }

    public void LoadScence()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
}
