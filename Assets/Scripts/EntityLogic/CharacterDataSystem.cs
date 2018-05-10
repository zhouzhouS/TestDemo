using System.Collections.Generic;

public class CharacterDataSystem
{
    //玩家数据data
    private static Dictionary<int, CharacterData> m_charDataDic = new Dictionary<int, CharacterData>();


    //创建角色数据
    public static CharacterData CreatCharacterData(int pvpId)
    {
        CharacterData charD = null;
        if (m_charDataDic.ContainsKey(pvpId))
        {
            charD = m_charDataDic[pvpId];
            charD.reset();
            charD.pvpId = pvpId;
        }
        else
        {
            charD = new CharacterData(pvpId, -1);
            m_charDataDic[pvpId] = charD;
        }
        return charD;
    }

    //通过pvpId 获得角色数据
    public static CharacterData GetCharacterDataByPvpId(int pvpid)
    {
        if (m_charDataDic.ContainsKey(pvpid))
        {
            return m_charDataDic[pvpid];
        }
        return null;
    }

    //通过pvpId 移除对应的数据data
    public static void RemoveCharacterDataByPvpId(int pvpid)
    {
        if (m_charDataDic.ContainsKey(pvpid))
        {
            m_charDataDic.Remove(pvpid);
        }
    }

    //copy一份数据
    public static CharacterData CopyCharData(CharacterData sourceData)
    {
        return null;
    }

    public static void ClearAll()
    {
        
    }
}
