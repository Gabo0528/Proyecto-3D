using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

           void Update()
        {
            transform.Rotate(new Vector3(0f, 0f, 90f) * Time.deltaTime);
        }
    
}