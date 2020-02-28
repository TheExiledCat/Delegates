using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(TextMeshProUGUI))]
public class NumberShower : MonoBehaviour
{
    [SerializeField]
    public string word;
    TextMeshProUGUI t;
    public int number;
   
    
    // Start is called before the first frame update
   void Start()
    {
        t = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        t.text = word + ": " + number.ToString("00");
    }
}
