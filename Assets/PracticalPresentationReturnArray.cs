﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticalPresentationReturnArray : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] players;

    void Start()
    {
        players = GetAllPlayers();
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        foreach (var p in allPlayers)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        return allPlayers;

    }
}
