using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantScript : MonoBehaviour
{
    public static GameObject instance = null; // Экземпляр объекта

    // Метод, выполняемый при старте игры
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
