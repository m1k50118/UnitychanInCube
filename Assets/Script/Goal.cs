using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&&other.gameObject.GetComponent<Player>().keyVale)
        {
            SceneManager.LoadScene("Goal");
        }
    }
}
