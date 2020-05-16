using System.Collections;
using System.Collections.Genetic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLevelController : MonoBehaviour
{

    public void changeLevel (string sceneName)
    {
        SceneManager.LoadScene (sceneName);
    }

    public void exitGame ()
    {
        Application.Quit ();
    }

}