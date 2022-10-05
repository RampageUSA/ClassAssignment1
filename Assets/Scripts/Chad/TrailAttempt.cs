using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailAttempt : MonoBehaviour
{
    public GameObject sphere;
    public LineRenderer lTrail;
    public int length = 3;

    void Update()
    {
        lTrail = GetComponent<LineRenderer>();
        lTrail.SetPosition(0, transform.position);

        for(int i = 0; i < length - 1; i++)
        {
            if (Vector3.Distance(lTrail.GetPosition(i), lTrail.GetPosition(i + 1)) > 1)
            {

            }
        }
    }
}
