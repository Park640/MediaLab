using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calibration : MonoBehaviour
{
    public Camera mainCam;
    public GameObject[] dots;
    float camWidth, camHeight; // 카메라의 너비, 높이
    
    int sWidth, sHeight;

    private void Awake()
    {
        camHeight = mainCam.orthographicSize;
        camWidth = mainCam.aspect * camHeight;
        sWidth = Screen.width;
        sHeight = Screen.height;
    }
    private void Start()
    {
        Dot();
    }

    public void Dot()
    {
        float dx = camWidth;
        float dy;
        int i = 0;
        while (i < 9)
        {
            dy = camHeight*2;
            for (int j = 0; j < 3; j++)
            {
                dots[i].transform.position = new Vector3(dx, dy, 0);
                dy -= camHeight;
                i++;
            }
            dx -= camWidth;
        }
    }
}
