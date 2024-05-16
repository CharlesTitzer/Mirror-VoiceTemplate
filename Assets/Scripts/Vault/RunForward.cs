using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunForward : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        if (DetectObject.targetFound == true)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }
}
