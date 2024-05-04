using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideLockedCursor : MonoBehaviour
{
    // Start is called before the first frame update
    public bool lockCursor = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lockCursor = !lockCursor;
        }

        Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !lockCursor;
    }
}
