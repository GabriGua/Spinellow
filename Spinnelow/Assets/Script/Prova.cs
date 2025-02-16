using UnityEngine;

public class Prova : MonoBehaviour
{
    int a = 0;
    public int b = 0;
    public int c = 0;
    [SerializeField]int d = 0;
    [SerializeField]Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //inizializzazione variabili
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.AddForce(Vector2.right * 100);
    }

    // Update is called once per frame
    void Update()
    {
        //si esegue ogni singolo frame
        
    }
    void PlayerMovement()
    {
        
    }
}
