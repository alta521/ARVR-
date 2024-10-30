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
        //if �ε��� ��ü rigidbody �� => �� �չ������� �� 10
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
        //�ε����� �ڽ��ı�.
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
