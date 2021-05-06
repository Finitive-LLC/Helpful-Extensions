using System.Diagnostics.CodeAnalysis;

namespace Lombiq.HelpfulExtensions.Services
{
    /// <summary>
    /// This service does nothing. However if you inject <c>IEnumerable&lt;ITestingMarkerService&gt;
    /// testingMarkerServices</c> to your service implementation, you will be able to do <c>_isTesting =
    /// testingMarkerServices.Any();</c> to tell if the testing feature is enabled.
    /// </summary>
    [SuppressMessage("Design", "CA1040:Avoid empty interfaces", Justification = "Necessary marker interface.")]
    public interface ITestingMarkerService
    {
    }
}