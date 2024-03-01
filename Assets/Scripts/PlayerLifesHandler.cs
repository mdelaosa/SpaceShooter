using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLifeHandler : MonoBehaviour
{
    // Vidas
    int health = 3;
    float invulnerable = 0;
    public bool isInvulnerable;
    public Image[] HealthUI;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Border")
        {
            Debug.Log("hit!");
            if (invulnerable <= 0)
            {
                health--;
                if (isInvulnerable)
                {
                    invulnerable = 2f;
                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        invulnerable -= Time.deltaTime;
        if (health <= 0)
        {
            Die();
            SceneManager.LoadScene("Menu");
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
            for (int i = 0; i < HealthUI.Length; i++)
            {
                if (i < health)
                {
                    HealthUI[i].enabled = true;
                }
                else
                {
                    HealthUI[i].enabled = false;
                }
            }
            if (health <= 0)
            {

                Destroy(gameObject);
                SceneManager.LoadScene("Menu");

            }
        }
    }
}

