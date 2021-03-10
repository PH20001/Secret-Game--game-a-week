using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p6colorchange : MonoBehaviour
{
    public Color P6color;
    public Color p6wrongColor;
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
        if (collision.collider.tag == "laptop")
        {

            myrender.material.color = P6color;
            correctItem = true;

        }

        if (collision.collider.tag != "laptop")
        {
            myrender.material.color = p6wrongColor;
        }
    }
}
