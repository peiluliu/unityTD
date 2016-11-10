using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class changeScence : MonoBehaviour
{

    // function click for the button
    public void changeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }
}


