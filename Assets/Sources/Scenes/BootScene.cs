using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootScene : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("BootScene Start");
    }
    private void OnDestroy()
    {
        Debug.Log("BootScene Destroy");
    }
}
