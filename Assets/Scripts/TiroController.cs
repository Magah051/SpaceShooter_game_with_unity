using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour
{
    // Start is called before the first frame update
    //Declarando o Rigdbody2D
    private Rigidbody2D meuRB;
    [SerializeField] private float vel = 10f;
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
        Destroy(gameObject);
    }
}
