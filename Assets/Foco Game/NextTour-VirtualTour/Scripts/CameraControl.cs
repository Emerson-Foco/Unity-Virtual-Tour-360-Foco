using UnityEngine;
using Cursor = UnityEngine.Cursor;

public class CameraControl : MonoBehaviour
{
    public bool activeController = false;
    public float sensitivity = 1.0f;

    private float _mouseX;
    private float _mouseY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            activeController = true;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            activeController = false;
        }

        if (activeController)
        {
            _mouseX += Input.GetAxis("Mouse X");
            _mouseY -= Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(_mouseY, _mouseX, 0);
        }
    }

    public void OnEnable()
    {
        activeController = false;
    }
}
