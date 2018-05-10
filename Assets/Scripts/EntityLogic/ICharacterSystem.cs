using System;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
public interface ICharacterSystem
{
    //创建角色数据
    CharacterData CreatCharacterData(int pvpId);
    //创建角色
    void CreateCharacter(CharacterData charData);

    void addCharacter(EntityLogicObjView entityLogicView);
    List<EntityLogicObjView> getAllPlayerList();
    List<EntityLogicObjView> getAllMonsterList();
    List<EntityLogicObjView> getAllBossList();
    EntityLogicObjView getCharacterByPvpId(int pvpId);
    CharacterData getCharacterDataByPvpId(int pvpId);

    void disposeCharacter(EntityLogicObjView entityLogicView);

    void disposeAllCharacter();

}

