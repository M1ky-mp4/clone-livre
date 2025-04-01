using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagens : MonoBehaviour
{
    public int vida = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Inimigos")
        {
            vida -- ;
            Destroy(collision.gameObject);

            if (vida <= 0)
            {
                Destroy(this.gameObject);           
            }


        }


    }

    private void Update()
    {
        Mover();
    }

    void Mover()
    {
        Vector3 destino = Input.mousePosition;
        Vector3 posTela = Camera.main.ScreenToWorldPoint(destino);
        Vector3 posCorrecao = new Vector3(posTela.x, -4f, 0); 

        transform.position = Vector3.MoveTowards(transform.position, posCorrecao, 0.1f);

    }

}
