using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beddingGrabber : OVRGrabbable
{
    [SerializeField] public GameObject bedlight;
    [SerializeField] public GameObject bedParticles;
   
    public GameObject bedParticles2;
    private bool isTriggered = false;
    private bool isGrab = true;
    private Transform target;
    public GameObject bed1;



    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        bedlight.GetComponent<Light>().intensity = 0;
        bedParticles.SetActive(false);
        Debug.Log("yay!");
    }



    // Update is called once per frame
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        bedlight.GetComponent<Light>().intensity = 100;
        bedlight.GetComponent<Light>().color = new Color(0.11F, 0.78F, 0.12F);
        bedParticles.SetActive(true);
        isGrab = true;
    


        Debug.Log("yay2!");
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        bedlight.GetComponent<Light>().intensity = 50;
        bedlight.GetComponent<Light>().color = new Color(0.61F, 0.18F, 0.12F);
        bedParticles.SetActive(false);
        isGrab = false;
        
    }

    void Update()
    {
      
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bed"))
        {
            bedParticles.SetActive(false);
            isTriggered = true;
        }
        if (isGrab == false && isTriggered == true)
        {
            Debug.Log("good job!");
            transform.position = new Vector3(0.0f, 0.7f, 0.9f);
            bed1.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
        Debug.Log("it worked!");
    }


}

  
