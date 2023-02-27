using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nonsan : MonoBehaviour
{
    public GameObject[] destroy;
    public GameObject[] myObj;
    private void OnMouseDown()
    {
        for (int i = 0; i < myObj.Length; i++)
        {
            myObj[i].SetActive(true);
            myObj[i].GetComponent<Animator>().enabled = true;
        }
        //gameObject.GetComponent<Animator>().enabled = true;
        for(int i = 0; i < destroy.Length; i++)
        {
            destroy[i].SetActive(false);
        }
    }
}
