using LessPaper.Shared.Interfaces.ReadApi;
using LessPaper.Shared.Interfaces.ReadApi.ReadObjectApi;

namespace LessPaper.WriteService.Models
{
    public class ReadApi : IReadApi
    {
        /// <inheritdoc />
        public IReadObjectApi ObjectApi { get; }
    }
}
