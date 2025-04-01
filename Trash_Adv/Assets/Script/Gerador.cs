using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{
    public List <GameObject> MeuObjeto;
    public float meuTempo;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meuTempo += Time.deltaTime;

        if (meuTempo > 1)
        {

            float posX = Random.Range(-3, 3);
            Vector3 novapos = new Vector3 (posX, 5.7f, 0);

            int ponteiro = Random.Range(0, MeuObjeto.Count);

            GameObject novoMonstro = Instantiate(MeuObjeto[ponteiro], novapos, Quaternion.identity);
            //Dar um tempo para o monstro morrer
            Destroy(novoMonstro, 3f);


            meuTempo = 0;
        }


      
    }
}
