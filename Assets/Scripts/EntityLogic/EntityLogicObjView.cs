using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public abstract class EntityLogicObjView : EntityLogic
{
    private EntityView m_entityView = null;
    private EntityDriveVisual m_entityDriveVisual = null;
    private EntityDriveMove m_entityDriveMove = null;
    private int m_pvpId;

    public int pvpId
    {
        get { return m_pvpId; }
        set { m_pvpId = value; }
    }

    public EntityView GetEntityView
    {
        get
        {
            return m_entityView;
        }
    }

    public EntityDriveVisual GetEntityDriveVisual
    {
        get
        {
            return m_entityDriveVisual;
        }
    }

    public EntityDriveMove GetEntityDriveMove
    {
        get
        {
            return m_entityDriveMove;
        }
    }
    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        m_entityView = new EntityView();
    }

    protected internal override void OnShow(object userData)
    {
        base.OnShow(userData);

    }

    protected internal override void OnHide(object userData)
    {
        OnReset();
        base.OnHide(userData);
    }

    protected internal override void OnAttached(EntityLogic childEntity, Transform parentTransform, object userData)
    {
        base.OnAttached(childEntity, parentTransform, userData);
    }

    protected internal override void OnDetached(EntityLogic childEntity, object userData)
    {
        base.OnDetached(childEntity, userData);
    }

    protected internal override void OnAttachTo(EntityLogic parentEntity, Transform parentTransform, object userData)
    {
        base.OnAttachTo(parentEntity, parentTransform, userData);
    }

    protected internal override void OnDetachFrom(EntityLogic parentEntity, object userData)
    {
        base.OnDetachFrom(parentEntity, userData);
    }

    protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(elapseSeconds, realElapseSeconds);
        if (m_entityDriveVisual != null)
        {
            m_entityDriveVisual.Update();
        }
        if (m_entityDriveMove != null)
        {
            m_entityDriveMove.Update();
        }
    }

    /////////////////////////////////////////////公开方法
    /// <summary>
    ///添加一个驱动器
    /// </summary>
    /// <param name="entityDrive"></param>
    public void AddDrive(EntityDriveEnum entityDrive)
    {
        if (EntityDriveEnum.EntityDrive_Visual == entityDrive)
        {
            m_entityDriveVisual = new EntityDriveVisual(this);
            m_entityDriveVisual.Create();
        }
        else if (EntityDriveEnum.EntityDrive_Move == entityDrive)
        {
            m_entityDriveMove = new EntityDriveMove(this);
            m_entityDriveMove.Create();
        }
    }

    public object OnMessage(EntityMessageEnum cmd, object param = null)
    {
        object ret = null;
        if (m_entityDriveVisual != null)
        {
            ret = m_entityDriveVisual.OnMessage(cmd, param);
            if (ret != null)
            {
                return ret;
            }
        }
        if (m_entityDriveMove != null)
        {
            ret = m_entityDriveMove.OnMessage(cmd, param);
            if (ret != null)
            {
                return ret;
            }
        }
        return null;
    }

    //内部清理，决绝外部调用
    protected virtual void OnReset()
    {
        if (m_entityDriveVisual != null)
        {
            m_entityDriveVisual.Close();
            m_entityDriveVisual = null;
        }
        if (m_entityDriveMove != null)
        {
            m_entityDriveMove.Close();
            m_entityDriveMove = null;
        }
        if (m_entityView != null)
        {
            m_entityView.Close();
        }
        m_entityView = null;
    }
}
