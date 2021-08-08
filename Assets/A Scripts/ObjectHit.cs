using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.red;

            gameObject.tag = "Hit";
        }
        
    }

    
}
