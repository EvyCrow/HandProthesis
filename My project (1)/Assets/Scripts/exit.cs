using UnityEngine;
using UnityEngine.SceneManagement;
/*
    little boy to leave the app
    works only in builds
 */

public class exit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        { 
            //SceneManager.LoadScene("menu");
            Application.Quit();
        }
    }
}
