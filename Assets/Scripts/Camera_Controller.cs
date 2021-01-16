using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    
    
    public GameObject player;
    public GameObject leftRight;

    public float horizontalSpeed = 2.0f;

    public float verticalSpeed = 2.0f;

    public int target = 240;


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

    
  
    void Update()
    {
   

        _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
        _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); 

        _rotationY -= Input.GetAxis("Mouse X") * sensHorizontal;

     

        leftRight.transform.localEulerAngles = new Vector3(_rotationX, 0, 0);
        player.transform.localEulerAngles = new Vector3(0, -_rotationY, 0);

        if (target != Application.targetFrameRate)
        {
            Application.targetFrameRate = target;
        }
    }


}