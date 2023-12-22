using UnityEngine;

public class NPC : MonoBehaviour, IInteracted
{
    [SerializeField] private string NpcName;

    public void Interact()
    {
        Debug.Log($"My name is {NpcName}");
    }
}
