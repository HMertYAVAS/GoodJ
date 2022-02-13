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

    private void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
            StartCoroutine(BlendEtc());
    }


    IEnumerator BlendEtc()
    {

        yield return new WaitForSeconds(2);
        if (mDM_Bend.ppValue < 0.14)
        {
            mDM_Bend.ppBendDirection = MDM_Bend.Direction_.Z;
            mDM_Bend.ppValue += 0.01f;
        }
        else
        {
                transform.parent.transform.DOMove(new Vector3(4, 4, 4), 12);
        }
    }

}
