using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timer;
    public float bulletDuration = 2f;
    public float bulletSpeed = 5f;

    private void Start()
    {
        timer = bulletDuration;
    }
    private void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;

        timer -= Time.deltaTime;
        if (timer <= 0f)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
