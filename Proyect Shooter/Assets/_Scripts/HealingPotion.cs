using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPotion : MonoBehaviour
{
    public float heal;
    private void OnTriggerEnter(Collider other) 
    {
        Life life = other.GetComponent<Life>();
        life.Amount += heal;

        Animator anim = GetComponent<Animator>();
        anim.SetTrigger("Expire");

        Destroy(gameObject, 3);
    }

}
