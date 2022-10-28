using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DictionaryClass : MonoBehaviour
{
    void Start()
    {
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuy magneto = badguys["mutant"];


        for (int i = 0; i <= 2; i++)
        {
            if (badguys.TryGetValue("birds", out BadGuy temp))
            {
                Debug.Log("Dictionary: success!");
            }
            else
            {
                Debug.Log("Dictionary: fail!");
                badguys.Add("birds", new BadGuy("Bird",100));
            }
        }
    }
}