using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public bool triggerObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Brush") && !triggerObj)
        {
            Debug.Log("Brush");
            GameManager.instance.triggerCount++;
            triggerObj = true;
        }
    }
}
