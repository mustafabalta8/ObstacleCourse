using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int fuel = 500;

    void Start()
    {
        StartCoroutine(CheckFuel());
    }

    private void Update()
    {
        fuel--;
    }

    IEnumerator CheckFuel()
    {
        yield return new WaitUntil(IsEmpty);
        //print("tank is empty");
    }

    bool IsEmpty()
    {
        if (fuel > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
