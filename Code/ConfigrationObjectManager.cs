namespace ASRFLY.Code;

public static class ConfigrationObjectManager
{
    private static Dictionary<string, object> ObjectList = new Dictionary<string, object>();
    
    public static void Register(string ObjectKey , object ObjectValue)
    {
        ObjectList.Add(ObjectKey , ObjectValue);
    }

    public static object GetObject(string ObjectKey)
    {
        return ObjectList[ObjectKey];
    }
}
