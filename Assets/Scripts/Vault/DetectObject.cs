using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    [Header("TargetTag")]
    public string targetTag;
    static public bool targetFound = false;
    static public GameObject TaggedObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == targetTag)
        {
            targetFound = true;
            TaggedObject = GameObject.FindWithTag(targetTag);
            print(TaggedObject);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == targetTag)
        {
            targetFound = false;
        }
    }
}
