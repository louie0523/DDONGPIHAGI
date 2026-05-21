using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void Update()
    {
        if(transform.position.y < -7)
        {
            GameManager.instance.Score += 100;
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.GameOver();
        }
    }
}
