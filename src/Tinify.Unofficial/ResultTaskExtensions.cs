using System.IO;
using System.Threading.Tasks;

namespace Tinify.Unofficial
{
    public static class ResultTaskExtensions
    {
        public static async Task ToFile(this Task<Result> task, string path)
        {
            var result = await task.ConfigureAwait(false);
            await result.ToFile(path).ConfigureAwait(false);
        }

        public static async Task<byte[]> ToBuffer(this Task<Result> task)
        {
            var result = await task.ConfigureAwait(false);
            return result.ToBuffer();
        }

        public static async Task ToStream(this Task<Result> task, Stream stream)
        {
            var result = await task.ConfigureAwait(false);
            await result.ToStream(stream).ConfigureAwait(false);
        }
    }
}
