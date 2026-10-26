using UnityEngine;

public class SpawnBola : MonoBehaviour
{
    public GameObject bolaPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.y = 4f; // altura fija de caída
            Instantiate(bolaPrefab, pos, Quaternion.identity);
        }
    }
}