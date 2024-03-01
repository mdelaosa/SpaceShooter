using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGreenMovement : MonoBehaviour
{
    public float speed = 3f;
    float z;
    public float rotSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos = new Vector2(pos.x, pos.y-speed * Time.deltaTime);
        transform.position = pos;

        z += Time.deltaTime * rotSpeed;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ColliderLeft")
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y - 2);
            speed *= -1;
        }
        else if (collision.gameObject.name == "ColliderRight")
        {
            transform.position = new Vector2(transform.position.x - 1, transform.position.y + 2);
            speed *= -1;
        }

        if (collision.gameObject.name == "ColliderTop")
        {
            transform.position = new Vector2(transform.position.x + 2, transform.position.y - 1);
            speed *= -1;
        }
        else if (collision.gameObject.name == "ColliderBottom")
        {
            transform.position = new Vector2(transform.position.x - 2, transform.position.y + 1);
            speed *= -1;
        }
    }
}
