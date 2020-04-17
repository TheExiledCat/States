using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(TextMeshPro))]
public class NumberShower : MonoBehaviour
{
    
    public string word;
    TextMeshPro t;
     int number;
    Health p;
    bool alive = true;
    // Start is called before the first frame update
   void Start()
    {
        t = GetComponent<TextMeshPro>();
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        p.OnHealthChange += UpdateUI;
        p.OnDie += ShowDeath;
        UpdateUI();
    }

    // Update is called once per frame
    void ShowDeath()
    {
        alive = false;
        t.text = "YOU DIED";
    }
    void UpdateUI()
    {
        if (alive)
        {
 number = p.GetHealth();
        t.text = word + ": " + number.ToString("00");
        }
       
    }
}
