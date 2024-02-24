using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 touchStartPos;
    private bool isTouching;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isTouching = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = Input.mousePosition;
            isTouching = true;
        }

        if (isTouching && Input.GetMouseButton(0))
        {
            Vector2 touchDelta = (Vector2)Input.mousePosition - touchStartPos;

            Vector3 direction = Vector3.zero;
            if (touchDelta.x > 0)
            {
                direction = Vector3.right;
            }
            else if (touchDelta.x < 0)
            {
                direction = Vector3.left;
            }

            rb.velocity = direction * 10f;
        }

        if (Input.GetMouseButtonUp(0))
        {
            rb.velocity = Vector3.zero;
            isTouching = false;
        }
    }
}
