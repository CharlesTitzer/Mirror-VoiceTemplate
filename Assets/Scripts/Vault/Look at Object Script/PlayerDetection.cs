using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    static public bool found = false;
    [Header("Tag Name")]
    public string TagName;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == TagName)
        found = true;
    }

    void OnTriggerExit(Collider other)
    {
        found = false;

    }
}
