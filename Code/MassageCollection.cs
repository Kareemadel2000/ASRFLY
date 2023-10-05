namespace ASRFLY.Code;

public static class MassageCollection
{
    //Massage
    #region Massage
    public static void ShowEmptyDataMassage()
    {
        MessageBox.Show(Resources.EmptyMassageText, Resources.EmptyMassageCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void ShowErrorServer()
    {
        MessageBox.Show(Resources.ServerErrorText, Resources.ServerErrorCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public static void ShowFieldsRquired()
    {
        MessageBox.Show(Resources.FieldsRquiredText, Resources.FieldsRquiredCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void ShowRquiredDeleteRow()
    {
        MessageBox.Show(Resources.ShowReDeleteFieldText, Resources.ShowReDeleteFieldCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    } 
    #endregion

    //Dialog
    #region Dialog
    public static bool ShowDeleteDialog()
    {
        var result = MessageBox.Show(Resources.DeleteDialogText, Resources.DeleteDialogCaption,
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion

    //Notifications
    #region Notifications
    public static void ShowAddNotifications()
    {
        NotificationForm notificationForm = new NotificationForm();
        notificationForm.labelTitle.Text = "تمت عملية الاضافة بنجاح";
        notificationForm.Show();
    }

    public static void ShowUpdateNotifications()
    {
        NotificationForm notificationForm = new NotificationForm();
        notificationForm.labelTitle.Text = "تمت عملية التعديل بنجاح";
        notificationForm.Show();
    }

    public static void ShowDeleteNotifications()
    {
        NotificationForm notificationForm = new NotificationForm();
        notificationForm.labelTitle.Text = "تمت عملية الحذف بنجاح";
        notificationForm.Show();
    } 
    #endregion
}
