using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
    [Range(-100, 100)] public int speed = 0;

    void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
    }
}