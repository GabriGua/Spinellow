using UnityEngine;

public class AttackSystem : MonoBehaviour
{
  
    [SerializeField] CharacterStats characterStats;
    [SerializeField] EnemyHealth EnemyHealth;
    public int damage = 200;
    


    private void Start()
    {
        damage += (int)(damage * ((characterStats.strenght * 28f) / 100f));
    }

    public void FirstAttack()
    {
        

        EnemyHealth.TakeDamage();
        Debug.Log(damage);
    }
}
