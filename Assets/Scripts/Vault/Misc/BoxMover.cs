using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    public float speed = 10;
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
