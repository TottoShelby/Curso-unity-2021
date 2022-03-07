using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    public float damage;
    private void OnTriggerEnter(Collider other)     
    {
        
        //Debug.Log(other.name); es para saber donde colisiona
        //Destroy (gameObject); PROHIBIDO YA QUE SE UTILIZA OBJECT POOLING QUE ES MEJOR
        gameObject.SetActive(false); //DESACTIVA LA BALA, LA DEVUELVE A LA POOL
        /*if (other.CompareTag("Enemy") || other.CompareTag ("Player"))
        {
            Destroy(other.gameObject);// --- DESTRUYE EL OTRO OBJETO (solo player o enemigo)
        }*/
        Life life = other.GetComponent<Life>();
        if (life!=null) // el != significa distinto a 
        {
        life.Amount -= damage; //el -= es lo mismo que poner life.amount = life.amount - damage;
        }
    }
}
