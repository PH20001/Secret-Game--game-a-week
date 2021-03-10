using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1colorchange : MonoBehaviour
{
    public Color P1color;
    public Color p1wrongColor;
    public Color p1defaultColor;
    public bool correctItem;
    MeshRenderer myrender;
    
    void Start()
    {
        myrender = GetComponent<MeshRenderer>();

    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Rock")
        {

            myrender.material.color = P1color;
            correctItem = true;
           
        }

        if (collision.collider.tag != "Rock")
        {
            myrender.material.color = p1wrongColor;
        }

        if (collision.collider.tag == "")
        {
            myrender.material.color = p1defaultColor;
            correctItem = false;
        }

        
    }
}
