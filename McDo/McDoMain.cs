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

            // Initialize setup first so configuration runs before main forms are created
            Initialize();

            // Create shared managers before forms so forms receive fully-initialized dependencies
            Products = new(DbCtx);

            // Create forms after managers are ready
            AdminForm = new(this); 
            CustomerForm = new(this);
        }

        public static void Run()
        {
            ApplicationConfiguration.Initialize();

            main_ = new McDoMain();
            var config = main_.Setup.GetConfiguration()!;

            if (config.UserType == CUserType.Admin)
            {
                Application.Run(main_.AdminForm);
            }
            else
            {
                Application.Run(main_.CustomerForm);
            }
        }


        protected void Initialize()
        {
            Setup = new Setup.Setup();
        }
    }
}
