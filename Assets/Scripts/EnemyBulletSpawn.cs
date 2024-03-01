using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    float cooldownTimer = 0;
    public float fireDelay = 2f;
    public GameObject enemyBullet;
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(enemyBullet, transform.position + offset, transform.rotation);
        }
    }

}
