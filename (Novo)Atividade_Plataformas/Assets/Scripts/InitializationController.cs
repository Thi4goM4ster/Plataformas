using System;
using UnityEngine;

public class InitializationController : MonoBehaviour
{
    void Start()
    {
        GameManager.instance.LoadScene("Splash");
    }
}