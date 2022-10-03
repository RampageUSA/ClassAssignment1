using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceUpdated : MonoBehaviour
{
    private bool bFlipDirection;
    public float offset, speed;
    public AnimationCurve height, movement;
    public Transform targetA, targetB;
    private float rate;
    private Vector3 desiredPosition;
    // Update is called once per frame


    void Update()
    {
        rate += Time.deltaTime * speed;

        desiredPosition = Vector3.Lerp(targetA.position, targetB.position, movement.Evaluate(rate));
        desiredPosition.y += height.Evaluate(rate) + offset;
        transform.position = desiredPosition;

        if (rate >= 1)
            rate = 0;
    }

}
