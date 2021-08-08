using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float  MovementSpeed;
     float DeltaTime;

    WaitForSeconds delay = new WaitForSeconds(3);
    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
    }
    void MovePlayer()
    {
        DeltaTime = Time.deltaTime;
        float xValue = Input.GetAxis("Horizontal") * MovementSpeed * DeltaTime;
        float zValue = Input.GetAxis("Vertical") * MovementSpeed * DeltaTime;
        transform.Translate(xValue, 0, zValue);
    }

    IEnumerator MyCoroutine()
    {
        print("Start waiting");

        yield return delay;

        print("3 seconds has passed");

        yield return delay;

        print("3 more seconds has passed");

        // All done!
    }
}
