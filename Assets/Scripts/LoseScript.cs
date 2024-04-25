using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    public GameObject LoseText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0 && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            LoseText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
