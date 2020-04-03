using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{
    public bool isDead;
    public int health = 100;

    public void Start()

    {

    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDead == false)
        {
            Damage(Random.Range(5, 20));
        }
    }
    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 1)
        {
            isDead = true;
            print("The player hast died");
        }
    }
}

