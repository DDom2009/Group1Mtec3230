using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabbedItems : OVRGrabbable
{
    [SerializeField] public GameObject testlight;
    

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        testlight.GetComponent<Light>().intensity = 0;
        Debug.Log("yay!");
    }
   
  

    // Update is called once per frame
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        testlight.GetComponent<Light>().intensity = 100;
        testlight.GetComponent<Light>().color = new Color (0.11F, 0.78F, 0.12F);
        Debug.Log("yay2!");
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        testlight.GetComponent<Light>().intensity = 50;
        testlight.GetComponent<Light>().color = new Color(0.61F, 0.18F, 0.12F);
    }
}
