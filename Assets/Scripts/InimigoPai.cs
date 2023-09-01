using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoPai : MonoBehaviour
{
    // Start is called before the first frame update
    //Atributos que todos os inimigos devem ter
    [SerializeField] protected float velocidade;
    [SerializeField] protected int vida;
    [SerializeField] protected GameObject explosao;
    //Meu tiro
    [SerializeField] protected GameObject meuTiro;
    protected float esperaTiro = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Criando o m�todo perde vida
    public void PerdeVida(int dano)
    {
        //Perdendo a minha vida com base no dano
        vida -= dano;
        //Checando se eu morri
        if (vida <= 0)
        {
            Destroy(gameObject);

            //Criando a minha explos�o
            Instantiate(explosao, transform.position, transform.rotation);
        }

    }
}
