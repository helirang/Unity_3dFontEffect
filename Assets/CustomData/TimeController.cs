using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    [Range(0,100)]
    [SerializeField] float setTime;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = setTime;
    }
}
