using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBO1 : MonoBehaviour
{
    public float velocidad = 5f;
    private string nombre = "Cubito";

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nombre = value;
            }
        }
    }

    private void FixedUpdate()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        float speed_x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(speed_x, 0, 0) * velocidad * Time.fixedDeltaTime;
    }
}
