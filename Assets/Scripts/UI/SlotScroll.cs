using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScroll : MonoBehaviour
{
    public GameObject slot;
    public float maxScroll;
    private void Awake()
    {
        for (int i = 0; i < maxScroll; i++)
        {
            GameObject newButton = Instantiate(slot, transform, true) as GameObject;
        }
    }
}
