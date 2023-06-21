using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Transactions;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class PlayerCharacter : MonoBehaviour
{
    // Variables will go first
  public TMP_Text combatLog;
    public TMP_Text statsText;
   
   
    [SerializeField] private double attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;
    [SerializeField] private int experience = 0;
    private double exptolevelup = 10;
    private int enemyHealth;

    private bool isGameOver = false;

    // Start is called before the first frame update
    private void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
        experience = 0;
        // starting game
        Debug.Log("face my minions fool");
        combatLog.text = "Yo wassup";

        enemyHealth = Random.Range(10, 15);

    }

    private void Update()
    {// attacking
      
        
       if (Input.GetKeyDown(KeyCode.Space))
        {
           
            if isPlayerCharacterTurn
                (PlayerCharacter Attack)

            
            Debug.Log("you have attacked the enemy");
            Debug.Log("attack: " + Mathf.Round((float)attack * 100) / 100);
        }
        // leveling up
        if (experience >= exptolevelup)
        {
            Levelup();
        }
        // winning
        
    }


    private void attacking()
    {

    }
  
    
    // for leveling up
    private void Levelup()
    {
      
        
        attack *= 125.25;
        level++;
        exptolevelup *= 1.45;
        combatLog.text = "level up";
        Debug.Log("level up");
    }

    private void Win()
    {
        if (level == 5)
        {
            combatLog.text = ("YOU HAVE BEATEN ME");
            Debug.Log("YOU HAVE BEATEN ME");
        }
    }
}


    //sort out attacking
  //if (isplayerturn)
  //    PlayerAttack();
 // else
  //    EnemyAttack();
