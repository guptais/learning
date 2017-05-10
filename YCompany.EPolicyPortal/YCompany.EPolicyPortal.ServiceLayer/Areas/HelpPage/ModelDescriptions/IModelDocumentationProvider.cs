using System;
using System.Reflection;

namespace YCompany.EPolicyPortal.ServiceLayer.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}