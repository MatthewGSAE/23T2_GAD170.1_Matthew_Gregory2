using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Variables will go first

    [SerializeField] private double attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;
    [SerializeField] private int experience = 0;
    [SerializeField] private double exptolevelup = 10;


    public TMP_Text combatLog;

    

    // Methods will go underneath here

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

    }

    private void Update()
    {// attacking
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("you have attacked the enemy");
            Debug.Log("attack: " + Mathf.Round((float)attack * 100) / 100);
        }
        // leveling up
        if (experience >= exptolevelup)
        {
            Levelup();
        }
        // winning
        if (level == 5)
        {
            combatLog.text = ("YOU HAVE BEATEN ME");
            Debug.Log("YOU HAVE BEATEN ME");
        }
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
}
