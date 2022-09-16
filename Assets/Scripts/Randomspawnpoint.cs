using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomspawnpoint : MonoBehaviour
{

    public Transform[] spawnpoints;
    public GameObject[] prefabs;
    int randomspawnpoint;
    int randomprefab;
    public bool misionempezada=false;
    public float timespawn;
    bool timeon=false;


    
    private void Start()
    {
        
        //poner el bool mision empezada
        //spawnmouse();
        //spawnkeyboard();
        //spawngabinete();
        // spawnmonitor();
        
    }

    private void Update()
    {
        if (misionempezada == true)
        {
            timeon = true;
            if (timespawn > 0)
            {
                InvokeRepeating("Spawn", 0f, 1000000f);
                timespawn -= Time.deltaTime;
            }
            else
            {
                CancelInvoke("spawn");
            }
        }
        misionempezada = dialoguemanager.misionempezadadialogue;
        //Spawn();
       
    }
    
    public void Spawn()
    {

        if (misionempezada == true)
        {

            randomspawnpoint = Random.Range(0, spawnpoints.Length);
            randomprefab = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[randomprefab], spawnpoints[randomspawnpoint].position, Quaternion.identity);
           
         
            




        }


    }
   
}
       
 

