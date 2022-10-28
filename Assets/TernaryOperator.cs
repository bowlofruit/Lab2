using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour
{
    void Start()
    {
        int health = 10;
        string message = health > 0 ? "Player is Alive" : "Player is Dead";
        Debug.Log(message);
        health -= 20;
        message = health > 0 ? "Player is Alive" : "Player is Dead";
        Debug.Log(message);
    }
}