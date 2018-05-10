using GameFramework;
using GameFramework.Event;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
/// <summary>
/// 角色管理类,场景中所有的角色相关 显示对象和 数据对象
/// </summary>

public class CharacterSystem : ICharacterSystem
{
    private List<EntityLogicObjView> m_allObjectList = new List<EntityLogicObjView>();

    public CharacterData CreatCharacterData(int pvpId)
    {
        return CharacterDataSystem.CreatCharacterData(pvpId);
    }

    public void CreateCharacter(CharacterData charData)
    {
        switch (charData.charType)
        {
            case CharacterType.Character:
                GameEntry.Entity.ShowEntity<Character>(charData.pvpId, "Assets/xx/PlayerShip.prefab", "character", charData);
                break;
            case CharacterType.Monster:
                GameEntry.Entity.ShowEntity<Monster>(charData.pvpId, "Assets/xx/PlayerShip.prefab", "Monster", charData);
                break;
        }
    }

    //注意：角色对象 加载和初始化完成，调用
    public void addCharacter(EntityLogicObjView entityLogicView)
    {
        m_allObjectList.Add(entityLogicView);
    }

    public List<EntityLogicObjView> getAllPlayerList()
    {
        throw new System.NotImplementedException();
    }

    public List<EntityLogicObjView> getAllMonsterList()
    {
        throw new System.NotImplementedException();
    }

    public List<EntityLogicObjView> getAllBossList()
    {
        throw new System.NotImplementedException();
    }

    public EntityLogicObjView getCharacterByPvpId(int pvpId)
    {
        throw new System.NotImplementedException();
    }


    public CharacterData getCharacterDataByPvpId(int pvpId)
    {
        return CharacterDataSystem.GetCharacterDataByPvpId(pvpId);
    }

    public void disposeCharacter(EntityLogicObjView entityLogicView)
    {
        if (m_allObjectList.Contains(entityLogicView))
        {
            m_allObjectList.Remove(entityLogicView);
        }
    }

    public void disposeAllCharacter()
    {
        throw new System.NotImplementedException();
    }

}

