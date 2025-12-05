namespace McDo
{
    using CUserType = McDo.Setup.ConfigUserType;

    public class McDoMain
    {
        protected static McDoMain main_ = null!;

        protected Setup.Setup Setup = null!;

        public McDoMain()
        {
            Initialize();
        }

        public static void Run()
        {
            ApplicationConfiguration.Initialize();

            main_ = new McDoMain();
            McDo.Setup.SetupConfig config = main_.Setup.GetConfiguration()!;

            Form form = null!;

            switch (config.UserType)
            {
                case CUserType.Admin:
                    form = new McDo.Forms.AdminForm();
                    break;

                case CUserType.Customer:
                    form = new McDo.Forms.CustomerForm();
                    break;
            }

            Application.Run(form);
        }

        protected void Initialize()
        {
            Setup = new Setup.Setup();
        }
    }
}
