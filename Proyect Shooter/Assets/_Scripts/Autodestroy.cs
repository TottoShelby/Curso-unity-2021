using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour
{
    [Tooltip("tiempo despues del cual se destruye el objeto")]
    public float destructionDelay;
    private void OnEnable()
    {
        //Destroy(gameObject, destructionDelay);
        Invoke("HideObject",destructionDelay);
    }


    private void HideObject()
    {
        gameObject.SetActive(false);
    }
}

