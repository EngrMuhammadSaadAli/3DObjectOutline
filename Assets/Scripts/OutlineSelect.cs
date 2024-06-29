using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineSelect : MonoBehaviour
{

    private Outline outlineCamp;

    private void Start()
    {
        outlineCamp = GetComponent<Outline>();
    }

    private void OnMouseEnter()
    {
        outlineCamp.enabled = true;
    }

    private void OnMouseExit()
    {
        outlineCamp.enabled = false;
    }







}
