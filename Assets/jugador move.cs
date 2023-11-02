using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            gameObject.transform.Translate(-15f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(15f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(0, 0, 15f * Time.deltaTime);
        }

        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(0, 0, -15f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f, 10 * Time.deltaTime, 0);
        }
    }
}
