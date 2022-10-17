using UnityEngine;
using System.Collections;

public class ColorScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.red;
    }
}
