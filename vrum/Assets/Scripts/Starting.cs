using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Starting : MonoBehaviour
{
    [SerializeField] private Canvas start;

    void Start()
    {
        Invoke("DestroyStart", 3f);
    }

    void DestroyStart()
    {
        start.enabled = !start.enabled;
    }
}
