﻿namespace ASRFLY.Code;

public static class UserRolesManager
{
    private static Dictionary<string, bool> RolesList = new Dictionary<string, bool>();
    
    public static void Register(string RoleKey , bool RoleValue)
    {
        RolesList.Add(RoleKey, RoleValue);
    }

    public static bool GetRole(string RoleKey)
    {
        return RolesList[RoleKey];
    }

    public static void ClearRoles()
    {
        RolesList.Clear();
    }
}
