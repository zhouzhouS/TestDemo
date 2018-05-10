using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 作用
/// 负责显示对象的旋转，动作播放 暂停控制，换装，变色，设置影子高度等
/// </summary>
public class EntityView
{

    Transform m_viewObj;
    public void initCreate(Transform view)
    {
        m_viewObj = view;
    }

    /// <summary>
    /// 绕X轴旋转
    /// </summary>
    /// <param name="fAngle"></param>
    public void rotateToX(float fAngle)
    {
        if (m_viewObj != null)
        {

        }
    }

    /// <summary>
    /// 绕Y轴旋转
    /// </summary>
    /// <param name="fAngle"></param>
    public void rotateToY(float fAngle)
    {
        if (m_viewObj != null)
        {

        }
    }

    /// <summary>
    /// 设置旋转欧拉角
    /// </summary>
    /// <param name="eulerAngle"></param>
    public void setRotate(Vector3 eulerAngle)
    {
        if (m_viewObj != null)
        {

        }
    }

    public void LookAt(Vector3 target, Vector3 up)
    {
        if (m_viewObj != null)
        {

        }
    }

    //播放动作
    public void playAction()
    {

    }

    //暂停动作
    public void pauseAni()
    {

    }

    //重新播放动作
    public void resumeAction()
    {

    }

    //修改部件
    public void changePart()
    {

    }

    public void Close()
    {

    }

}
