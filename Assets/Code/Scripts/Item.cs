using UnityEngine;

public class Item : MonoBehaviour, IInteracted
{
    public void Interact()
    {
        Debug.Log($"Pickup Item - {gameObject.name}");
        Destroy(gameObject);
    }
}
