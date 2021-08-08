using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //caching references
    MeshRenderer meshRenderer;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer= GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(CountTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CountTime()
    {
        while (true)
        {
            Debug.Log("Time.time: " + (int)Time.time);
            yield return new WaitForSeconds(3);
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
        
    }
}
