using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField][Range(0, 5)] private float moveSpeed;

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-1 * (moveSpeed * Time.deltaTime), 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(1 * (moveSpeed * Time.deltaTime), 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
            Debug.Log("Collision wth Enemy!");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
            Debug.Log("Trigger on Collecable!");
    }
    void Start()
    {
        moveSpeed = 3f;
    }
    void Update()
    {
        Move();
    }
}
