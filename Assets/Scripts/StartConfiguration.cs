using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConfiguration : MonoBehaviour
{
    //NO MODIFICAR
    void Start()
    {
        int multiplier = Random.Range(0, 4);
        float angle = 90f * multiplier;

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
