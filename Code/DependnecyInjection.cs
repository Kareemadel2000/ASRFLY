namespace ASRFLY.Code;
public static class DependnecyInjection
{
    public static void AddDependnecyValue()
    {
        ConfigrationObjectManager.Register("Categories", new CategoriesEntity());
        ConfigrationObjectManager.Register("SystemRecord", new SystemRecordEntity());
        ConfigrationObjectManager.Register("Customers", new CustomersEntity());
        ConfigrationObjectManager.Register("Suppliers", new SuppliersEntity());
        ConfigrationObjectManager.Register("Projects", new ProjectsEntity());
        ConfigrationObjectManager.Register("OutCome", new OutComeEntity());
        ConfigrationObjectManager.Register("InCome", new InComeEntity());
        ConfigrationObjectManager.Register("Users", new UsersEntity());
        ConfigrationObjectManager.Register("UsersRoles", new UsersRolesEntity());

    }
}
