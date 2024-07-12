using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float panSpeed = 5f;
    public float panBorderThickness = 10f;
    public Joystick joystick;
    
    void Update()
    {
        if (GameManager.gameIsOver)
        {
            this.enabled = false;
            return;
        }
        float verticalMove = joystick.Vertical;
        
        if (joystick.Vertical >= .2f)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        else if (joystick.Vertical <= -.2f)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            verticalMove = 0f;
        }
        float horizontalMove = joystick.Horizontal;
        if (joystick.Horizontal >= .2f)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        else if (joystick.Horizontal <= -.2f)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            horizontalMove = 0f;
        }

        

        Vector3 pos = transform.position;

        pos.z = Mathf.Clamp(pos.z, -30f, -17f);
        pos.x = Mathf.Clamp(pos.x, -12f, 12f);

        transform.position = pos;

    }
}