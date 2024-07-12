using UnityEngine;

public class ShopController : MonoBehaviour
{
    public static ShopController Instance;
    private Camera mainCamera;
    public GameObject shop;
    void Start()
    {
        mainCamera = Camera.main;
    }
    
    void OpenShopPanel()
    {
        shop.SetActive(true);
    }
    void Update()
    {
        // Check if there are any touches
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = mainCamera.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // Perform a raycast to detect if a cube is touched
                if (Physics.Raycast(ray, out hit))
                {
                    // Check if the touched object is this cube
                    if (hit.transform == transform)
                    {
                        Shop.cubePosition = transform;
                        OpenShopPanel();
                    }
                }
            }
            
        }
    }
}
