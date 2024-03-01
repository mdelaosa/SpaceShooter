using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float cooldownTimer = 0;
    public float fireDelay = 0.30f;

    public GameObject bullet;
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(bullet, transform.position + offset, transform.rotation);
        }
    }
}
