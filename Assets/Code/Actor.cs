using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name = "NoNameFound";
    public int HitPoints = 1;
    public Dictionary<Item, int> Inventory = new Dictionary<Item, int>();
    public bool Invincible = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}