using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float rangoenemigo;

    public LayerMask capajugador;

    public Transform jugador;

    public float velocidad;

    bool estaralerta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estaralerta = Physics.CheckSphere(transform.position, rangoenemigo, capajugador);

        if(estaralerta == true)
        {
            Vector3 posjugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            transform.LookAt(posjugador);
            transform.position = Vector3.MoveTowards(transform.position, posjugador, velocidad * Time.deltaTime);
        }
    }
}
