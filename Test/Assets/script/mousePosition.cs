using UnityEngine;

public class MousePosition2D : MonoBehaviour
{
    public float moveSpeed = 1f;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition; 
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0f;

        transform.position = Vector2.Lerp(
            transform.position,
            mousePosition,
            moveSpeed * Time.deltaTime
        );
    }
}
