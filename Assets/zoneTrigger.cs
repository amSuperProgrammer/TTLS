using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class zoneTrigger : MonoBehaviour
{
    void Update()
    {
        GameObject car = GameObject.FindWithTag("car");
        Collider carCollider = car.GetComponent<Collider>();
        int colliderCar = 0;

        colliderCar = OnTriggerStay(carCollider);

        if(colliderCar == 1)
        {
            transform.Rotate(Vector3.up);
        }
    }

    static int OnTriggerStay(Collider car)
    {
        return 1;
    }
}
