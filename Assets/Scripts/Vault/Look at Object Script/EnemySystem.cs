using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    bool lookAt = false;
    public GameObject player;
    void Update()
    {
        if (PlayerDetection.found)
        {
            //if player is detected, set look at to true
            lookAt = true;
        }

        if (lookAt)
        {
            transform.LookAt(player.transform);
        }
        
    }
}
