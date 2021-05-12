using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deskGrabber : OVRGrabbable
{
    [SerializeField] public GameObject testlight;
    [SerializeField] public GameObject testparticles;
   
    public GameObject testparticles2;
    public bool isTriggered = false;
    public GameObject destroycube;
    public bool isGrab = true;
    private Transform target;
    public GameObject cube2;



    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        testlight.GetComponent<Light>().intensity = 0;
        testparticles.SetActive(false);
        Debug.Log("yay!");
    }



    // Update is called once per frame
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        testlight.GetComponent<Light>().intensity = 100;
        testlight.GetComponent<Light>().color = new Color(0.11F, 0.78F, 0.12F);
        testparticles.SetActive(true);
        isGrab = true;
    


        Debug.Log("yay2!");
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        testlight.GetComponent<Light>().intensity = 0;
        testlight.GetComponent<Light>().color = new Color(0.61F, 0.18F, 0.12F);
        testparticles.SetActive(false);
        isGrab = false;
        
    }

    void Update()
    {
      
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("desk"))
        {
            testparticles.SetActive(false);
            isTriggered = true;
        }
        if (isGrab == false && isTriggered == true)
        {
            Debug.Log("good job!");
            transform.position = new Vector3(1.06f, 1.21f, -0.84f);
            cube2.transform.rotation = Quaternion.Euler(-90.0f, 99.5f, -9.0f);
        }
        Debug.Log("it worked!");
    }


}

  