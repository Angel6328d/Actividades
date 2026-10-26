using UnityEngine;
using UnityEngine.InputSystem;

public class Nave : MonoBehaviour
{
    public float empuje = 5f;
    public float giro = 150f;
    Rigidbody2D rb;

    void Start() { rb = GetComponent<Rigidbody2D>(); }

    void Update()
    {
        var k = Keyboard.current;
        if (k == null) return;

        float rot = 0;
        if (k.leftArrowKey.isPressed || k.aKey.isPressed) rot += 1;
        if (k.rightArrowKey.isPressed || k.dKey.isPressed) rot -= 1;
        transform.Rotate(0, 0, rot * giro * Time.deltaTime);

        if (k.upArrowKey.isPressed || k.wKey.isPressed)
            rb.AddForce(transform.up * empuje);
    }
}