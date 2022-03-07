using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject shootingPoint;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = ObjectPool.SharedInstance.GetFirstPooledObject();
            bullet.layer = LayerMask.NameToLayer("Player Bullet"); //esto asigna la layer , capa, de player bullet a la bala disparada por el mismo, el nombre de la capa debe ser exacto.
            bullet.transform.position = shootingPoint.transform.position;
            bullet.transform.rotation = shootingPoint.transform.rotation;
            bullet.SetActive(true);
        }
    }
}
