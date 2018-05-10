using System;
using System.Collections.Generic;
using UnityGameFramework.Runtime;

// 消息处理函数
public delegate object MessageDelegate(object param = null);
public class EntityDrive : GEventDispatcher
{
    protected EntityLogicObjView m_Owner = null;
    protected Dictionary<EntityMessageEnum, MessageDelegate> m_MessageDelegate = new Dictionary<EntityMessageEnum, MessageDelegate>();

     
    public EntityLogic GetOwner()
    {
        return m_Owner;
    }

    protected void RegisterMessageDelegate(EntityMessageEnum msg, MessageDelegate msgProc)
    {
        m_MessageDelegate[msg] = msgProc;
    }
    public virtual void Update()
    {

    }
    public virtual void Close()
    {

    }
    protected void Clear()
    {
        m_MessageDelegate.Clear();
        m_MessageDelegate = null;
        m_Owner = null;
        base.Dispose();
    }

    public object OnMessage(EntityMessageEnum cmd, object param = null)
    {
        if (m_MessageDelegate.ContainsKey(cmd))
        {
            return m_MessageDelegate[cmd].Invoke(param);
        }
        return null;
    }
}

