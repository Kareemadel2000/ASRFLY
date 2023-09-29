namespace ASRFLY.Code;

public static class MassageCollection
{
    public static void ShowEmptyDataMassage()
    {
        MessageBox.Show(Resources.EmptyMassageText, Resources.EmptyMassageCaption,
            MessageBoxButtons.OK,MessageBoxIcon.Information);
    }

    public static void ShowErrorServer()
    {
        MessageBox.Show(Resources.ServerErrorText, Resources.ServerErrorCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
