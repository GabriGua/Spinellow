using System.Collections;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
  
    [SerializeField] CharacterStats characterStats;
    [SerializeField] TurnSystem turnSystem;
    [SerializeField] EnemyHealth EnemyHealth;
    [SerializeField] GameObject buttonToClick;
    [SerializeField] GameObject[] randomButtons;
    int force = 200, magic = 200, fast = 200, smart = 200;
    int click = 0;
    int timer;

    
    public int damage = 200;
    


    private void Start()
    {
        force += (int)(force * ((characterStats.strenght * 28f) / 100f));
        magic += (int)(magic * ((characterStats.manaPoints * 28f) / 100f));
        fast += (int)(fast * ((characterStats.speed * 28f) / 100f));
        smart += (int)(smart * ((characterStats.inteligence * 28f) / 100f));
    }

    public void FirstAttack()
    {

        buttonToClick.SetActive(true);
        click = 0;
        StartCoroutine(TimeToForce());
        
    }

    public void SecondAttack()
    {
        damage = magic;
        EnemyHealth.TakeDamage();
        Debug.Log(damage);
    }
    public void ThirdAttack()
    {
        for (int i = 0; i < randomButtons.Length; i++)
        {
            randomButtons[i].transform.position = new Vector3(Random.Range(-8f, 8), Random.Range(-4f, 4) , 0);
            randomButtons[i].SetActive(true);
        }
        click = 0;
        StartCoroutine(TimeToFast());
        
    }

    public void FourthAttack()
    {
        damage = smart;
        EnemyHealth.TakeDamage();
        Debug.Log(damage);
    }




    //First attack
    public void JustSpam()
    {
        click++;
        Debug.Log("Click: "+click);
    }

    IEnumerator TimeToForce()
    {
        timer = 5;
        while (timer > 0)
        {
            yield return new WaitForSeconds(1);
            timer--;
            Debug.Log("timer: "+timer);
        }
        buttonToClick.SetActive(false);
        damage = force + (click * 10);
        Debug.Log("Damage: "+damage);
        EnemyHealth.TakeDamage();
        turnSystem.DecreaseActions();
    }

    //third attack

    IEnumerator TimeToFast()
    {
        timer = 3;
        while (timer > 0)
        {
            yield return new WaitForSeconds(1);
            timer--;
            Debug.Log("timer: " + timer);
        }
        buttonToClick.SetActive(false);
        damage = fast + (click * 25);
        Debug.Log("Damage: " + damage);
        EnemyHealth.TakeDamage();
        turnSystem.DecreaseActions();
        for (int i = 0; i < randomButtons.Length; i++)
        {
           
            randomButtons[i].SetActive(false);
        }
    }
}
