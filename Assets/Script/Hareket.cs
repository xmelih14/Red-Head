using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Hareket : MonoBehaviour
{
    public float hiz = 3f;
    Rigidbody2D rb;
    Vector3 hareket;
    float ziplama = 4.5f;
    public int score;
    public TextMeshProUGUI PlayerScore;
    public GameObject ressart;
    public GameObject GameOver;
    public AudioSource ses;
    public AudioSource jump;
    public AudioSource over;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }
    private void Update()
    {
        PlayerScore.text = score.ToString();
        hareket = new Vector3(Input.GetAxis("Horizontal"),0f);
        transform.position += hareket * hiz * Time.deltaTime;
        if(Input.GetButtonDown("Jump") && Mathf.Approximately(rb.velocity.y,0)) 
        {
            rb.AddForce(Vector3.up * ziplama,ForceMode2D.Impulse);
            jump.Play();
        }
        if(Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
       else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "engel")
        {
            Time.timeScale = 0;
            GameOver.SetActive(true);
            ressart.SetActive(true);
            ses.Stop();
            over.Play();
            
        } 
    }


}
