using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p5colorchange : MonoBehaviour
{
    public Color P5color;
    public Color p5wrongColor;
    public bool correctItem;
    MeshRenderer myrender;
    void Start()
    {
        myrender = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "clock")
        {

            myrender.material.color = P5color;
            correctItem = true;

        }

        if (collision.collider.tag != "clock")
        {
            myrender.material.color = p5wrongColor;
        }
    }
}