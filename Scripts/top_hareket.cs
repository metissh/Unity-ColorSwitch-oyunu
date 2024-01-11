using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class top_hareket : MonoBehaviour
{
    Rigidbody2D top;
    Transform renkDegistirici;
    public float ziplamaGucu;
    public Color turkuazRenk, sariRenk, pembeRenk, morRenk;
    public string mevcutRenk;
    public SpriteRenderer ressam;
    public TextMeshProUGUI skorYazisi;
    int skor = 0;
    public AudioSource zýplamaSesi;

    public GameObject cember, double_cember, kare, zemin;
    void Start()
    {
        top = GameObject.Find("top").GetComponent<Rigidbody2D>();
        renkDegistirici = GameObject.Find("Renk_Degistirici").GetComponent<Transform>();
        dondur.donuzHizi = 0.3f;
        renkDegis(); 
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            top.velocity = Vector2.up * ziplamaGucu;
            zýplamaSesi.Play();
        }
        skorYazisi.text = "Skor :" + skor.ToString();

    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.tag != mevcutRenk && temas.tag != "renkDegistirici")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(temas.tag == "renkDegistirici")
        {
            renkDegis();
            skor++;
            olustur();
            renkDegistirici.position = new Vector3(renkDegistirici.position.x, renkDegistirici.position.y + 8,renkDegistirici.position.z);
            dondur.donuzHizi += 0.02f;
        }
    }
    void olustur()
    {
        int rastgele = Random.Range(0, 3);
        
        
        switch (rastgele)
        {
            case 0:
                GameObject instance = Instantiate(cember, new Vector3(renkDegistirici.position.x, renkDegistirici.position.y + 20, renkDegistirici.position.y),Quaternion.identity);
                break;
            case 1:
                _ = Instantiate(double_cember, new Vector3(renkDegistirici.position.x, renkDegistirici.position.y + 20, renkDegistirici.position.y), Quaternion.identity);
                break;
            case 2:
                _ = Instantiate(kare, new Vector3(renkDegistirici.position.x, renkDegistirici.position.y + 20, renkDegistirici.position.y), Quaternion.identity);
                break;
        }
    }
    void renkDegis()
    {
        int rastgele = Random.Range(0, 4);
        switch(rastgele)
        {
            case 0:
                mevcutRenk = "turkuaz";
                ressam.color = turkuazRenk;
                break;
            case 1:
                mevcutRenk = "sari";
                ressam.color = sariRenk;
                break;
            case 2:
                mevcutRenk = "pembe";
                ressam.color = pembeRenk;
                break;
            case 3:
                mevcutRenk = "mor";
                ressam.color = morRenk;
                break;
        }
    }
}
