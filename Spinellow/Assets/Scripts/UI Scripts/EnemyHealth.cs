using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    [SerializeField] AttackSystem attackSystem;
    public float health;
    float damage;

    [SerializeField] Image healthbar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 3750;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health -= attackSystem.damage;

            healthbar.fillAmount = health/37/100f;
            
        }
    }


}
