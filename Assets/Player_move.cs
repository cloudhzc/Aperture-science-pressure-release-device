using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player_move : MonoBehaviour
{
    public float MoveSpeed;//移动速度
    public float gravity = 9.8f;//重力
    public float JumpSpeed = 15f;//起跳速度
    public CharacterController PlayerController;
    private float horizontal;//记录W,A,S,D键的数据,即X轴和Y轴
    private float vertical;//记录W,A,S,D键的数据,即X轴和Y轴
    Vector3 Player_Move;
    void Start()
    {
        
    }
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");//获取X轴方向的值
        vertical = Input.GetAxis("Vertical");//获取Z轴方向的值
        Player_Move = (transform.forward * vertical + transform.right * horizontal) * MoveSpeed;
        if(PlayerController.isGrounded)//如果不是在地面上就不能移动
        {
            if (Input.GetAxis("Jump")==1)//按下空格键
            {
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
                Player_Move.y = Player_Move.y + JumpSpeed / 10;
            }
        }
        Player_Move.y = Player_Move.y - gravity * Time.deltaTime;
        //模拟重力下降的效果,让向上的量减去重力下降的量
        //deltaTime是距上一帧所经历的时间 
        PlayerController.Move(Player_Move*Time.deltaTime);
    }
}
