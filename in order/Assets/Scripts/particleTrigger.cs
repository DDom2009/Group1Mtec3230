using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleTrigger : OVRGrabbable
{
    public GameObject testparticles;
    public bool isTriggered = false;
    public GameObject destroycube;
    public GameObject tester;
    public GameObject script1;

    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        if (isTriggered == true )
        {
            Debug.Log("good job!");
            Destroy(destroycube);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            testparticles.SetActive(false);
        isTriggered = true;
        Debug.Log("it worked!");
    }

    
}


