using ASRFLY.Gui.GuiHome;

namespace ASRFLY.Gui.GuiCategories;

public partial class CategoryUserControl : UserControl
{
    //variables
    private static CategoryUserControl? _CategoryUserControl;
    //ctor
    public CategoryUserControl()
    {
        InitializeComponent();
    }

    #region Events
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        AddCategoryForm addCategoryForm = new AddCategoryForm();
        addCategoryForm.Show();
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        MassageCollection.ShowEmptyDataMassage();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {

    }

    private void buttonExport_Click(object sender, EventArgs e)
    {

    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {

    }

    private void textBoxSearch_TextChanged(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
    #endregion

    public static CategoryUserControl Instance()
    {
        return _CategoryUserControl ?? (new CategoryUserControl());
    }
}
