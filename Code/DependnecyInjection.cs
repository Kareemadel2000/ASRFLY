using ASRFLY.Data.SqlServer;

namespace ASRFLY.Code;

public static class DependnecyInjection
{
    public static void AddDependnecyValue()
    {
        ConfigrationObjectManager.Register("Categories", new CategoriesEntity());
    }
}
