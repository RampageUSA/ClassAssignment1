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
    [SerializeField]
    [Range(1, 10)]
    private float speed;
    //BOX.JIGGLE
    private void Start()
    {
        inOut = false;
    }
    private void Update()
    {
        if (inOut)
        {
            rate += Time.deltaTime * speed;

            scaleTransform = new Vector3(1, height.Evaluate(rate), 1);
            transform.parent.localScale = scaleTransform;

            if (rate >= 1)
            {
                inOut = false;
                rate = 0;
            }
               
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        inOut = true;
    }
}
