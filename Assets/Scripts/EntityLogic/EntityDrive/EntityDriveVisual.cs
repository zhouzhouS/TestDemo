using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityDriveVisual : EntityDrive
{
    public EntityDriveVisual(EntityLogicObjView owner)
    {
        m_Owner = owner;
    }

    public void Create()
    {
        RegisterMessageDelegate(EntityMessageEnum.EntityCommand_SetPos, OnSetPos);
    }

    private object OnSetPos(object param)
    {
        if (m_Owner != null)
        {
            Vector3 pos = (Vector3)param;
            //////////例子---设置位置 后续完善
        }
        return null;
    }


    public override void Update()
    {
        if (m_Owner == null)
        {
            return;
        }


    }
    public override void Close()
    {
        Clear();
    }
}

