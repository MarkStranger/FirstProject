using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour

{
    [SerializeField] private int[] freeDays;
    [SerializeField] private string[] sumMon = new string[3] { "Июнь", "Июль", "Август" };
    

    void Start()
    {
        print("Сейчас" + sumMon[0]);
        print("Выходные" + freeDays[0] + freeDays[1] + freeDays[2] + freeDays[3]);
    }

    
    void Update()
    {
        
    }
}
