using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityInfoManager : MonoBehaviour
{
    public static AbilityInfoManager instance;
    public AbilityInformation[] abilityInfos;

    private void Start()
    {
        instance = this;
    }



    public string GetAbilityDesc(ECardAbility ability)
    {
        foreach (AbilityInformation abilityInfo in abilityInfos)
        {
            if (abilityInfo.ability == ability)
            {
                return abilityInfo.desc;
            }
        }

        return "";
    }
}
