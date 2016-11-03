using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToSchene(string sceneName)
    {
        Debug.Log("My method was called!");
        Debug.Log(Time.time);
        SceneManager.LoadScene(sceneName);
    }
}
