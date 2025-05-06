using System;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public string buttonID;

    private void OnTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Botão pressionado: {buttonID}");
            ButtonEventChannel.RaiseButtonPressed(buttonID);
        }
    }
}
