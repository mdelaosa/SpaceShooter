using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float maxSpeed = 4f; // Default 4f

    // Update is called once per frame
    void Update()
    {
        // Movimiento eje vertical
        Vector3 pos = transform.position;
        Vector3 vel = new Vector3(0, maxSpeed * Time.deltaTime, 0);

        pos += transform.rotation * vel;
        transform.position = pos;

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}