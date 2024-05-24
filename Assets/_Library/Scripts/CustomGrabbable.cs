using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomGrabbable : XRGrabInteractable
{
    public Transform leftHandAttachPoint;
    public Transform rightHandAttachPoint;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        // Check which hand is grabbing the object

        bool isRightHand = args.interactableObject.transform.GetComponent<XRController>().inputDevice.characteristics == UnityEngine.XR.InputDeviceCharacteristics.Right;

        // Set the appropriate attach point based on the hand
        if (isRightHand)
        {
            attachTransform = rightHandAttachPoint;
        }
        else
        {
            attachTransform = leftHandAttachPoint;
        }
    }


}
