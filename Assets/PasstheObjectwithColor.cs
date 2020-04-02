using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasstheObjectwithColor : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.blue);
        }
    }

    private void ChangeColor(GameObject obj, Color colorToAssign)
    {
        obj.GetComponent<MeshRenderer>().material.color = colorToAssign;
    }
}
