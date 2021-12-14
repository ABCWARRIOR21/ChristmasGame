using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth;
    private Vector3 respawnPoint;

    private void Awake()
    {
        currentHealth = startingHealth;
        respawnPoint = transform.position;
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }



        if (currentHealth < 0.01)
        {
            transform.position = respawnPoint;
        }

    }
}