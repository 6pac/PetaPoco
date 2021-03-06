using Xunit;

namespace PetaPoco.Tests.Integration.Databases.MySqlConnector
{
    [Collection("MySqlConnector")]
    public class MySqlConnectorDatabaseTests : BaseDatabaseTests
    {
        public MySqlConnectorDatabaseTests()
            : base(new MySqlConnectorDBTestProvider())
        {
        }
    }
}