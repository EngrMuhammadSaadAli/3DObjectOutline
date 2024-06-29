using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimmpleBTN : MonoBehaviour
{
    public GameObject targetObject; // Assign this in the inspector
    private Outline outlineBTN;
    public Button onBTN, OffBTN;

    void Start()
    {
        if (targetObject != null)
        {
            outlineBTN = targetObject.GetComponent<Outline>();
        }

        if (outlineBTN == null)
        {
            Debug.LogError("Outline component not found on target object");
            return;
        }

        onBTN.onClick.AddListener(OnOutlineOBJ);
        OffBTN.onClick.AddListener(OffOutlineExit);
    }

    private void OnOutlineOBJ()
    {
        if (outlineBTN != null)
        {
            outlineBTN.enabled = true;
        }
    }

    private void OffOutlineExit()
    {
        if (outlineBTN != null)
        {
            outlineBTN.enabled = false;
        }
    }
}
