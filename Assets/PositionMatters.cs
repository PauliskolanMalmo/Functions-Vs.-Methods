using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMatters : MonoBehaviour
{
    public Vector3[] positions;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        randomIndex = GetRandom();
        print("randomIndex" + randomIndex);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }

    Vector3 GetPosition()
    {
        return positions[randomIndex];
    }
}
