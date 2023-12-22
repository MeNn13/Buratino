using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float speed = 5f;

    private HandlerInput _input;
    private Rigidbody2D _rb;

    void Start()
    {
        _input = GetComponent<HandlerInput>();
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move(_input.GetMove);
    }

    private void Move(Vector2 direction)
    {
        _rb.MovePosition(_rb.position + direction * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        IInteracted interacted;

        if (collision.TryGetComponent(out interacted) && _input.IsInteraction)
            interacted.Interact();
    }
}
