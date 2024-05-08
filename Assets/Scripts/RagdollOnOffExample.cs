using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollOnOffExample : MonoBehaviour
{
    public BoxCollider mainCollider;
    public GameObject ThisGuysRig;
    public Animator ThisGuysAnimator;
    // Start is called before the first frame update
    void Start()
    {
        GetRagdollBits();
        RagdollModeOff();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "MyNewCollisionTag")
        {
            RagdollModeOn();
        }
    }

    Collider[] ragDollColliders;
    Rigidbody[] limbsRigidBodies;
    void GetRagdollBits()
    {
        ragDollColliders = ThisGuysRig.GetComponentsInChildren<Collider>();
        limbsRigidBodies = ThisGuysRig.GetComponentsInChildren<Rigidbody>();
    }
    void RagdollModeOn()
    {
        ThisGuysAnimator.enabled = false;

        foreach (Collider col in ragDollColliders)
        {
            col.enabled = true;
        }

        foreach (Rigidbody rigid in limbsRigidBodies)
        {
            rigid.isKinematic = false;
        }

        mainCollider.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void RagdollModeOff()
    {

        ThisGuysAnimator.enabled = true;

        foreach (Collider col in ragDollColliders)
        {
            col.enabled = false;
        }

        foreach (Rigidbody rigid in limbsRigidBodies)
        {
            rigid.isKinematic = true;
        }

        mainCollider.enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }

}
