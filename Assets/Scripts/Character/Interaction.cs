using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject curInteractGameObject;
    private IInteractable curInteractable;

    public void OnInteractInput()
    {
        curInteractable.OnInteract();
        curInteractGameObject = null;
        curInteractable = null;

    }

}
