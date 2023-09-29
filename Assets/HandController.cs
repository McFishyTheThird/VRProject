using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
public class HandController : MonoBehaviour
{
    ActionBasedController controller;
 
    // Start is called before the first frame update
    private void Awake() {
        controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += onTriggerPress;
    }

    void onTriggerPress(InputAction.CallbackContext context)
    {
        XRRayInteractor interactor = GetComponentInChildren<XRRayInteractor>();

        foreach (IXRSelectInteractable interactable in interactor.interactablesSelected)
        {
            GameObject probablyGun = interactable.transform.gameObject;

            if (probablyGun.TryGetComponent<GunController>(out GunController c))
            {
                c.PullTrigger();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
