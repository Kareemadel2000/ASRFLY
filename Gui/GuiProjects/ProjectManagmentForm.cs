namespace ASRFLY.Gui.GuiProjects;

public partial class ProjectManagmentForm : Form
{
    private readonly int projectId;

    public ProjectManagmentForm(int ProjectId)
    {
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
}
