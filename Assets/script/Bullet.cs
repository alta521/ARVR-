using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    Rigidbody rb;
    public GameObject bulletfx;
    public AudioClip shootingSound;
    //private AudioSource bulletsound;

    void Start()
    {
        //bulletsound = gameObject.GetComponent<AudioSource>();
        //bulletsound.clip = shootingSound;
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        PlaySound();
    }

    void Update()
    {
        transform.forward = rb.velocity.normalized;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if ºÎµúÈù ¹°Ã¼ rigidbody ÀÖ => ³» ¾Õ¹æÇâÀ¸·Î Èû 10
        Instantiate(bulletfx, transform.position, Quaternion.identity);
        //if (bulletsound != null)
        //{
        //    bulletsound.Play();
        //}
        var otherRB =
            collision.gameObject.GetComponent<Rigidbody>();
        if (otherRB != null)
        {
            otherRB.AddForce(transform.forward * 10, ForceMode.Impulse);

        }
        //ºÎµúÈ÷¸é ÀÚ½ÅÆÄ±«.
        Destroy(bulletfx, 2f);
        Destroy(this.gameObject);
    }
    private void PlaySound()
    {
        GameObject soundobj = new GameObject("shootingSdfx");
        AudioSource audioSource = soundobj.AddComponent<AudioSource>();
        audioSource.clip = shootingSound;
        audioSource.Play();
        Destroy(soundobj, 2f);

    }
}
