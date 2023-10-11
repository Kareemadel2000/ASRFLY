namespace ASRFLY.Code;
public static class DependnecyInjection
{
    public static void AddDependnecyValue()
    {
        ConfigrationObjectManager.Register("Categories", new CategoriesEntity());
        ConfigrationObjectManager.Register("SystemRecord", new SystemRecordEntity());
        ConfigrationObjectManager.Register("Customers", new CustomersEntity());
    }
}
