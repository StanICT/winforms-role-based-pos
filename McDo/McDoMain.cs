using McDo.Forms;
using McDo.Modules.Product;

namespace McDo
{
    using CUserType = McDo.Setup.ConfigUserType;

    public class McDoMain
    {
        protected static McDoMain main_ = null!;

        protected AdminForm AdminForm;
        protected CustomerForm CustomerForm;

        protected Setup.Setup Setup = null!;
        protected AppDbContext DbCtx = new();

        public ProductManager Products;

        public McDoMain()
        {
            DbCtx.Database.EnsureCreated();

            AdminForm = new(this);
            CustomerForm = new();

            Products = new(DbCtx);

            Initialize();
        }

        public static void Run()
        {
            ApplicationConfiguration.Initialize();

            main_ = new McDoMain();
            McDo.Setup.SetupConfig config = main_.Setup.GetConfiguration()!;

            Application.Run(config.UserType == CUserType.Admin ? main_.AdminForm : main_.CustomerForm);
        }

        protected void Initialize()
        {
            Setup = new Setup.Setup();
        }
    }
}
