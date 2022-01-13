using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player_Base;

    public float interpSpeed;

    private Vector3 targetPos;

    void Update()
    {
        targetPos = new Vector3(Player_Base.transform.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPos, interpSpeed);
    }
}