using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3colorchange : MonoBehaviour
{
    public Color P3color;
    public Color p3wrongColor;
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
        if (collision.collider.tag == "cone")
        {

            myrender.material.color = P3color;
            correctItem = true;

        }

        if (collision.collider.tag != "cone")
        {
            myrender.material.color = p3wrongColor;
        }
    }
}
