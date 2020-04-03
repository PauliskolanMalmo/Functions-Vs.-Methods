using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{
    //public bool isDead;
    public int health = 100;

    public void Start()

    {

    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false /*&& isDead == false*/)
        {
            Damage(Random.Range(5, 20));
        }
    }
    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (IsDead() == true)
        {
            health = 0;
            print("The player hast died");
        }
        /*
        if (health < 1)
        {
            //isDead = true;
            health = 0;
            print("The player hast died");
        }
        */
    }

    public bool IsDead()
    {
        return health < 1;
    }
}

