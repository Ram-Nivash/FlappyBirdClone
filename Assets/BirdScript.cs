using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrength;
    public LogicScript Logic;
    public bool BirdIsalive = true;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        gameObject.name = "boby";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdIsalive){
            myRigidbody.velocity = Vector2.up*FlapStrength;
            }
        
    }
   private void OnCollisionEnter2D(Collision2D collision){

    Logic.gameOver();
    BirdIsalive = false;
   }
}
