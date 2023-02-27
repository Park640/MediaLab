using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoryOnLoad : MonoBehaviour
{
    private void Awake()
    {
        var obj = FindObjectsOfType<DontDestoryOnLoad>();
        if(obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    
}
