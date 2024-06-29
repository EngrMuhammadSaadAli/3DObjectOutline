using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics : MonoBehaviour
{
    
    private void Start()
    {
        GameObject[] chairs = GameObject.FindGameObjectsWithTag("chair");

        foreach(GameObject chair in chairs)
        {
            if(chair.GetComponent<Outline>() == null)
            {
                chair.AddComponent<Outline>();
                chair.GetComponent<Outline>().enabled = false;
                chair.GetComponent<Outline>().OutlineColor = new Color(0f, 128f, 0f);
                chair.GetComponent<Outline>().OutlineWidth = 20f;
            }


            if(chair.GetComponent<OutlineSelect>() == null)
            {
                chair.AddComponent<OutlineSelect>();
            }


            if(chair.GetComponent<BoxCollider>() == null)
            {
                chair.AddComponent<BoxCollider>();
            }

        }
 

    }

   
}
