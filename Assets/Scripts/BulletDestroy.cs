using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hasar verdin");
            Destroy(gameObject);


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Temas");
        Destroy(gameObject, 0.2f);
    }

}