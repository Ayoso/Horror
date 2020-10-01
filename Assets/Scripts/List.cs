using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class List : MonoBehaviour
{

    public LayerMask InteractLayer;
    public float interactDistance;
    public Image InteractIcon;
    void Start()
    {
        if (InteractIcon != null)
            InteractIcon.enabled = false;
    }


    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, interactDistance, InteractLayer))
        {
            if (InteractIcon != null)
                InteractIcon.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hit.collider.tag == "List")
                {
                    hit.collider.GetComponent<Battery>().UseBattery();
                }



            }

        }
        else
        {
            if (InteractIcon != null)
                InteractIcon.enabled = false;
        }


    }
}