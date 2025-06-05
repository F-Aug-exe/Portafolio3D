using UnityEngine;

public class BillboardImage : MonoBehaviour
{
    private Transform playerCamera;
    public float rotationSpeed = 10f;

    public void SetTarget(Transform camera)
    {
        playerCamera = camera;
    }

    void Update()
    {
        if (playerCamera == null) return;

        // Girar la imagen para que siempre mire al jugador
        transform.LookAt(playerCamera);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
