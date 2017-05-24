using System.Collections;
using System.IO.Compression;

namespace ThirdPartyServices
{
    public interface IDocumentRepository
    {
        int StoreDocuments(GZipStream zipStream);

        GZipStream RetrieveDocuments(int id);
    }
}