using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestCollectable : MonoBehaviour {

    public PlayerController kenji;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D ChestCollider)
    {
        if (ChestCollider.gameObject.name.Equals("Attack"))
        {
            HealthManager.health -= 1f;
            
            SceneManager.LoadScene("");
        }
    }
}
