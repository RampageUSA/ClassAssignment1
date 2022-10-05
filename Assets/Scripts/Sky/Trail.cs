using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(LineRenderer))]

public class Trail : MonoBehaviour
{
    [SerializeField]
    private Vector3 position, position2;
    [SerializeField]
    private int length;
    private LineRenderer trail;
    
    void Start()
    {
        trail = GetComponent<LineRenderer>();
    } 
   
    void Update()
    {
        trail.positionCount = length;
        position = transform.position;

        for(int i = 0; i < length; i++)
        {
            position2 = trail.GetPosition(i);
            trail.SetPosition(i, position);
            position = position2;
        }



    }
}
