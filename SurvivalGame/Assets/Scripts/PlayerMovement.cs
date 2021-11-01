using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidBody.velocity.y) < 0.001f)
        {
            _rigidBody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

    }
}
