using UnityEngine;

public class SpriteSorterLayer : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float offset = 0f;

    private int _sortingOrderBase = 0;
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponentInChildren<Renderer>();
    }

    void LateUpdate()
    {
        _renderer.sortingOrder = (int)(_sortingOrderBase - transform.position.y + offset);
    }
}
