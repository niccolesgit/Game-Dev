using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManagerScript logic;
    public BirdScript bird;
    public AudioSource dingSFX;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
        dingSFX = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (bird.birdIsAlive == true)
            {
                logic.addScore(1);
                dingSFX.Play();

            }
            else 
            {
                logic.addScore(0);
            }
        }
    }
}
