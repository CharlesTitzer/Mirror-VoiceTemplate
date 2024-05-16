using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceObject : MonoBehaviour
{
    void Update()
    {
        if (DetectObject.targetFound)
        {
            transform.LookAt(DetectObject.TaggedObject.transform);
            print(DetectObject.TaggedObject.transform);
            print(DetectObject.targetFound);
        }
        if (!DetectObject.targetFound)
        {
            return;
        }
    }
}
