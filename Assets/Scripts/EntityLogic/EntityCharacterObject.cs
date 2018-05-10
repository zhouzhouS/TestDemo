using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 可作为目标的实体类。比如英雄 怪物这些
/// </summary>
public class EntityCharacterObject : EntityLogicObjView
{
    public CharacterData charData;

    bool m_isDead;
    public bool IsDead
    {
        set { m_isDead = value; }
        get
        {
            return m_isDead;
        }
    }

    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        charData = (CharacterData)userData;
        GameEntry.characterSystem.addCharacter(this); 
    }

    protected internal override void OnHide(object userData)
    {
        base.OnHide(userData);
        GameEntry.characterSystem.disposeCharacter(this);
    }

    protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(elapseSeconds, realElapseSeconds);
        
    }
    

    //比如血量为0. 执行死亡
    protected virtual void OnDead()
    {
        GameEntry.Entity.HideEntity(this);
    }
}
