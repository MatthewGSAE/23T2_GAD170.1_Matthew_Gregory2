using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Variables will go first

    [SerializeField] private int attack;
    [SerializeField] private int health;
    [SerializeField] private int level;
    [SerializeField] private int experience;

    // Methods will go underneath here

    // Start is called before the first frame update
    private void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
        experience = 0;
    }


}
