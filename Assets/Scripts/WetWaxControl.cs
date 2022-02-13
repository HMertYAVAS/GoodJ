using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetWaxControl : MonoBehaviour
{
    private void Update()
    {
        FinishWaxing();
    }

    void FinishWaxing()
    {
        if (GameManager.instance.triggerCount == 6)
        {
            StartCoroutine(DryingWax());
        }
    }

    IEnumerator DryingWax()
    {
        yield return new WaitForSeconds(3);
        transform.parent.GetChild(3).gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
