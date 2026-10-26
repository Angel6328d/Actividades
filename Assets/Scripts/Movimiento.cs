using UnityEngine;
using UnityEngine.InputSystem;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        Vector2 dir = Vector2.zero;
        var k = Keyboard.current;
        if (k == null) return;

        if (k.leftArrowKey.isPressed || k.aKey.isPressed) dir.x -= 1;
        if (k.rightArrowKey.isPressed || k.dKey.isPressed) dir.x += 1;
        if (k.upArrowKey.isPressed || k.wKey.isPressed) dir.y += 1;
        if (k.downArrowKey.isPressed || k.sKey.isPressed) dir.y -= 1;

        transform.Translate(dir * velocidad * Time.deltaTime);
    }
}