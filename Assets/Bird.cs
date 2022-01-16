using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] KeyCode jumpButton;
    [SerializeField] Vector3 jumpVelocity;
    [SerializeField] AudioClip jumpSFX;

    [SerializeField] GameObject explosion;

    void Update()
    {
        if (Input.GetKeyDown(jumpButton))
        {
            Jump();
        }
    }

    void Jump()
    {
        if(jumpSFX != null)
            AudioSource.PlayClipAtPoint(jumpSFX, transform.position);

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = jumpVelocity;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
