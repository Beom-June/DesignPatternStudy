using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine2 : MonoBehaviour
{
    void Start()
    {
        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);

        Renderer rend = GetComponent<Renderer>();
        rend.material.color = new Color(r, g, b, 0f);   
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
        Destroy(this.gameObject);
    }
}
