using UnityEngine;
using UnityEngine.InputSystem;

public class HandlerInput : MonoBehaviour
{
    [Header("Character Input Values")]
    [SerializeField] private Vector2 move;
    [SerializeField] private bool isInteraction;

    public Vector2 GetMove { get => move; }
    public bool IsInteraction { get => isInteraction; }

    public void OnMove(InputAction.CallbackContext context) => move = context.ReadValue<Vector2>();

    public void OnInteract(InputAction.CallbackContext context) => isInteraction = context.action.triggered;
}
