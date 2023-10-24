namespace ASRFLY.Gui.GuiProjects;

public partial class ProjectManagmentForm : Form
{
    private readonly int projectId;
    private readonly IDataHelper<InCome> _dataHelperInCome;
    private readonly IDataHelper<OutCome> _dataHelperOutCome;
    private double TotalInCome;
    private double TotalOutCome;

    public ProjectManagmentForm(int ProjectId)
    {
        _dataHelperInCome = (IDataHelper<InCome>)ConfigrationObjectManager.GetObject("InCome");
        _dataHelperOutCome = (IDataHelper<OutCome>)ConfigrationObjectManager.GetObject("OutCome");
        InitializeComponent();
        projectId = ProjectId;
        LoadOutComeUI();
        LoadInComeUI();
    }

    private void LoadOutComeUI()
    {
        // Laod OutCome UI
        OutComeUserControl outComeUserControl = new OutComeUserControl(projectId);
        outComeUserControl.Dock = DockStyle.Fill;
        panelOutCome.Controls.Add(outComeUserControl);
    }

    private void LoadInComeUI()
    {
        // Laod OutCome UI
        InComeUserControl inComeUserControl = new InComeUserControl(projectId);
        inComeUserControl.Dock = DockStyle.Fill;
        panelInCome.Controls.Add(inComeUserControl);

    }

    private void ProjectManagmentForm_Activated(object sender, EventArgs e)
    {
        GetTotalDataIncomeAndOutCome();
    }

    private void GetTotalDataIncomeAndOutCome()
    {
        try
        {
            // TotalInCome
            TotalInCome = _dataHelperInCome.GetAllData()
                .Where(x => x.ProjectId == projectId).Select(a => a.Amount).ToArray().Sum();

            //TotalOutCome
            TotalOutCome = _dataHelperOutCome.GetAllData()
                .Where(x => x.ProjectId == projectId).Select(a => a.Amount).ToArray().Sum();
        }
        catch { }
        var Rev = TotalInCome - TotalOutCome;

        // Set Data To UI 

        labelIncome.Text = "المقبوضات : " + TotalInCome.ToString("#0.00");
        labelOutcome.Text = "المصروفات : " + TotalOutCome.ToString("#0.00");
        labelRev.Text = "الارباح : " + Rev.ToString("#0.00");
    }

}
