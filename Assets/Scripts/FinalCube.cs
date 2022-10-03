using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FinalCube : MonoBehaviour
{
    [SerializeField]
    private AnimationCurve height;
    private Vector3 scaleTransform;
    private float rate;
    private bool inOut;

    //BOX.JIGGLE
    private void Start()
    {
        inOut = false;
    }
    private void Update()
    {
        if (inOut)
        {
            rate += Time.deltaTime;

            scaleTransform = new Vector3(1, height.Evaluate(rate), 1);
            transform.parent.localScale = scaleTransform;

            if (rate >= 1)
                rate = 0;
        }
        else
        {
            transform.parent.localScale = new Vector3(1, 1, 1);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        inOut = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inOut = false;
    }
}
