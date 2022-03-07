using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    
    [SerializeField]
    private float amount;

    public float Amount 
    {
        get => amount;
        set 
        {
            amount = value;
            if(amount <=0) 
            {
            Animator anim = GetComponent<Animator>();
            anim.SetTrigger("Play Die");

            Invoke("PlayDestruction", 1); //el invoke en este caso se hace para darle un tiempo a la explosion que se detalla debajo.
            Destroy(gameObject, 2);
            }
        }
    }

    void PlayDestruction()
    {
        ParticleSystem explosion = GetComponentInChildren<ParticleSystem>(); 
        explosion.Play();
    }
}
