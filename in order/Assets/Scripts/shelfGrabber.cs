using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelfGrabber : OVRGrabbable
{
    [SerializeField] public GameObject testlight;
    [SerializeField] public GameObject testparticles;
   
    public GameObject testparticles2;
    public bool isTriggered = false;
    public bool isGrab = true;
    private Transform target;
    public GameObject cube2;
    AudioSource source;
    public AudioClip grabSound;
    public AudioClip placeSound;
    public bool hasPlayed = false;



    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        testlight.GetComponent<Light>().intensity = 0;
        testparticles.SetActive(false);
        source = GetComponent<AudioSource>();
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
        source.PlayOneShot(grabSound, 0.7f);
    


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
        if (hasPlayed)
        {
            Destroy(GetComponent<AudioSource>(), 1.0f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bookshelf"))
        {
            testparticles.SetActive(false);
            isTriggered = true;
        }
        if (isGrab == false && isTriggered == true)
        {
            Debug.Log("good job!");
            transform.position = new Vector3(2.15f, 1.5f, 1.11f);
            cube2.transform.rotation = Quaternion.Euler(-90.0f, 0.0f, -269.0f);
            source.PlayOneShot(placeSound, 0.7f);
            hasPlayed = true;
        }
        Debug.Log("it worked!");
    }


}

  
