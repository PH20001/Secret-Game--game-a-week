using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4colorchange : MonoBehaviour
{
    public Color P4color;
    public Color p4wrongColor;
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
        if (collision.collider.tag == "apple")
        {

            myrender.material.color = P4color;
            correctItem = true;

        }

        if (collision.collider.tag != "apple")
        {
            myrender.material.color = p4wrongColor;
        }
    }
}