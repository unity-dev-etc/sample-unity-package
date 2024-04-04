using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Devetc.Tools
{
    public class RotateObject : MonoBehaviour
    {
        public float rotationSpeed = 50f;

        void Update()
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }
    }
}

