using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastForObj : MonoBehaviour
{
    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            Debug.Log("ray");
            //Debug.DrawLine(ray.origin, hit.point);
    }
}
