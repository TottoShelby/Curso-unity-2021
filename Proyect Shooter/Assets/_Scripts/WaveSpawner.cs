using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [Tooltip("Prefab de enemigo a generar")]
    public GameObject prefab;
    [Tooltip("tiempo en el que se inicia y finaliza la oleada")]
    public float startTime, endTime; //se pueden poner dos variables juntas si corresponden a lo mismo

    [Tooltip("tiempo entre la generacion de enemigos")]
    public float spawnrate;

    /*hay que determinar cuatro variables, la cantidad de enemigos al inicio, 
    la cantidad de enemigos para que pare el tiempo, 
    el tiempo entre spawns y que enemigo habra*/
    void Start()
    { 
        InvokeRepeating("SpawnEnemy", startTime, spawnrate);
        Invoke("CancelInvoke", endTime);
    }

    void SpawnEnemy()
    {
        //Quaternion q = Quaternion.Euler(0,transform.rotation.eulerAngles.y + Random.Range(-45.0f,45.0f),0);
        Instantiate(prefab, transform.position,transform.rotation);
    }
}
