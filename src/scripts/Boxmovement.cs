using UnityEngine;

public class Boxmovement : MonoBehaviour
{
    private Rigidbody2D body;

    [SerializeField] private float boxSpeed;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (body.transform.position.x > 12)
        {
            boxSpeed = Random.Range(13, 20);
            body.transform.position = new Vector2(-9, -1);
        }

        body.velocity = new Vector2(boxSpeed, 0);
    }
}