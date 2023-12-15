using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public float velocidad = 5f;

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        GetComponent<Rigidbody>().AddForce(movimiento * velocidad);
    }
}
