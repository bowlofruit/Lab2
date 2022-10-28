using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListClass : MonoBehaviour
{
    void Start()
    {
        List<BadGuy> badguys = new List<BadGuy>
        {
            new BadGuy("Harvey", 50),
            new BadGuy("Magneto", 100),
            new BadGuy("Pip", 5)
        };

        badguys.Sort();

        foreach (BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        badguys.Clear();
    }
}