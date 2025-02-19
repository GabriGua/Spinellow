using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    [SerializeField] SelectCharacter SelectCharacter;
    [SerializeField] MainCharactersSO[] mainCharactersSOs;
    [SerializeField] EnemyHealth EnemyHealth;
    public int damage = 200;
    


    private void Start()
    {
        damage += (int)(damage * ((mainCharactersSOs[SelectCharacter.OfficialCharacter].strenght * 28f) / 100f));
    }

    public void FirstAttack()
    {
        

        EnemyHealth.TakeDamage();
        Debug.Log(damage);
    }
}
