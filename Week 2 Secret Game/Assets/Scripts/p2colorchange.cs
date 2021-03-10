using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2colorchange : MonoBehaviour
{
    public Color P1color;
    public Color p1wrongColor;
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
        if (collision.collider.tag == "banana")
        {

            myrender.material.color = P1color;
            correctItem = true;

        }

        if (collision.collider.tag != "banana")
        {
            myrender.material.color = p1wrongColor;
        }
    }
}
