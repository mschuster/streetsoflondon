﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoBehaviour {

    
	// Update is called once per frame
	void Start() {
        
        for(int i = 0; i < 10; i++)
        {
                ObjectPooler.Insatnce.SpawnFromPool("unit", new Vector3(300, 15+ i * 10f, -700), Quaternion.Euler(-90, 180, 0));
        }
        
	}
    
   
}
