using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public bool interactable = false;
    private Animator anim;
    public Rigidbody coinPrefab;
    public Transform spawner; // create an empty child in Unity and rename it to spawner

    private void Start ()
    {
        anim = GetComponent<Animator> ();
    }

    private void Update ()
    {
        if (interactable && Input.GetKeyDown (KeyCode.E))
        {
            anim.SetBool ("openChest", true);
            Rigidbody coinInstance = Instantiate (coinPrefab, spawner.position, spawner.rotation) as Rigidbody;
            coinInstance.AddForce (spawner.up * 100);
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactable = true;
        }
    }

    private void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactable = false;
        }

    }

}