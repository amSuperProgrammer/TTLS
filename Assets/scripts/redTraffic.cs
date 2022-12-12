using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redTraffic : MonoBehaviour
{
    [SerializeField] Material redOBJ;
    [SerializeField] Material yellowOBJ;
    [SerializeField] Material greenOBJ;
    [SerializeField] Material redOBJ1;
    [SerializeField] Material yellowOBJ1;
    [SerializeField] Material greenOBJ1;

    [SerializeField] GameObject redBlock;

    Collider redCollid;

    void Update()
    {
        redCollid = redBlock.GetComponent<BoxCollider>();

        if (Input.GetKey(KeyCode.E))
            redChange(redOBJ, yellowOBJ, greenOBJ, redOBJ1, yellowOBJ1, greenOBJ1, redCollid);
        if(Input.GetKey(KeyCode.Q))
            greenChange(redOBJ, yellowOBJ, greenOBJ, redOBJ1, yellowOBJ1, greenOBJ1, redCollid);
    }

    static void redChange(Material red, Material yellow, Material green, Material red1, Material yellow1, Material green1, Collider redBlock)
    {
        red.color = new Color(255f, 0f, 0f, 0f);
        yellow.color = new Color(0f, 0f, 0f, 0f);
        green.color = new Color(0f, 0f, 0f, 0f);
        red1.color = new Color(0f, 0f, 0f, 0f);
        yellow1.color = new Color(0f, 0f, 0f, 0f);
        green1.color = new Color(0f, 255f, 0f, 0f);
        redBlock.enabled = true;
    }

    static void greenChange(Material red, Material yellow, Material green, Material red1, Material yellow1, Material green1, Collider redBlock)
    {
        red.color = new Color(0f, 0f, 0f, 0f);
        yellow.color = new Color(0f, 0f, 0f, 0f);
        green.color = new Color(0f, 255f, 0f, 0f);
        red1.color = new Color(255f, 0f, 0f, 0f);
        yellow1.color = new Color(0f, 0f, 0f, 0f);
        green1.color = new Color(0f, 0f, 0f, 0f);
        redBlock.enabled = false;
    }
}
