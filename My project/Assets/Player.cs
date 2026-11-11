using UnityEngine;

public class Player : MonoBehaviour
{


    public float health_player = 50.0f;



    void Die()
    {
        //EventManager.RunEnemyDieEvent();
        Destroy(this.gameObject);
    }

    private void TakeDamege(int value)
    {
        health_player -= value;
        if (health_player <= 0)
        {
            Die();
        }

        Debug.Log("Player Health: " + health_player);
    }




    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamege(20);
            Destroy(collision.gameObject);
        }

    }


    public float GetHealth()
    {
        return health_player;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
