using ASRFLY.Core.Entityes;

namespace ASRFLY.Gui.GuiProjects;

public partial class ProjectManagmentForm : Form
{
    private readonly int projectId;

    public ProjectManagmentForm(int ProjectId)
    {
        InitializeComponent();
        projectId = ProjectId;
        LoadOutComeUI();
    }

    private void LoadOutComeUI()
    {
        // Laod OutCome UI
        OutComeUserControl outComeUserControl = new OutComeUserControl(projectId);
        outComeUserControl.Dock = DockStyle.Fill;
        panelOutCome.Controls.Add(outComeUserControl);
    }
}
