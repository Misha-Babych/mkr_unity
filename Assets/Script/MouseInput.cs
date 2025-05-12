using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public Camera mainCamera;
    public MouseController mouse;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Food") || hit.collider.CompareTag("Exit"))
                {
                    mouse.MoveTo(hit.point);
                }
            }
        }
    }
}
