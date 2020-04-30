using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExample : MonoBehaviour
{
    public CapsuleCollider playerCollider;
    public float moveSpeed = 5f;
    //private GameObject enemy;
    private EnemyExample enemyScript;
    private RaycastHit hit;
    private Ray ray;
    public float rayDistance = 4f;

    void Start ()
    {
        playerCollider = this.GetComponent<CapsuleCollider> ();
        playerCollider.height = 1f;
        playerCollider.center = new Vector3 (0f, 0.5f, 0f);

        //enemy = GameObject.Find("Battle_Dummy");
    }

    void Update ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);

        // Move the player's character
        transform.Translate (movement * Time.deltaTime * moveSpeed);

        ray = new Ray (transform.position + new Vector3 (0f, playerCollider.center.y, 0f), transform.forward);
        Debug.DrawRay (ray.origin, ray.direction * rayDistance, Color.red);

        if (Physics.Raycast (ray, out hit))
        {
            if (hit.distance < rayDistance)
            {
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    print ("Enemy spotted!");
                }
            }
        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        // remember to specify the tags
        if (collision.gameObject.tag == "Enemy")
        {
            enemyScript = collision.gameObject.GetComponent<EnemyExample> ();
            enemyScript.enemyHealth--;
        }
    }
}