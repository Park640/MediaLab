using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTT : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        Debug.Log("asdf");
    }
    public void Test()
    {

    }
}
