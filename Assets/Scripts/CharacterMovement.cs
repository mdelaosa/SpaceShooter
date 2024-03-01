using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float maxSpeed = 4.5f; // Default 4.5f
    float z; // Usado en la rotacion
    public float rotSpeed = 180f; // Default 180f
    float shipRadius = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento eje vertical
        Vector3 pos = transform.position;
        Vector3 vel = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        // Rotacion nave 
        Quaternion rot = transform.rotation;
        z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        // Limites superior e inferior
        if(pos.y+shipRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipRadius;
        }
        if (pos.y-(1f+shipRadius) < -Camera.main.orthographicSize)
        {
            pos.y = 1.75f + shipRadius -Camera.main.orthographicSize;
        }

        pos += rot * vel;
        transform.position = pos;    

    }
}
