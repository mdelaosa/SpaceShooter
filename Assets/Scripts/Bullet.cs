using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float maxSpeed = 6f; // Default 6f

    // Update is called once per frame
    void Update()
    {
        // Movimiento eje vertical
        Vector3 pos = transform.position;
        Vector3 vel = new Vector3(0, maxSpeed * Time.deltaTime, 0);

        pos += transform.rotation * vel;
        transform.position = pos;

    }
}
