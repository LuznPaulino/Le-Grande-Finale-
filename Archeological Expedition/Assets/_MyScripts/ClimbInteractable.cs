using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ClimbInteractable : XRBaseInteractable
{
    // Start is called before the first frame update
    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);
        if (interactor is XRDirectInteractor)
        {
            RigMotion.activeHand = interactor.GetComponent<XRController>();
        }
    }



    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);
        if (interactor is XRDirectInteractor && RigMotion.activeHand && RigMotion.activeHand.name == interactor.name)
        {
            RigMotion.activeHand = null;
        }
    }
}
