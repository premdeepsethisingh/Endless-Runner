using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject  obstacle ; 
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float TimeBetweenSpawn ; 
    private float SpawnTime ;

   
    void Update()
    {
          if(Time.time > SpawnTime)
           {
                spawn();
                SpawnTime = Time.time + TimeBetweenSpawn ; 
                
           }
              
    }

   void spawn()
   {

       if(GameObject.FindGameObjectWithTag("Player") != null)
     {
        float randomX = Random.Range(minX , maxX);
        float randomY = Random.Range(minY,maxY);
        Instantiate(obstacle,transform.position + new Vector3(randomX,randomY,0),transform.rotation);
     }
   }
}
