using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceFlip : MonoBehaviour
{
        private bool bFlipDirection;
        // Update is called once per frame

        void Update()

        {
            if (bFlipDirection)
                transform.position += Vector3.forward * Time.deltaTime * 5;
            else
                transform.position += Vector3.back * Time.deltaTime * 5;

        }

        private void OnTriggerEnter(Collider other)
        {
            if (bFlipDirection) bFlipDirection = false;
            else bFlipDirection = true;

        }

   }
