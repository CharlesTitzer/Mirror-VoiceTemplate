using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;


namespace DapperDino.Mirror.Tutorials.Ownership
{
    public class PlayerDino : NetworkBehaviour
    {
        // Start is called before the first frame update

        [SerializeField] private Vector3 movement = new Vector3();

        // Update is called once per frame

        [Client]
        private void Update()
        {
            if (!isOwned) { return; }
            if (!Input.GetKeyDown(KeyCode.Space)) { return; }

            transform.Translate(movement);
        }
    }

}