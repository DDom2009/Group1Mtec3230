using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabbedItems2 : MonoBehaviour
{
    public GameObject testparticles;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            testparticles.SetActive(false);
        Debug.Log("yay3!");
    }
}
