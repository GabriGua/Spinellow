using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    float health;
    float damage;

    [SerializeField] Image healthbar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 100;
        damage = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health -= damage;

            healthbar.fillAmount = health/100f;
            
        }
    }


}
