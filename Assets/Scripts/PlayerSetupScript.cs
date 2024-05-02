using UnityEngine;
using Mirror;
using UnityEngine.InputSystem;
using StarterAssets;
using Cinemachine;

public class PlayerSetupScript : NetworkBehaviour
{
    // remember to set these on player prefab
    public PlayerInput playerInput;
    public FirstPersonController firstPersonController;
    public Transform playerCameraRoot;
    private CinemachineVirtualCamera cinemachineVirtualCamera;

    public override void OnStartLocalPlayer()
    {
        //disable by default on player prefab
        playerInput.enabled = true;
        firstPersonController.enabled = true;

        // here we grab camera script, and set its target
        cinemachineVirtualCamera = GameObject.Find("PlayerFollowCamera").GetComponent<CinemachineVirtualCamera>();
        cinemachineVirtualCamera.Follow = playerCameraRoot;
    }
}