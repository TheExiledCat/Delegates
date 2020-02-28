using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    int health, maxHealth;
    NumberShower n;
    public GameObject g;
    public int GetHealth()
    {
        return health;
    }
    
    public void LoseHealth(int amount)
    {

        health -= amount;
        if (health == 0)
        {
            Die();
        }
       
            UpdateUI(health);
        
       
    }
    public void Heal(int amount)
    {
        UpdateUI(health);
    }
    public void SetHealth(int amount)
    {
        maxHealth = amount;
        health = maxHealth;
        UpdateUI(health);
    }
    void Start()
    {
        n = GameObject.FindGameObjectWithTag("UI").GetComponent<NumberShower>();
        n.word = "HP";
        health = maxHealth;
        UpdateUI(health);
    }
    void UpdateUI(int numb)
    {
        n.number = numb;
    }
    void Die()
    {
        Destroy(g);
        
    }
}
