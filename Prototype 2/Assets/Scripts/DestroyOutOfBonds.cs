using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBonds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float downBound = -10.0f;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.x > topBound)
        {
            if(this.tag == "Animal")
            {
                gameManager.GetComponent<GameManager>().LessLifes();
            }
            
            Destroy(gameObject);
        }else if(transform.position.z < downBound || transform.position.x < -topBound)
        { 
            if(this.tag == "Animal")
            {
                gameManager.GetComponent<GameManager>().LessLifes();
            }       
            Destroy(gameObject);
        }
    }
}
