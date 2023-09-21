namespace ASRFLY.Code;

public static class MassageCollection
{
    public static void ShowEmptyDataMassage()
    {
        MessageBox.Show(Resources.EmptyMassageText, Resources.EmptyMassageCaption,
            MessageBoxButtons.OK,MessageBoxIcon.Information);
    }
}
