using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    [SerializeField] GameObject red;
    Renderer redChange;
    [SerializeField] GameObject yellow;
    Renderer yellowChange;
    [SerializeField] GameObject green;
    Renderer greenChange;
    Renderer Color;

    private void Start()
    {
        Color= GetComponent<Renderer>();
        redChange= red.GetComponent<Renderer>();
        yellowChange = yellow.GetComponent<Renderer>();
        greenChange = green.GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            changeGreen(redChange, yellowChange, greenChange);
        }
    }

    static void changeGreen(Renderer red, Renderer yellow, Renderer green)
    {
        red.material.color = new Color(0f,0f,0f,0f);
        green.material.color = new Color(0f,255f,0f,0f);
    }
}
