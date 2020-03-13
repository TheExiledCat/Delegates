using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Awake()
    {
       GetComponent<Health>().OnHealthChange+=CallShake;
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void CallShake()
    {
        Camera.main.GetComponent<ScreenShake>().Shake();
    }
}
