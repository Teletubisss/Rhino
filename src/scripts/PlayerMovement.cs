
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;

    
    [SerializeField] private float speed ;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
                body.velocity = new Vector2(body.velocity.x, speed);

        if (Input.GetKey(KeyCode.Z))
        {
            body.transform.position = new Vector2(7.0f, -1.7f);
            body.transform.rotation = Quaternion.identity;
            body.velocity = new Vector2(0,0);
        }
    }
}