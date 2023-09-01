using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo02Controller : InimigoPai
{
    private Rigidbody2D meuRB;
    [SerializeField] private Transform posicaoTiro;


    // Start is called before the first frame update
    //Meu tiro
    [SerializeField] private GameObject meuTiro;
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
        //Dando a velocidade para o RB
        meuRB.velocity = Vector2.up * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        Atirando();
    }

    //Método de atirar
    private void Atirando()
    {
        //Pegando informaçõs dos meus filhos
        bool visivel = GetComponentInChildren<SpriteRenderer>().isVisible;

        if (visivel)
        {
            //Diminuir a minha espera, e se ela for menor ou igual a zero, então eu atiro.
            esperaTiro -= Time.deltaTime;
            if (esperaTiro <= 0)
            {
                //Instanciando o meu tiro
                Instantiate(meuTiro, posicaoTiro.position, transform.rotation);

                //Reiniciar a nossa espera
                esperaTiro = Random.Range(2f, 4f);
            }
        }
    }
}
