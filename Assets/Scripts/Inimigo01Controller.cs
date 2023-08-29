using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo01Controller : MonoBehaviour
{
    //Pegar o Rigdbody
    private Rigidbody2D meuRB;
    [SerializeField] private float velocidade = -3f;

    //Pegando o transform da posi��o do meu tiro
    [SerializeField] private Transform posicaoTiro;

    [SerializeField] private int vida = 1;

    //Meu tiro
    [SerializeField] private GameObject meuTiro;

    [SerializeField] private GameObject explosao;
         
    private float esperaTiro = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Peganfo meu RB
        meuRB = GetComponent<Rigidbody2D>();
        //Dando a velocidade para o RB
        meuRB.velocity = new Vector2(0f, velocidade);

        //Deixando a espera aleat�ria para o primeiro tiro
        //1f = 1 segundo
        esperaTiro = Random.Range(0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //Checar se meu sprite renderer est� vis�vel

        //Pegando informa��s dos meus filhos
        bool visivel = GetComponentInChildren<SpriteRenderer>().isVisible;

        if (visivel)
        {
            //Diminuir a minha espera, e se ela for menor ou igual a zero, ent�o eu atiro.
            esperaTiro -= Time.deltaTime;
            if (esperaTiro <= 0)
            {
                //Instanciando o meu tiro
                Instantiate(meuTiro, posicaoTiro.position, transform.rotation);

                //Reiniciar a nossa espera
                esperaTiro = Random.Range(1.5f, 2f);
            }
        }

   }

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
