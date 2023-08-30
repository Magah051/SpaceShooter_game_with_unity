using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour
{
    // Start is called before the first frame update
    //Declarando o Rigdbody2D
    private Rigidbody2D meuRB;
    [SerializeField] private float vel = 10f;
    [SerializeField] private GameObject impacto;


    void Start()
    {
        //Pegando meu Rigdbody
        meuRB = GetComponent<Rigidbody2D>();
        //Indo para cima
        meuRB.velocity = new Vector2(0f, vel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Pegar o método PerdeVida e aplicar nele o dano
        //Checando se a tag de quem eu esotu colidindo é inimigo 01.
        if (collision.CompareTag("Inimigo"))
        {
            collision.GetComponent<InimigoPai>().PerdeVida(1);
        }
        
        //Checando se eu colidi com o player

        if (collision.CompareTag("Jogador"))
        {
            collision.GetComponent<PlayerController>().perdeVida(1);
        }
        Destroy(gameObject);

        //Criando o impacto
        Instantiate(impacto, transform.position, transform.rotation);
    }
}
