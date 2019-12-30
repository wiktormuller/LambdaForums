using Microsoft.WindowsAzure.Storage.Blob;

namespace LambdaForums.Application.Interfaces
{
    public interface IUpload
    {
        CloudBlobContainer GetBlobContainer(string connectionString, string containerName);
    }
}
