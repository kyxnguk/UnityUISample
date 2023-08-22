using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{
    float speed = 100.0f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * Time.deltaTime * speed;
        v = v * Time.deltaTime * speed;

        transform.Translate(h, v, 0);

        if (Input.GetKey(KeyCode.Z))
       {
            transform.Rotate(1, 0, 0);
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.C))
        {
            Vector3 scale = new Vector3();
            scale = new Vector3(0.01f, 0.01f, 0.01f);
            transform.localScale += scale;
        }

        if (Input.GetKey(KeyCode.V))
        {
            Vector3 scale = new Vector3();
            scale = new Vector3(0.01f, 0.01f, 0.01f);
            transform.localScale -= scale;
        }
    }

}
