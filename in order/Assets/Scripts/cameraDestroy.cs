using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraDestroy : MonoBehaviour
{
    public GameObject cam;
    public GameObject canva;
    public GameObject as1;
    public GameObject as2;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeView", 25.0f);
        as2.SetActive(false);
    }

    void ChangeView()
    {
        Destroy(cam);
        Destroy(canva);
        Destroy(as1);
        as2.SetActive(true);
        as2.GetComponent<AudioSource>().Play();


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
