using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour {
    public float Power = 10;
    public float Angle = 45;
    public float Gravity = -10;    
    private Vector3 MoveSpeed;
    private Vector3 GritySpeed = Vector3.zero;
    private float dTime;
    private Vector3 currentAngle;

    // Use this for initialization
    void Start()
    {
        MoveSpeed = Quaternion.Euler(new Vector3(0, 0, Angle)) * Vector3.right * Power;
        currentAngle = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GritySpeed.y = Gravity * (dTime += Time.fixedDeltaTime);
        transform.position += (MoveSpeed + GritySpeed) * Time.fixedDeltaTime;
        currentAngle.z = Mathf.Atan((MoveSpeed.y + GritySpeed.y) / MoveSpeed.x) * Mathf.Rad2Deg;
        transform.eulerAngles = currentAngle;
    }
    //   private GameObject ball;
    //   public float g = 9.81f;  //g = 9.81 m/s^2
    //   public float speed = 0.8f; //物體transform在拋物線路徑上移動的速度，此速度不影響拋物線的形狀
    //   public float V0 = 8.0f; //初速度
    //   public float ground = 0f;
    //   public GameObject target;
    //   Rigidbody2D rigidBody;
    //   Vector3 currentPosition;
    //   Vector3 initPosition;
    //   void Start () {
    //       target = gameObject.GetComponent<GameObject>();
    //       ball = GameObject.Find("/" + Player.getBall);
    //       rigidBody = gameObject.GetComponent<Rigidbody2D>();
    //       initPosition = gameObject.transform.position;

    //       //if (Player.isShoot)
    //       //{
    //       //    ball = GameObject.Find("/" + Player.getBall);
    //       //    Debug.Log(ball);
    //       //    float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    //       //    float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    //       //    transform.Translate(0, -x, y);
    //       //    Player.isShoot = false;
    //       //}
    //   }

    //// Update is called once per frame
    //void Update () {
    //       //if (currentPosition.y < 4.82)
    //       //{
    //       Vector3 dir = (target.transform.position - initPosition).normalized; //先取得初始投射方向的向量
    //       if (dir.x == 0) dir.x = 0.001f; //避免x=0無法移動
    //       float theta = Mathf.Atan2(dir.y, dir.x); //再由向量求得初始角度
    //       float nextX = (transform.position.x - initPosition.x) + speed * Time.deltaTime;

    //       //使用公式 y = y0 + x * tan(theta) - (g * x^2)/(2 * (v * cos(theta))^2); 來取得y座標
    //       float nextY = initPosition.y + nextX * Mathf.Tan(theta) - (g * Mathf.Pow(nextX, 2)) / (2 * Mathf.Pow(V0 * Mathf.Cos(theta), 2));
    //       //currentPosition = initPosition;
    //       //currentPosition.y = initPosition.y + Time.deltaTime;
    //       currentPosition = new Vector3(nextX, nextY, 0);
    //       rigidBody.MovePosition(currentPosition);
    //       //}
    //       //float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    //       //float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    //       //transform.Translate(0, -x, y);
    //   }



}
