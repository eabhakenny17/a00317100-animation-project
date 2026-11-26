using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class RagdollToggle : MonoBehaviour
{
    public CharacterController characterController;
    //array for the rigidbodies on the child bones
    private Rigidbody[] boneRigidbodies;
    private Animator animator;
    private ThirdPersonController thirdPersonController;

    private bool ragDolled;

    private void Awake()
    {
        if (characterController == null)
            characterController = GetComponent<CharacterController>();

        //find all rigidbodies on the character and children (bones with rigidbodies)
        boneRigidbodies = GetComponentsInChildren<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        //built in script
        thirdPersonController = GetComponent<ThirdPersonController>(); 

        //start with ragdoll off
        SetRagdollActive(false);
    }

    private void Update()
    {
        //ragdoll is r is pressed
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            Activate();
        }
    }

    public void Activate()
    {
        SetRagdollActive(!ragDolled);
    }

    private void SetRagdollActive(bool isActive)
    {
        ragDolled = isActive;
        
        //turn of animator when ragdolling
        if (animator != null) animator.enabled = !isActive;

        //turn of the thirdpersoncontroller when ragdolling
        if (thirdPersonController != null) thirdPersonController.enabled = !isActive;
        if (characterController != null) characterController.enabled = !isActive;

        //flip every bone's kinematic state
        foreach (Rigidbody rb in boneRigidbodies)
        {
            rb.isKinematic = !isActive;
        }
    }
}