using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MD_Plugin;
using MD_PluginEditor;
using DG.Tweening;

public class TakeOfWax : MonoBehaviour
{
    MDM_Bend mDM_Bend;

    private void Start()
    {
        mDM_Bend = GetComponent<MDM_Bend>();
        mDM_Bend.ppUpdateEveryFrame = true;
        DOTween.Init();

    }



    IEnumerator BlendEtc()
    {

        yield return new WaitForSeconds(1);
        if (mDM_Bend.ppValue < 0.14)
        {
            mDM_Bend.ppBendDirection = MDM_Bend.Direction_.Z;
            mDM_Bend.ppValue += 0.01f;
        }
        else
        {
            transform.DOMove(new Vector3(4, 4, 4), 12);
        }
    }

    private void Update()
    {
        StartCoroutine(BlendEtc());
    }
}
