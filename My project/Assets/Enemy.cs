using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 50.0f;

    private void TakeDamege(int value)
    {
        health -= value;
    }

    public float GetHealth()
    {
        return health;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamege(10);
        Debug.Log("Health : " + health);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
