using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigueAlJugador : MonoBehaviour
{
    public GameObject Jugador;
    
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position + new Vector3(0f, 6f, 0f);
    }
}
