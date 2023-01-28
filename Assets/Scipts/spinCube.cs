using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinCube : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.down * Time.deltaTime * 100);
        transform.Rotate(Vector3.forward * Time.deltaTime * 100);
    }
}
