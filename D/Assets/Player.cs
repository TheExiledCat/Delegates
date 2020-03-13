using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Health))]
public class Player : MonoBehaviour
{
    Health h;
    
    void Start()
    {
        h = GetComponent<Health>();
       
    }
   
    void OnMouseDown()
    {
        h.LoseHealth(1);
        print("CLICK");
    }
}
