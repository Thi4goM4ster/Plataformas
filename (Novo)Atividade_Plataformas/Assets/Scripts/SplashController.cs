using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadMainMenuAfterDelay());
    }

    IEnumerator LoadMainMenuAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        GameManager.instance.LoadScene("MainMenu");
    }
}