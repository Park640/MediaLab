using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using static UnityEngine.GraphicsBuffer;

public class beePath : MonoBehaviour
{
    /*public PathCreator pathCreator;
    public float speed = 1f;
    float distanceTravel;

    void Update()
    {
        distanceTravel += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravel);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravel);
    }
    */

    public Transform Target;
    public bool isbee;

    public float rotateSpeed = 50f;
    public Vector3 axis = new Vector3(0f, 0f, 0f);
    public Vector3 diff = new Vector3(0f, 0f, 0f);
    private float t = 0;

    private void Start()
    {
        axis= gameObject.transform.position;
    }
    void Update()
    {
        if (isbee)
        {
            transform.RotateAround(Target.position, Vector3.back, 80 * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(Target.position, Vector3.back, 80 * Time.deltaTime);
        }
    }
    private void RotateAround2(in Vector3 axis, in Vector3 diff, float speed, ref float t)
    {
        t += speed * Time.unscaledDeltaTime;

        Vector3 offset = Quaternion.AngleAxis(t, Vector3.up) * diff;
        transform.position = Target.position + offset;

        Quaternion rot = Quaternion.LookRotation(-offset, axis);
        transform.rotation = rot;
    }
}
