using HKY;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchList : MonoBehaviour
{
    public GameObject[] touchSpot;
    public URGSensorObjectDetector urg;
    public float dx, dy;
    Vector3 realpos;

    Vector3[] touchPos = new Vector3[10];

    int MAX = 10;

    private void Update()
    {
    }
   /* public void Touch()
    {
        urg.TouchList(touchPos);
        int i = 0;
        foreach(var touch in touchPos)
        {
            if (touch == null)
            {
                touchSpot[i].transform.position = Vector3.zero;
            }
            else
            {
                realpos.x= touch.x/dx;
                realpos.y= touch.y/dy;
                touchSpot[i].transform.position = realpos;
            }
            i++;
        }
    }*/
}
