using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    int isRunningHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {

        bool isRunning = animator.GetBool(isRunningHash);
        bool forwardPressed = Input.GetKey(KeyCode.W);
        //if player presses w key
        if (!isRunning && forwardPressed)
        {
            //then set is walking to true
            animator.SetBool(isRunningHash, true);
        }
        //if player is not pressing the w key
        if (isRunning && !forwardPressed)
        {
            //then set is walking to false
            animator.SetBool(isRunningHash, false);
        }
    }
}
