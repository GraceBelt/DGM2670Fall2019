﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
        //UpdateValueLimitZero(). As long as it's greater than or equal to zero, otherwise it will not work.
        //This is like health bar. It should be between 1 and 0.
        //How the functions work and what functions we used is up to me. 
        //As well the Asset. 

        public float amount = 1f;
        public float maxAmount = 0;

        public void UpdateValueLimitZero()
        {
                
        }
}


