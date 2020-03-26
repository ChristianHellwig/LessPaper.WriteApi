using LessPaper.Shared.Interfaces.WriteApi;
using LessPaper.Shared.Interfaces.WriteApi.WriteObjectApi;

namespace LessPaper.WriteService.Models
{
    public class WriteApi : IWriteApi
    {
        /// <inheritdoc />
        public IWriteObjectApi ObjectApi { get; }
    }
}
