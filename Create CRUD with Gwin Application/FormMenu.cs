using App;
using App.WinForm.Application.BAL.GwinApplication;
using App.WinForm.Entities.Authentication;
using Create_CRUD_with_Gwin_Application.DAL;


namespace DemoGwin_GroupManagement
{
    public partial class FormMenu : App.WinForm.Application.Presentation.MainForm.FormApplication
    {
        public FormMenu()
        {
            User user = new User();
            user.Language = Gwin.Languages.fr;
            Gwin.Start(typeof(ModelContext), typeof(BaseBAO<>), this, user);
        }

        public override void Reload()
        {
            this.Controls.Clear();
            base.InitializeForm();
            InitializeComponent();
        }
    }
}
