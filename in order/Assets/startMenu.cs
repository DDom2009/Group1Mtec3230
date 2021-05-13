using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startMenu : MonoBehaviour
{ 
 Rigidbody projectile;


    void Start()
    {
    Invoke("ChangeScene", 30.0f);
}

void ChangeScene()

{
        SceneManager.LoadScene(sceneName: "in_order");
}
}