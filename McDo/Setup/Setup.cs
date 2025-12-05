using System.Text.Json;

namespace McDo.Setup
{
    public enum ConfigUserType
    {
        Customer = 0,
        Admin = 1,
    }

    public class SetupConfig
    {
        public ConfigUserType UserType { get; set; }
    }

    public class Setup
    {
        protected string ConfigFolder = Path.Combine(AppContext.BaseDirectory, "config");

        protected JsonSerializerOptions SerializerOptions = new() { WriteIndented = true };

        protected SetupConfig? Configuration = null;

        public Setup()
        {
            Configuration = GetConfig();
            if (Configuration == null)
                Configure();
        }

        public SetupConfig GetConfiguration()
        {
            return Configuration!;
        }

        protected void SetupDir()
        {
            if (!Directory.Exists(ConfigFolder))
                Directory.CreateDirectory(ConfigFolder);
        }

        protected void Configure()
        {
            var configForm = new Configuration();
            var result = configForm.ShowDialog();

            if (result != DialogResult.OK)
                return;

            SetupConfig config = new() { UserType = configForm.UserType };
            string content = JsonSerializer.Serialize<SetupConfig>(config, SerializerOptions);

            // Ensure the config dirctory is properly setup
            SetupDir();

            File.WriteAllText(Path.Combine(ConfigFolder!, "app_config.json"), content);
        }

        protected SetupConfig? GetConfig()
        {
            // Ensure the config dirctory is properly setup
            SetupDir();

            string configFile = Path.Combine(ConfigFolder!, "app_config.json");

            try
            {
                string content = File.ReadAllText(configFile);
                return JsonSerializer.Deserialize<SetupConfig>(content);
            }
            catch
            {
                return null;
            }
        }
    }
}
