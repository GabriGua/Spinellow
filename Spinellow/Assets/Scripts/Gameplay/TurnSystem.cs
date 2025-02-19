using System.Collections;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    [SerializeField]CharacterStats characterStats;
    int actions = 1;
    
    [SerializeField] EnemyHealth enemyHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GameTurn()
    {
        if(characterStats.luck + characterStats.speed > 5)
        {
            PlayerTurn();
            yield return new WaitForSeconds(20);
            yield break;
        }
        while (enemyHealth.health > 0)
        {

            BossTurn();

            yield return new WaitForSeconds(5);
            

            PlayerTurn();

            yield return new WaitForSeconds(20);
            yield break;



        }


        yield return null;
    }


    void PlayerTurn()
    {
        actions = 1;
        if(actions > 0)
        {

        }
    }
    void BossTurn()
    {

    }
}
