//Created By: Andrew S
//Date Created: 3/10/22
//Use: Makes a target gameobject orbit around another
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public GameObject target;
    public float theta, radius, speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theta += Time.deltaTime * speed;
        Vector3 position = new Vector3(target.transform.position.x + Mathf.Cos(theta) * radius, target.transform.position.y + Mathf.Cos(theta) * radius);
    }
}
