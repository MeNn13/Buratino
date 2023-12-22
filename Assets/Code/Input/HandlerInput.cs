using UnityEngine;
using UnityEngine.InputSystem;

public class HandlerInput : MonoBehaviour
{
    [Header("Character Input Values")]
    [SerializeField] private Vector2 move;

    public Vector2 GetMove { get => move; }

    public void OnMove(InputAction.CallbackContext context) => move = context.ReadValue<Vector2>();
}
