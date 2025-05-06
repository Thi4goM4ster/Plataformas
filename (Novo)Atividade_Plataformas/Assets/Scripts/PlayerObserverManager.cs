using System;
using UnityEngine;

public static class PlayerObserverManager
{
    public static event Action<int> OnMoedasChanged;

    public static void ChangedMoedas(int valor)
    {
        OnMoedasChanged?.Invoke(valor);
    }
}