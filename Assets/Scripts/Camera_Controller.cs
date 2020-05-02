using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject player;
    public GameObject leftRight;

    public float mouseSensitivity;

    private float xAxisClamp;

    public float horizontalSpeed = 2.0f;

    public float verticalSpeed = 2.0f;


    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(0, 1, 1);
    }

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    public float sensHorizontal = 1000f;
    public float sensVertical = 1000f;

    public float _rotationX = 0;
    public float _rotationY = 0;
    // Update is called once per frame
    void Update()
    {
        //Refactor names to match old version

        //player.transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizontal, 0);

        _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
        _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); //Clamps the vertical angle within the min and max limits (45 degrees)

        _rotationY -= Input.GetAxis("Mouse X") * sensHorizontal;
        //_rotationY = Mathf.Clamp(_rotationY, minimumVert, maximumVert); //Clamps the vertical angle within the min and max limits (45 degrees)
        //float rotationY = transform.localEulerAngles.y;

        leftRight.transform.localEulerAngles = new Vector3(_rotationX, 0, 0);
        player.transform.localEulerAngles = new Vector3(0, -_rotationY, 0);

    }


}