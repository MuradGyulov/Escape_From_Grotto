using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    [SerializeField] UnityEvent KeyIsTake;
    [SerializeField] ParticleSystem Par;

    private AudioSource Aus;
    private SpriteRenderer Spr;
    private BoxCollider2D box;

    private void Start()
    {
        Aus = GetComponent<AudioSource>();
        Spr = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
        Aus.volume = PlayerPrefs.GetFloat("Sounds volume");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            KeyIsTake.Invoke();
            Par.Play();
            Spr.enabled = false;
            box.enabled = false;
            Aus.Play();
            Destroy(this.gameObject, 1f);
        }
    }
}
