using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    [SerializeField] CharacterStats characterStats;
    [SerializeField] TextMeshProUGUI turnWho;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI actionsText;
    [SerializeField] EnemyHealth enemyHealth;
    

    public int actions = 0;

    bool playerTurnActive = true;  // Variabile booleana che controlla il turno del giocatore
    float turnTimeLimit = 20f;     // Tempo massimo per il turno del giocatore
    int timer;



    void Start()
    {
        actionsText.text = "Actions: " + actions.ToString();

    }
    private void Update()
    {
        timerText.text = timer.ToString();
     
    }


    IEnumerator GameTurn()
    {
        
        
        if (characterStats.luck + characterStats.speed> 5)
        {

            
            
            yield return StartCoroutine(PlayerTurn());
            yield return new WaitForSeconds(5);

        }
        while (enemyHealth.health > 0)
        {
           
            
            
            BossTurn();

           
            yield return new WaitForSeconds(5);

            
            
            
            yield return StartCoroutine(PlayerTurn());

            
            yield return new WaitForSeconds(5);
        }
    }

    IEnumerator PlayerTurn()
    {
        turnWho.text = "Player Turn";
        playerTurnActive = true; 

        actions = 1;
        actionsText.text = "Actions: " + actions.ToString();
        timer = 20;
        StartCoroutine(StartPlayerTimer());

        float elapsedTime = 0f; 

        // Controlla se la variabile booleana diventa falsa o se il tempo massimo è scaduto
        while (playerTurnActive && elapsedTime < turnTimeLimit)
        {
          
            elapsedTime += Time.deltaTime;
            
            
            

            
            if (actions <= 0)
            {
                playerTurnActive = false;
                StopCoroutine(StartPlayerTimer());
            }

            
            yield return null;
        }

        StopCoroutine(StartPlayerTimer());
        Debug.Log("Player Turn Ended");
    }


    IEnumerator StartPlayerTimer()
    {
        
            while (timer > 0 && playerTurnActive)
            {
                timerText.text = timer.ToString();
                yield return new WaitForSeconds(1);
                timer--;
            }
            yield break;
        
    }

    IEnumerator StartBossTimer()
    {

        while (timer > 0 && !playerTurnActive)
        {
            timerText.text = timer.ToString();
            yield return new WaitForSeconds(1);
            timer--;
        }
        yield break;

    }

    void BossTurn()
    {
        playerTurnActive = false;
        timer = 5;
        StartCoroutine(StartBossTimer()); 
        turnWho.text = "Boss Turn";
        Debug.Log("Boss Turn Started");
    }

    public void StartThatCoroutine()
    {
        StartCoroutine(GameTurn());
    }

    public void DecreaseActions()
    {
        if (actions > 0)
        {
            actions--;
        actionsText.text = "Actions: "+actions.ToString();
        }
        
    }
}
