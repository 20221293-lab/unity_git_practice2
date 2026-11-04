using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 50.0f;


    private void TakeDamege(int value)
    {
        health -= value;
        if(health <= 0)
        {
            Die();
        }
    }

    //public void TakeDamage(float ratio)
    //{
    //    health -= (int)(health * ratio);
    //}


    void Die()
    {
        //EventManager.RunEnemyDieEvent();
        Destroy(this.gameObject);

    }

    public float GetHealth()
    {
        return health;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamege(10);
            collision.gameObject.SetActive(false);
            //Debug.Log("Health : " + health);
        }
    }

    public virtual void Move() { }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
