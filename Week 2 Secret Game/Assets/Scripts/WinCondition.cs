using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform portal1;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        victory();
    }

    public void victory()
    {
        GameObject pad1GameObject = GameObject.Find("Pad1");
        GameObject pad2GameObject = GameObject.Find("Pad2");
        GameObject pad3GameObject = GameObject.Find("Pad3");
        GameObject pad4GameObject = GameObject.Find("Pad4");
        GameObject pad5GameObject = GameObject.Find("Pad5");
        GameObject pad6GameObject = GameObject.Find("Pad6");


        if (pad1GameObject.GetComponent<p1colorchange>().correctItem == true && pad2GameObject.GetComponent<p2colorchange>().correctItem == true && pad3GameObject.GetComponent<p3colorchange>().correctItem == true && pad4GameObject.GetComponent<p4colorchange>().correctItem == true && pad5GameObject.GetComponent<p5colorchange>().correctItem == true && pad6GameObject.GetComponent<p6colorchange>().correctItem == true)
        {
            player.transform.position = portal1.transform.position;
        }
    }
    
}
