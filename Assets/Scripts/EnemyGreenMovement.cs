using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGreenMovement : MonoBehaviour
{
    public float speed = 2f;
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
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ColliderBottom")
        {
            Destroy(gameObject);
        }
    }
}
