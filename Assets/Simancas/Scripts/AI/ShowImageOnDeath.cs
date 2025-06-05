using UnityEngine;

public class ShowImageOnDeath : MonoBehaviour
{
    public GameObject imagePrefab;
    private Transform playerCamera;

    void Start()
    {
        playerCamera = Camera.main.transform;
    }

    public void ShowImage()
    {
        if (imagePrefab == null) return;

        GameObject imageObject = Instantiate(imagePrefab, transform.position, Quaternion.identity);


        BillboardImage billboardScript = imageObject.AddComponent<BillboardImage>();
        billboardScript.SetTarget(playerCamera);
    }
}
