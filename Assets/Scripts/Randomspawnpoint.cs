﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomspawnpoint : MonoBehaviour
{

    public Transform[] spawnpoints;
    public GameObject[] prefabs;
   // public GameObject Mouse;
     //public GameObject keyboard;
    //public GameObject gabinete;
  //  public GameObject monitor;
     int amountofthings=4;
    [SerializeField] bool misionempezada;



    private void Start()
    {
        //poner el bool mision empezada
        //spawnmouse();
        //spawnkeyboard();
        //spawngabinete();
        // spawnmonitor();
        Spawn();
    }

    public void Spawn()
    {

        if (misionempezada == true) { 
        List<Transform> freeSpawnPoints = new List<Transform>(spawnpoints);
        List<GameObject> Unusedobjects = new List<GameObject>(prefabs);
        
      
        for (int i=1; i <= amountofthings; i++)
        {
           
           
            
            if (Unusedobjects.Count < 0)
             { 
                    return; // Not enough spawn points
             }
            else
            {
                
                int index = Random.Range(0, freeSpawnPoints.Count-1);
                freeSpawnPoints.RemoveAt(index); // remove the spawnpoint from our temporary list
                int objectsindex = Random.Range(0, Unusedobjects.Count-1);
                Unusedobjects.RemoveAt(objectsindex);
                Instantiate(prefabs[objectsindex], freeSpawnPoints[index].position, freeSpawnPoints[index].rotation);
            }


        }

        }
    }
}
