using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform Target;


    public Transform CameraJoint;

    public Camera Camera;

    //パラメータとなる変数

    public Vector3 Position;  
    
    public Vector3 Angles;

    public Vector3 Distance;
    void Start()
    {
        
    }

   
    void Update()
    {
        //Updateで計算した結果を反映する

        transform.position = Position;
        transform.eulerAngles = Angles;
        CameraJoint.localPosition = Distance;
       
        //カメラを動かせるようにする
        
    }
}
